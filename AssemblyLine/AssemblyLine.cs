
/*PROJECT NAME : Advanced SQL -PROG3070 Final Project MileStone 1
 * FILE NAME   :KanBan Assembly Line Fog Lamp's 
 * PROGRAMER   :Monira Sultana
 * DATE        :April 27, 2017
 * DESCRIPTION : This application display the assembly line of Kanban.
 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;


namespace AssemblyLine
{
    public partial class AssemblyLine : Form
    {
       

        static string connectionString = ConfigurationManager.ConnectionStrings["KanbanFogLamp"].ConnectionString;
        private static Thread dispkanban;
        
        private static volatile bool chartRunning = true;


        static float defectNew = 0.0f;
        static float defectExp = 0.0f;
        static float defectSuper = 0.0f;

        public AssemblyLine()
        {
            InitializeComponent();
        }

        /*
      * FUNCTION    :  private void Form1_Load
      * DESCRIPTION : Loads form and display the entier assembly line
      * PARAMETERS  : object: sender 
      *               EventArgs: e
      * RETURNS     : Nothing       
      */

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();

            float defectNewR = 0.0f;
            float defectExpR = 0.0f;
            float defectSuperR = 0.0f;
            try
            {
                // HERE is where we attempt to OPEN the connection to SQL database...
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = @"SELECT CurrentValue FROM Config WHERE Simulationfactor = 'AssemblyDefectNew'; ";
                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string defectforNew = reader[0].ToString();
                    float.TryParse(defectforNew, out defectNewR);
                    defectNew = defectNewR / 100;
                }
                reader.Close();

                cmd.CommandText = @"SELECT CurrentValue FROM Config WHERE Simulationfactor = 'AssemblyDefectExperienced'; ";

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string defectforExp = reader[0].ToString();
                    float.TryParse(defectforExp, out defectExpR);
                    defectExp = defectExpR / 100;
                }
                reader.Close();
                cmd.CommandText = @"SELECT CurrentValue FROM Config WHERE Simulationfactor = 'AssemblyDefectSuper'; ";

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string defectforSu = reader[0].ToString();
                    float.TryParse(defectforSu, out defectSuperR);
                    defectSuper = defectSuperR / 100;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
           //start a new thread to display the chart and other values
            dispkanban = new Thread(MsChart);
            dispkanban.Start();     
        }


        /*
        * FUNCTION    :  private void MsChart
        * DESCRIPTION : run the thread in a while loop      
        * RETURNS     : Nothing       
        */
        private void MsChart()
        {
            while(chartRunning)
            {
                displayPieChart();
                Thread.Sleep(5000);

            }


         }
        /*
       * FUNCTION    :  private void displayPieChart
       * DESCRIPTION : Display the total assembly line     
       * RETURNS     : Nothing       
       */
        private void displayPieChart()
        {
            //declaring a connection  

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();          
            Dictionary<string, int > foglamp = new Dictionary<string, int >();
            string totalFL = "";
            string experienceL = "";
            int foglampT = 0;
            int goodPnew = 0;
            int goodPExperience = 0;
            int goodPSuper = 0;            
           
            float defectPNew = 0;
            float dePExpe = 0;
            float defectPSu = 0;
            int order = 0;
            int produce = 0;
            
            try
            {
                // HERE is where we attempt to OPEN the connection to SQL database...
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = @"SELECT Count(FogLampID)AS TotalFogLamp, ExperienceLevel from Full_FogLamp
                                     Group By ExperienceLevel;";

                            
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // get the results of column
                    //string worksID =reader[0].ToString();
                     totalFL= reader[0].ToString();
                     experienceL= reader[1].ToString();
                     
                     Int32.TryParse(totalFL, out foglampT);
                     foglamp.Add(experienceL, foglampT);   //what happend if it has the same number of foglamp

                }
                 reader.Close();
                 cmd.CommandText = @"SELECT SUM(Quantity) AS Total_Order FROM Orders; ";
                 reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    
                    string orderamount = reader[0].ToString();                    
                    Int32.TryParse(orderamount, out order);                   

                }
                reader.Close();

                cmd.CommandText = @"SELECT Count(FogLampID) AS TotalFogLamp FROM FogLamp; ";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    string totalP = reader[0].ToString();
                    Int32.TryParse(totalP, out produce);

                }
                reader.Close();



                //calculating yield and defective  

                foreach (string experties in foglamp.Keys)
                {
                    if(experties.Equals("New/Rookie"))
                    {
                        int value = foglamp["New/Rookie"];
                        defectPNew= (float)value * defectNew;        
                        goodPnew = value -(int) Math.Round(defectPNew);
                    }
                    if (experties.Equals("Experienced/Normal"))
                    {
                        int value = foglamp["Experienced/Normal"];
                         dePExpe = (float)value * defectExp;
                        goodPExperience = value -(int)Math.Round(dePExpe);
                    }
                    if (experties.Equals("V.Experienced/Super"))
                    {
                        int value = foglamp["V.Experienced/Super"];
                         defectPSu = (float)value * defectSuper;
                         goodPSuper = value - (int)Math.Round(defectPSu);
                    }
                   
                }
                foglamp.Clear();
                int totalGoodP = goodPnew + goodPExperience + goodPSuper;
                float totalDefect = defectPNew + dePExpe + defectPSu;
                int totalDefI =(int)totalDefect;
                int[] yValues= new int[2]; 
                yValues[0] = totalGoodP;
                yValues[1] = totalDefI;
                string[] xValues = { "Yield", "Defective" };
                this.Invoke((MethodInvoker)delegate
                {

                    pieChart.Series["Series1"].Points.DataBindXY(xValues, yValues);
                    labtotalOrder.Text = " Total Order Amount:  " + order;
                    labtotalProduce.Text = " Total Production: " + produce;
                    labtotalYield.Text = " Total Yield: " + totalGoodP;
                });                        
             }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            chartRunning = false;
            dispkanban.Join();
            this.Close();
        }
    }
}

