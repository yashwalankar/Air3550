using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air3550
{
    class FormDatabaseHelper
    {
        public static void fillAirportsAbv(ComboBox box)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT AirportAbbrev FROM AirportList ", sqlConnection))
                {


                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        box.Items.Add(sqlReader["AirportAbbrev"].ToString());
                    }

                    sqlReader.Close();
                }


            }
        }

        public static void FillPlaneModelsBox(ComboBox box)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT PlaneModel FROM PlaneModel ", sqlConnection))
                {


                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        box.Items.Add(sqlReader["PlaneModel"].ToString());
                    }

                    sqlReader.Close();
                }


            }

        }

        public static void updateCapacityBox(String planeModelInput, Label newCapacityValue_label)
        {
            
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT Capacity FROM PlaneModel WHERE PlaneModel LIKE @planeModelInput ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@planeModelInput", planeModelInput);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();



                    while (sqlReader.Read())
                    {
                        newCapacityValue_label.Text = sqlReader["Capacity"].ToString();
                    }

                    sqlReader.Close();
                }


            }
        }

        public static double getDistance(String originAbv,String destAbv)
        {
            Console.WriteLine(originAbv);
            Console.WriteLine(destAbv);
            if (originAbv == destAbv)
            {
                return 0;
            }
            //co-ordinates for origin
            double lat1=0, lon1=0;
            //co-ordinates for destination
            double lat2=0, lon2=0;

            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT Latitude,Longitude FROM AirportList WHERE AirportAbbrev LIKE @originAirport ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@originAirport", originAbv);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();



                    while (sqlReader.Read())
                    {
                        lat1 = (double) sqlReader["Latitude"];
                        lon1 = (double) sqlReader["Longitude"];
                        //Console.WriteLine(lat1);
                        //Console.WriteLine(lon1);

                    }

                    sqlReader.Close();
                }

                using (SqlCommand sqlCommand = new SqlCommand("SELECT Latitude,Longitude FROM AirportList WHERE AirportAbbrev LIKE @destAirport ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@destAirport", destAbv);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();



                    while (sqlReader.Read())
                    {
                        lat2 = (double)sqlReader["Latitude"];
                        lon2 = (double)sqlReader["Longitude"];
                       // Console.WriteLine(lat2);
                       // Console.WriteLine(lon2);
                    }

                    sqlReader.Close();
                }

                

            }

            double earth = 6371;

            double phi1 = lat1 * Math.PI / 180;
            double phi2 = lat2 * Math.PI / 180;

            double meanphi = (lat2 - lat1) * Math.PI / 180;
            double meanlambda = (lon2 - lon1) * Math.PI / 180;

            double a = Math.Sin(meanphi / 2) * Math.Sin(meanphi / 2) +
                       Math.Cos(phi1) * Math.Cos(phi2) * Math.Sin(meanlambda / 2) * Math.Sin(meanlambda / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double meterresult = earth * c;

            double milesresult = meterresult * 0.621371;
            return milesresult;
        }


       








    } 
}
