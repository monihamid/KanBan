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
    public partial class Configuration : Form
    {
       
        string connectionString = ConfigurationManager.ConnectionStrings["KanbanFogLamp"].ConnectionString;
        SqlConnection conn;    //declaring a connection         

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            //    // ConfigData.GetConfigurationData();
            //    //ConfiguarationValues config = new ConfiguarationValues();
            //    //InitializeConfigSettings(config);
            //    //BuildConfigurationData();

            //    //ConfiguarationValues data = new ConfiguarationValues();
            //    connectionString = ConfigurationManager.ConnectionStrings["KanbanFogLamp"].ConnectionString;

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

            cmd.CommandText = @"SELECT *FROM Config;";

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBoxHerness.Text = ((int)reader[0]).ToString();
                textBoxReflector.Text = ((int)reader[1]).ToString();
                textBoxHousing.Text = ((int)reader[2]).ToString();
                textBoxLenses.Text = ((int)reader[3]).ToString();
                textBoxBulbs.Text = ((int)reader[4]).ToString();
                textBoxBuzels.Text = ((int)reader[5]).ToString();
                textBoxTrayCap.Text = ((int)reader[6]).ToString();
                textBoxWorkS.Text = ((int)reader[7]).ToString();
                textBoxAssemblyTBeginner.Text = ((int)reader[8]).ToString();
                textBoxassemblyTExperience.Text = ((int)reader[9]).ToString();
                textBoxAssemblyTSuper.Text = ((int)reader[10]).ToString();
                textBoxRunner.Text = ((int)reader[11]).ToString();
                textBoxAssemblyDBeginner.Text = ((double)reader[12]).ToString();
                textBoxAssemblyDExperience.Text = ((double)reader[13]).ToString();
                textBoxAssemblyDSuper.Text = ((double)reader[14]).ToString();
                textBoxTime.Text = ((int)reader[15]).ToString();


            }
            reader.Close();
            conn.Close();


        }
        public void InitializeConfigSettings(ConfigurationValues configData)
        {
            textBoxHerness.Text = configData.BinHarnessCapacity.ToString();
            textBoxReflector.Text = configData.BinReflectorCapacity.ToString();
            textBoxHousing.Text = configData.BinHousingCapacity.ToString();
            textBoxLenses.Text = configData.BinLensCapacity.ToString();
            textBoxBulbs.Text = configData.BinBulbCapacity.ToString();
            textBoxBuzels.Text = configData.BinBezelCapacity.ToString();
            textBoxTrayCap.Text = configData.TrayCapacity.ToString();
            textBoxWorkS.Text = configData.NumOfWorkstations.ToString();
            textBoxAssemblyTBeginner.Text = configData.AssemblyTimeBeginner.ToString();
            textBoxassemblyTExperience.Text = configData.AssemblyTimeExperienced.ToString();
            textBoxassemblyTExperience.Text = configData.AssemblyTimeSuper.ToString();
            textBoxRunner.Text = configData.TrayRunTimeMinutes.ToString();
            textBoxAssemblyDBeginner.Text = configData.AssemblyDefectBeginner.ToString();
            textBoxAssemblyDExperience.Text = configData.AssemblyDefectExperienced.ToString();
            textBoxAssemblyDSuper.Text = configData.AssemblyDefectSuper.ToString();
            textBoxTime.Text = configData.MinuteSeconds.ToString();

            ConfigData = configData;

            
        }

        private ConfigurationValues BuildConfigurationData()
        {
            ConfigurationValues newData = new ConfigurationValues();

            newData.BinHarnessCapacity = int.Parse(textBoxHerness.Text);
            newData.BinReflectorCapacity = int.Parse(textBoxReflector.Text);
            newData.BinHousingCapacity = int.Parse(textBoxHousing.Text);
            newData.BinLensCapacity = int.Parse(textBoxLenses.Text);
            newData.BinBulbCapacity = int.Parse(textBoxBulbs.Text);
            newData.BinBezelCapacity = int.Parse(textBoxBuzels.Text);
            newData.TrayCapacity = int.Parse(textBoxTrayCap.Text);
            newData.NumOfWorkstations = int.Parse(textBoxWorkS.Text);
            newData.AssemblyTimeBeginner = int.Parse(textBoxAssemblyTBeginner.Text);
            newData.AssemblyTimeExperienced = int.Parse(textBoxassemblyTExperience.Text);
            newData.AssemblyTimeSuper = int.Parse(textBoxAssemblyTSuper.Text);
            newData.TrayRunTimeMinutes = int.Parse(textBoxRunner.Text);
            newData.AssemblyDefectBeginner = int.Parse(textBoxAssemblyDBeginner.Text);
            newData.AssemblyDefectExperienced = int.Parse(textBoxAssemblyDExperience.Text);
            newData.AssemblyDefectSuper = double.Parse(textBoxAssemblyDSuper.Text);            
            newData.MinuteSeconds = int.Parse(textBoxTime.Text);

            return newData;
                       



    }

        private void buttClose_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            string herness = textBoxHerness.Text;
            int binHerness = 0;
            Int32.TryParse(herness, out binHerness);
            string reflector = textBoxReflector.Text;
            int binReflector = 0;
            Int32.TryParse(reflector, out binReflector);
            string housing =textBoxHousing.Text;
            int binHousing = 0;
            Int32.TryParse(housing, out binHousing);
            string lenses = textBoxLenses.Text;
            int binLenses = 0;
            Int32.TryParse(lenses, out binLenses);
            string bulbs= textBoxBulbs.Text;
            int binBulbs = 0;
            Int32.TryParse(bulbs, out binBulbs);
            string buzels = textBoxBuzels.Text;
            int binBuzel = 0;
            Int32.TryParse(buzels, out binBuzel);
            string traycap = textBoxTrayCap.Text;
            int maxTray = 0;
            Int32.TryParse(traycap, out maxTray);
            string workStation= textBoxWorkS.Text;
            int numOfWS = 0;
            Int32.TryParse(workStation, out numOfWS);
            string assTimeBeginner = textBoxAssemblyTBeginner.Text;
            int assemblyTBeg = 0;
            Int32.TryParse(assTimeBeginner, out assemblyTBeg);
            string assTimeExep = textBoxassemblyTExperience.Text;
            int assemblyTExp = 0;
            Int32.TryParse(assTimeExep, out assemblyTExp);
            string assblyTimeSuper = textBoxassemblyTExperience.Text;
            int assemblyTSuper = 0;
            Int32.TryParse(assblyTimeSuper, out assemblyTSuper);
            string runner =  textBoxRunner.Text;
            int trayRunner = 0;
            Int32.TryParse(runner, out trayRunner);

            string assDeferctBeginner = textBoxAssemblyDBeginner.Text;
            double assDeftBeginner = 0;
            double.TryParse(assDeferctBeginner, out assDeftBeginner);

            string assDefectExpe = textBoxAssemblyDExperience.Text;
            double assDeftExp = 0;
            double.TryParse(assDefectExpe, out assDeftExp);
            string assDefectSuper = textBoxAssemblyDSuper.Text;
            double assDeftSuper = 0;
            double.TryParse(assDefectSuper, out assDeftSuper);
            string timeScale = textBoxTime.Text;
            int conTime = 0;
            Int32.TryParse(timeScale, out conTime);



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


            if (herness.Equals("")|| reflector.Equals("")|| housing.Equals("")|| lenses.Equals("")|| bulbs.Equals("")|| buzels.Equals("")
                || maxTray.Equals("")|| workStation.Equals("")|| assTimeBeginner.Equals("")|| assTimeExep.Equals("")|| assblyTimeSuper.Equals("")||
                runner.Equals("")|| assDeferctBeginner.Equals("")|| assDefectSuper.Equals("")|| assDefectExpe.Equals("")||
               timeScale.Equals(""))
            {
                MessageBox.Show("You can not leave any field blanck. Please add value for each field.");
            }
            else
            {
                cmd.CommandText = @"UPDATE Config 
                                SET BinHarnessCapacity = " + binHerness + ", BinReflectorCapacity =" + binReflector + ", BinHousingCapacity = " + binHousing + ", BinLensCapacity = " + binLenses + ", BinBulbCapacity = " + binBulbs + ", BinBezelCapacity = "
                                    + binBuzel + ", TrayCapacity = " + maxTray + ", NumOfWorkstations = " + numOfWS + ", AssemblyTimeBeginner = " + assemblyTBeg + ", AssemblyTimeExperienced = " + assemblyTExp + ", AssemblyTimeSuper = "
                   + assemblyTSuper + ", TrayRunTimeMinutes = " + trayRunner + ", AssemblyDefectBeginner = " + assDeftBeginner + ", AssemblyDefectExperienced = " + assDeftExp + ", AssemblyDefectSuper = " + assDeftSuper + ", MinuteSeconds = " + conTime + "; ";

                cmd.ExecuteNonQuery();
            }
            conn.Close();

           
        }
    }
}
