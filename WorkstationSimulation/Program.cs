/*
* PROGRAM NAME: ASQL PROG3070 Final Project
* FILE NAME: Workstation Simulation for of Fog Lamp's 
* PROGRAMMER: MONIRA SULTANA(7308182)
* DESCRIPTION: This file runs all Workstation simulation.
* DATE: April 19, 2017

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;






namespace WorkstationSimulation
{
    class Program
    {
        private static Thread trayRunThread;
        private static volatile bool trayRunning= true;

        static string connectionString = ConfigurationManager.ConnectionStrings["KanbanFogLamp"].ConnectionString;
        static SqlConnection conn;    //declaring a connection         

       // static SqlCommand cmd = new SqlCommand();
        static void Main(string[] args)
        {
            Console.Clear();

            if (args.Count() >= 1)
            {
                // Get the workstation id from the commandline parameter
                string workStation = args[0];
                int workID = 0;

                Int32.TryParse(workStation, out workID);

                Console.WriteLine(">> Starting Simulation <<");
                Console.WriteLine(" Work Station ID : {0}", workStation);
                StartSimulation(conn, workID);
            }
            else
            {
                Console.WriteLine("Usage : WorkstationSimulation.exe [workStationID]");
            }

            Console.ReadKey();
            return;

            
        }

        /*
       * FUNCTION    :  StartSimulation
       * DESCRIPTION : Create foglames and insert into TestTray and Foglamps tables.
       * PARAMETERS  : int: workID               
       * RETURNS     : Nothing       
       */

        private static void StartSimulation(SqlConnection conn, int workID)
        {
            string experienceL = "";
            float levelOfExp = 0.0f;
            string assemblyTime;
            string minuteSec;
            float timeScale = 0.0f;
            int sleepTime = 0;
            string trayTime = "";
            float trayTimeScale = 0.0f;
            int runnerTime =0;

            
           
            
            List<string> parts = new List<string>();
            SqlCommand cmd = new SqlCommand();
           
            conn = new SqlConnection(connectionString);
            try
            {
                // HERE is where we attempt to OPEN the connection to MySQL database...
                cmd.Connection = conn;
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.ReadLine();

                 //MessageBox.Show(ex.ToString());
            }

            // Filling up the bins for this workstation
            cmd.CommandText = @"EXEC BinFillup " + workID + ";";
            cmd.ExecuteNonQuery();

                
            SqlDataReader reader;

            cmd.CommandText = @"SELECT ExperienceLevel FROM WorkStation WHERE WorkStationID = " + workID + ";";
            reader = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
            if (reader.Read())
            {

                experienceL = reader[0].ToString();

                //float.TryParse(trayTime, out tTime);
            }
            reader.Close();

            cmd.CommandText = @"SELECT CurrentValue FROM Config WHERE Simulationfactor = '" + experienceL + "';";        //need to fix
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                assemblyTime = reader[0].ToString();
                float.TryParse(assemblyTime, out levelOfExp);

            }
            reader.Close();
                       
            cmd.CommandText = @"SELECT CurrentValue FROM Config WHERE Simulationfactor = 'MinuteSeconds';";
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                minuteSec = reader[0].ToString();
                float.TryParse(minuteSec, out timeScale);

            }
            reader.Close();
             sleepTime = Convert.ToInt32((levelOfExp / timeScale) * 1000);
            cmd.CommandText = @"SELECT CurrentValue FROM Config WHERE Simulationfactor = 'TrayRunTimeMinutes';";        //need to fix
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                trayTime = reader[0].ToString();
                float.TryParse(trayTime, out trayTimeScale);

            }
            runnerTime = Convert.ToInt32(trayTimeScale / timeScale) * 1000;
            reader.Close();
            //Start running the tray run thread


             object work = new object[2] { workID, runnerTime };
            trayRunThread = new Thread(TrayRun);
            trayRunThread.Start(work);

            while (true)
            {
                bool partsQ = BinQuantity(conn, workID);
                if (partsQ)
                //if (har > 0 && refl > 0 && hous > 0 && len > 0 && bul > 0 && beze > 0)
                {
                    cmd.CommandText = @"EXEC AssembleFogLamp " + workID + ";";
                    cmd.ExecuteNonQuery();
                    //Console.WriteLine("Foglamp has been created\n");
                   // System.Threading.Thread.Sleep(sleepTime);
                }

                else
               
                {
                    Console.WriteLine("Bin is empty");
                    
                    System.Threading.Thread.Sleep(1000);

                    partsQ = BinQuantity(conn, workID);
                    if (partsQ)
                    {
                        cmd.CommandText = @"EXEC AssembleFogLamp " + workID + ";";
                        cmd.ExecuteNonQuery();

                        
                    }
                    
                }
                
                System.Threading.Thread.Sleep(sleepTime);
                
            }
            conn.Close();            

    }
        /*
        * FUNCTION    :  BinQuantity
        * DESCRIPTION : This methods ckecks if there is parts in the Bin to create the Foglamps.
        * PARAMETERS  : int: workID               
        * RETURNS     : bool :quantityOK      
        */
        static private bool BinQuantity(SqlConnection conn, int workStation)
        {
            bool quantityOK = false;
           
            List<string> parts = new List<string>();

            SqlCommand cmd = new SqlCommand();
            conn = new SqlConnection(connectionString);
            try
            {
                // HERE is where we attempt to OPEN the connection to MySQL database...
                cmd.Connection = conn;
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.ReadLine();

                // MessageBox.Show(ex.ToString());
            }
           
            SqlDataReader reader;
            cmd.CommandText = @"SELECT PartID, Quantity FROM Bin WHERE WorkStationID = " + workStation + ";";
            reader = cmd.ExecuteReader();               //time to time connection is closed

            while (reader.Read())
            {
                string value = reader[1].ToString();

                parts.Add(value);

            }
            reader.Close();
            conn.Close();
            string harness = parts[0];
            int har = Convert.ToInt32(harness);
            string reflector = parts[1];
            int refl = Convert.ToInt32(reflector);
            string housing = parts[2];
            int hous = Convert.ToInt32(housing);
            string lens = parts[3];
            int len = Convert.ToInt32(lens);
            string bulb = parts[4];
            int bul = Convert.ToInt32(bulb);
            string bezel = parts[5];
            int beze = Convert.ToInt32(bezel);

            if (har > 0 && refl > 0 && hous > 0 && len > 0 && bul > 0 && beze > 0)
            {
                quantityOK = true;
            }
            return quantityOK;

   }
        /*
        * FUNCTION    :  TrayRun
        * DESCRIPTION : This methods ckecks every tray run time(seconds) if any parts need to be filled and call the methods to fill the parts..
        * PARAMETERS  : object: ws               
        * RETURNS     : Nothing       
        */
        private static void TrayRun(object ws)
        {


            Array argArray = new object[2];
            argArray = (Array)ws;
            int workstation = (int)argArray.GetValue(0);

            int timeMillis = (int)argArray.GetValue(1);       


          
            while(trayRunning)
            {
                
                Thread.Sleep(timeMillis);

                Part_Refil(workstation);
            }
            
        }

        /*
       * FUNCTION    :  Part_Refil
       * DESCRIPTION : This method refill the parts.
       * PARAMETERS  : int: worlstation               
       * RETURNS     : Nothing       
       */
        private static void Part_Refil( int workstation)
        {
            SqlConnection connPR = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();

            Dictionary<string, string> holdPart = new Dictionary<string, string>();

            try
            {
                //connecting to SQL          
                // HERE is where we attempt to OPEN the connection to MySQL database...
                cmd.Connection = connPR;
                connPR.Open();

                cmd.CommandText = @"SELECT PartID, Quantity FROM Bin WHERE workStationID =" + workstation + " AND Quantity <= 5 ;";

                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string partid = "";
                    string value = "";

                    partid = reader[0].ToString();
                    value = reader[1].ToString();

                    holdPart.Add(partid, value);
                }
                reader.Close();

                foreach (string partid in holdPart.Keys)
                {
                    cmd.CommandText = @"EXEC PartRefill " + workstation + ", " + partid + ";";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.ReadKey();
            }
            finally
            {
                connPR.Close();
            }

        }
    }
 }
