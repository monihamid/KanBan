
/* FILE NAME   :KanBan Simulation System of Fog Lamp's 
 * PROGRAMER   :Monira Sultana
 * DATE        :Aplir 01, 2017
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
    public partial class NewConfig : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["KanbanFogLamp"].ConnectionString;
        SqlConnection conn;    //declaring a connection         

        SqlCommand cmd = new SqlCommand();
        
        public NewConfig()
        {
            InitializeComponent();
           
        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        * FUNCTION    :  private void buttCreate_Click
        * DESCRIPTION : Add new simulation value to database
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing       
        */
        private void buttCreate_Click(object sender, EventArgs e)
        {
            string simulationF = textBoxSimuFact.Text;
            string currentV = textBoxCurrentV.Text;
            string dataType = comboBoxDataType.Text;

            cmd = new SqlCommand();
            conn = new SqlConnection(connectionString);
            try
            {
                // HERE is where we attempt to OPEN the connection to MySQL database...
                cmd.Connection = conn;
                conn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            if (simulationF.Equals("") || currentV.Equals("")|| dataType.Equals(""))

            {
                MessageBox.Show("Please enter all Fields");
            }
            else
            {
                cmd.CommandText = @"INSERT INTO Config (SimulationFactor, CurrentValue, DataType) VALUES
 	                          ('" + simulationF + "', '" + currentV + "', '" + dataType + "');";

                cmd.ExecuteNonQuery();

                conn.Close();
                textBoxSimuFact.Clear();
                textBoxCurrentV.Clear();
                comboBoxDataType.Items.Clear();
            }

        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
