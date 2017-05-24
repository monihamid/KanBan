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

//https://support.microsoft.com/en-us/help/323116/how-to-create-a-smooth-progress-bar-in-visual-c
namespace WorkstationAndon
{
    public partial class WorkstationAndon : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["KanbanFogLamp"].ConnectionString;
        static SqlConnection conn;    //declaring a connection  
        static SqlCommand cmd;
        static Dictionary<string, int> initialpartValue = new Dictionary<string, int>();

       

        private static Thread progressBar;
        private static object bar;
        private static volatile bool barRunning = true;

        public WorkstationAndon()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void WorkstationAndon_Load(object sender, EventArgs e)
        {
            string noOfWorkstation = "";
            float workStation = 0.0f;

            //int valueOfWS = 0;
            string partid = "";
            string partValue = "";
            float partQuantity = 0;
            int partQint = 0;

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

            cmd.CommandText = @"Select CurrentValue from Config where SimulationFactor = 'NumOfWorkstations';";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // get the results of column
                noOfWorkstation = (string)reader["CurrentValue"];
                float.TryParse(noOfWorkstation, out workStation);
            }
            reader.Close();
            //conn.Close();



            for (int i = 1; i <= workStation; i++)
            {
                comboBoxWS.Items.Add(" WorkStation " + i);


            }
            
