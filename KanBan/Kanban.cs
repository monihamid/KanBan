/*PROJECT NAME : Advanced SQL -PROG3070 Final Project MileStone 1
 * FILE NAME   :KanBan Simulation System of Fog Lamp's 
 * PROGRAMER   :Monira Sultana
 * DATE        :April 01, 2017
 * DESCRIPTION : This application set the configuration value for Kanban.
 
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
using System.Windows.Forms.DataVisualization.Charting;

namespace KanBan
{
    public partial class Kanban : Form
    {
       
        string connectionString = ConfigurationManager.ConnectionStrings["KanbanFogLamp"].ConnectionString;
        SqlConnection conn;    //declaring a connection         

        SqlCommand cmd = new SqlCommand();       
       

        public Kanban()
        {
            InitializeComponent();
           
        }
        /*
       * FUNCTION    :  private void Form1_Load
       * DESCRIPTION : Loads form and reads Config data table display the confuration value on the form
       * PARAMETERS  : object: sender 
       *               EventArgs: e
       * RETURNS     : Nothing       
       */

        private void Form1_Load(object sender, EventArgs e)
        {
           
            cmd = new SqlCommand();
            conn = new SqlConnection(connectionString);
            try
            {
                // HERE is where we attempt to OPEN the connection to SQL database...
                cmd.Connection = conn;
                conn.Open();
            

            cmd.CommandText = @"SELECT *FROM Config;";


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();          
                      
            adapter.Fill(table);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = table;
            dataGridViewConfig.DataSource = bSource;
            adapter.Update(table);           

            adapter.Dispose();
             DisplayWorkstation();

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

        /*
      * FUNCTION    :  private void DisplayWorkstation
      * DESCRIPTION : This method display the current workstation settings
      * PARAMETERS  : Nothing
      * RETURNS     : Nothing       
      */
        private void DisplayWorkstation()
        {

            cmd = new SqlCommand();
            SqlConnection conntoW = new SqlConnection(connectionString);
            try
            {
                // HERE is where we attempt to OPEN the connection to SQL database...
                cmd.Connection = conn;
                conntoW.Open();


                SqlDataAdapter adapter = new SqlDataAdapter();

                cmd.CommandText = @"SELECT *FROM WorkStation;";

                adapter.SelectCommand = cmd;
                DataTable workSt = new DataTable();

                adapter.Fill(workSt);
                BindingSource wSSource = new BindingSource();

                wSSource.DataSource = workSt;
                dataGridViewWStation.DataSource = wSSource;
                adapter.Update(workSt);

                adapter.Dispose();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conntoW.Close();
            }

        }

      /*
      * FUNCTION    :  private void buttExit_Click
      * DESCRIPTION : exit application
      * PARAMETERS  : object: sender 
      *               EventArgs: e
      * RETURNS     : Nothing       
      */

        private void buttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      /*
      * FUNCTION    :  private void buttSaveChange_Click
      * DESCRIPTION : save the changed value to the database
      * PARAMETERS  : object: sender 
      *               EventArgs: e
      * RETURNS     : Nothing       
      */
        private void buttSaveChange_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            conn = new SqlConnection(connectionString);
            try
            {
                // HERE is where we attempt to OPEN the connection to SQL database...
                cmd.Connection = conn;
                conn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
             DialogResult result;
             result = MessageBox.Show("Are You sure want to update?", "Conformation", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                bool print = true;

                foreach (DataGridViewRow dgRow in dataGridViewConfig.Rows)

                {
                   
                    for (int i = 0; i < dataGridViewConfig.RowCount; i++)
                    {
                        
                        string SimulationFactor = dgRow.Cells[0].Value.ToString();
                        string CurrentValue = dgRow.Cells[1].Value.ToString();
                        string DataType = dgRow.Cells[2].Value.ToString();
                        if (CurrentValue.Equals("")|| SimulationFactor.Equals("") || DataType.Equals(""))
                        {
                            
                            MessageBox.Show("Current value cannot be blanck");
                            print = false;
                            break;
                        }
                        else
                        {
                            cmd.CommandText = @"UPDATE Config 
                                SET SimulationFactor = '" + SimulationFactor + "', CurrentValue = '" + CurrentValue + "', DataType ='" + DataType + "'" +
                               " WHERE SimulationFactor= '" + SimulationFactor + "';";

                            cmd.ExecuteNonQuery();
                          
                        }
                        
                    }
                }
                    conn.Close();
                if (print)
                {
                    MessageBox.Show("Current values have been saved");
                }
            }

            
   }

        /*
        * FUNCTION    :  private void buttAddConfig_Click
        * DESCRIPTION : Add a new window
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing       
        */
        private void buttAddConfig_Click(object sender, EventArgs e)
        {
           
            NewConfig config = new NewConfig();
            config.ShowDialog();
            //DisplayWorkstation();
        }

        private void buttWorkSt_Click(object sender, EventArgs e)
        {
           // DisplayWorkstation();
            WorkStationConfig config = new WorkStationConfig();
            config.ShowDialog();
            DisplayWorkstation();

            
        }
    }
}
        
    
