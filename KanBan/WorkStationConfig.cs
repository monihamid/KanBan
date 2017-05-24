
/*
* PROGRAM NAME: ASQL PROG3070 Final Project
* FILE NAME: WorkstationConfig.cs  
* PROGRAMMER: MONIRA SULTANA(7308182)
* DESCRIPTION: This file chaang and save new settings.
* DATE: April 19, 2017

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
using System.Text.RegularExpressions;

namespace KanBan
{
    public partial class WorkStationConfig : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["KanbanFogLamp"].ConnectionString;
        SqlConnection conn;    //declaring a connection         

        SqlCommand cmd = new SqlCommand();
        public WorkStationConfig()
        {
            InitializeComponent();
        }

        private void WorkStationConfig_Load(object sender, EventArgs e)
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

            cmd.CommandText = @"Select CurrentValue from Config where SimulationFactor = 'NumOfWorkstations';";

            SqlDataReader reader = cmd.ExecuteReader();
            string numOfWS;
            float workStation = 0.0f;
           


            while (reader.Read())
            {
                // get the results of column
                numOfWS = (string)reader["CurrentValue"];
                float.TryParse(numOfWS, out workStation);
            }
            reader.Close();
            conn.Close();



            for (int i = 1; i <= workStation; i++)
            {
                comboBoxWS.Items.Add(" WorkStation " + i);
                    
                    
             }
            conn.Close();

        }
        /*
       * FUNCTION    :  private void buttSubmit_Click
       * DESCRIPTION : Add new workstation to the database
       * PARAMETERS  : object: sender 
       *               EventArgs: e
       * RETURNS     : Nothing       
       */
        private void buttSubmit_Click(object sender, EventArgs e)
        {
            string workStation = comboBoxWS.Text; 
            string employeeSkill= comboBoxEmpSkill.Text;
            string output = Regex.Replace(workStation, "[^0-9]+", string.Empty);

            int valueOfWS = 0;

            Int32.TryParse(output, out valueOfWS);

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
            if (!string.IsNullOrEmpty(workStation) && !string.IsNullOrEmpty(employeeSkill))
            {
                cmd.CommandText = @"INSERT INTO WorkStation VALUES (" + valueOfWS + ", '" + employeeSkill + "');";


                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show(" You need to select both Workstation and Employee skill");
            }
            conn.Close();

            comboBoxWS.Items.Clear();
            comboBoxEmpSkill.Items.Clear();
        }
        /*
        * FUNCTION    :  private void buttChangeSettings_Click
        * DESCRIPTION : change workstation values to the database
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing       
        */


        private void buttChangeSettings_Click(object sender, EventArgs e)
        {
            string workStation = comboBoxWS.Text;
            string employeeSkill = comboBoxEmpSkill.Text;
            string output = Regex.Replace(workStation, "[^0-9]+", string.Empty);

            int valueOfWS = 0;

            Int32.TryParse(output, out valueOfWS);

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
            if (!string.IsNullOrEmpty(workStation) && !string.IsNullOrEmpty(employeeSkill))
            {
                cmd.CommandText = @"Update WorkStation SET ExperienceLevel = '" + employeeSkill + "' Where WorkStationID=" + valueOfWS + ";";


                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show(" You need to select both Workstation and Employee skill");
            }

            conn.Close();

            comboBoxWS.Items.Clear();
            comboBoxEmpSkill.Items.Clear();
           
            this.Close();
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


    
        


    
    