            if (!string.IsNullOrEmpty(noOfWorkstation))
            {
                cmd.CommandText = @"SELECT *from Config ;";
                reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    partid = reader[0].ToString();
                    partValue = reader[1].ToString();
                    float.TryParse(partValue, out partQuantity);
                    partQint = (int)partQuantity;

                    initialpartValue.Add(partid, partQint);

                }
                reader.Close();
                conn.Close();

            }
        }

        private void buttSubmit_Click(object sender, EventArgs e)
        {
            string workstationSelect = comboBoxWS.Text;
            string output = Regex.Replace(workstationSelect, "[^0-9]+", string.Empty);
            int valueOfWS = 0;
            Int32.TryParse(output, out valueOfWS);
            if (!string.IsNullOrEmpty(workstationSelect))
            {
                bar = valueOfWS;
                progressBar = new Thread(progress);
                progressBar.Start(bar);
              

            }
            else
            {
                MessageBox.Show(" You need to select a Workstation");
            }            

        }



        private void progress(object ws)
        {            
            int workstation = (int)ws;
           
            while (barRunning)
            {

                DisplayBar(workstation);
               Thread.Sleep(2000);
            }
        }
        private void DisplayBar( int workstation)
        {
           
                SqlConnection connAnd = new SqlConnection(connectionString); ;

                SqlCommand cmd = new SqlCommand();
               
                string partid = "";
                string partValue = "";
                int partQuantity = 0;
                Dictionary<string, int> parts = new Dictionary<string, int>();
            //storing initial values

            try
            {
                //OPEN the connection to SQL database...
                cmd.Connection = connAnd;
                connAnd.Open();


                cmd.CommandText = @"SELECT PartID, Quantity from Bin WHERE WorkStationID =" + workstation + ";";
                SqlDataReader reader = cmd.ExecuteReader();

                //connectionString	"Persist Security Info=False;Integrated Security=true;Initial Catalog=KanbanFogLamp;server=(local)"	string


                while (reader.Read())
                {
                    partid = reader[0].ToString();
                    partValue = reader[1].ToString();
                    Int32.TryParse(partValue, out partQuantity);
                    parts.Add(partid, partQuantity);

                }
                reader.Close();

            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connAnd.Close();
            }

            int initialharness = initialpartValue["HAR01"] + 5;
            int initialreflector = initialpartValue["REF02"] + 5;
            int initialhousing = initialpartValue["HOU03"] + 5;
            int initiallens = initialpartValue["LEN04"] + 5;
            int initialbulbs = initialpartValue["BUL05"] + 5;
            int initialbezel = initialpartValue["BEZ06"] + 5;
                    
            //if (!this.IsHandleCreated && !this.IsDisposed) return;

               this.Invoke((MethodInvoker)delegate
               {
                    //harnes
                   progressBarharness.Value = parts["HAR01"];
                   progressBarharness.Minimum = 0;
                   progressBarharness.Maximum = initialharness;
                   labHarnes.Text = progressBarharness.Value.ToString();
                   if (progressBarharness.Value >= 15)
                   {
                       progressBarharness.ForeColor = Color.LawnGreen;
                   }
                   if (progressBarharness.Value < 15 && progressBarharness.Value >5)
                   {
                       progressBarharness.ForeColor = Color.Yellow;
                   }
                   if (progressBarharness.Value <= 5)
                   {
                       progressBarharness.ForeColor = Color.Red;
                   }

                   progressBarReflector.Maximum = initialreflector;
                   progressBarReflector.Value = parts["REF02"];
                   progressBarReflector.Minimum = 0;
                   labReflector.Text = progressBarReflector.Value.ToString();
                   if (progressBarReflector.Value < 15 && progressBarReflector.Value > 5)
                   {
                       progressBarReflector.ForeColor = Color.Yellow;
                   }
                   if (progressBarReflector.Value <= 5)
                   {
                       progressBarReflector.ForeColor = Color.Red;
                   }
                   if (progressBarReflector.Value >= 15)
                   {
                       progressBarReflector.ForeColor = Color.LawnGreen;
                   }

                   //housing
                   progressBarHousing.Maximum = initialhousing;
                   progressBarHousing.Value = parts["HOU03"];
                   progressBarHousing.Minimum = 0;
                   labHousing.Text = progressBarHousing.Value.ToString();

                   if (progressBarHousing.Value >= 15)
                   {
                       progressBarHousing.ForeColor = Color.LawnGreen;
                   }

                   if (progressBarHousing.Value < 15 && progressBarHousing.Value > 5)
                   {
                       progressBarHousing.ForeColor = Color.Yellow;
                   }
                   if (progressBarHousing.Value <= 5)
                   {
                       progressBarHousing.ForeColor = Color.Red;
                   }



                   //Lens
                   progressBarLens.Maximum = initiallens;
                   progressBarLens.Value = parts["LEN04"];
                   progressBarLens.Minimum = 0;
                   labLens.Text = progressBarLens.Value.ToString();

                   if (progressBarLens.Value >= 15)
                   {
                       progressBarLens.ForeColor = Color.LawnGreen;
                   }
                   if (progressBarLens.Value < 15 && progressBarLens.Value > 5)
                   {
                       progressBarLens.ForeColor = Color.Yellow;
                   }
                   if (progressBarLens.Value <= 5)
                   {
                       progressBarLens.ForeColor = Color.Red;
                   }

                   //Bulb
                   progressBarBulb.Maximum = initialbulbs;
                   progressBarBulb.Value = parts["BUL05"];
                   progressBarBulb.Minimum = 0;
                   labBulb.Text = progressBarBulb.Value.ToString();

                   if (progressBarBulb.Value >= 5)
                   {
                       progressBarBulb.ForeColor = Color.LawnGreen;
                   }
                   if (progressBarBulb.Value < 15 && progressBarBulb.Value > 5)
                   {
                       progressBarBulb.ForeColor = Color.Yellow;
                   }
                   if (progressBarBulb.Value <= 5)
                   {
                       progressBarBulb.ForeColor = Color.Red;
                   }


                   //Bezel
                   progressBarBezel.Maximum = initialbezel;
                   progressBarBezel.Value = parts["BEZ06"];
                   progressBarBezel.Minimum = 0;
                   labBezel.Text = progressBarBezel.Value.ToString();
                   if (progressBarBezel.Value >=15 )
                   {
                       progressBarBezel.ForeColor = Color.LawnGreen;
                   }
                   if (progressBarBezel.Value < 15 && progressBarBezel.Value > 5)
                   {
                       progressBarBezel.ForeColor = Color.Yellow;
                   }
                   if (progressBarBezel.Value <= 5)
                   {
                       progressBarBezel.ForeColor = Color.Red;
                   }

               });


                //System.Threading.Thread.Sleep(2000);
                parts.Clear();
            

        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            barRunning = false;
            progressBar.Join();           
            Application.Exit();
        }
             
     }
    }


