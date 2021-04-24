using System;
using System.Collections;
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
        public static void fillAirportsCity(ComboBox box)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT City FROM AirportList ", sqlConnection))
                {


                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        box.Items.Add(sqlReader["City"].ToString());
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

        public static int getPlaneCapacity(String planeModel)
        {
            int capacity =0;
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT Capacity FROM PlaneModel WHERE PlaneModel LIKE @planeModelInput ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@planeModelInput", planeModel);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();



                    while (sqlReader.Read())
                    {
                        capacity = (int) sqlReader["Capacity"];
                    }

                    sqlReader.Close();
                }
            }

            return capacity;
        }

        public static void uploadFlight(flight newFlight)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                string sqlString = "INSERT INTO Flights " +
                    "(originAbv,destAbv,departureTime,arrivalTime,distance,PlaneType,cost,maxCapacity,currCapacity) " +
                    "VALUES " +
                    "(@originAbv,@destAbv,@departureTime,@arrivalTime,@distance,@PlaneType,@cost,@maxCapacity,@currCapacity)";

                SqlCommand command = new SqlCommand(sqlString, sqlConnection);

                command.Parameters.AddWithValue("@originAbv", newFlight.origin);
                command.Parameters.AddWithValue("@destAbv", newFlight.dest);
                command.Parameters.AddWithValue("@departureTime", newFlight.deptTime);
                command.Parameters.AddWithValue("@arrivalTime", newFlight.arrivalTime);
                command.Parameters.AddWithValue("@distance", newFlight.distance);
                command.Parameters.AddWithValue("@PlaneType", newFlight.planeType);
                command.Parameters.AddWithValue("@cost", newFlight.cost);
                command.Parameters.AddWithValue("@maxCapacity", newFlight.maxCapacity);
                command.Parameters.AddWithValue("@currCapacity", newFlight.currCapacity);

                command.ExecuteNonQuery();

            }
        }

        public static void updatePlaneInFlightsTable(int flightId,String planeModel,int capacity)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                string sqlString = "UPDATE Flights SET PlaneType = @PlaneType, maxCapacity = @maxCapacity WHERE Id = @flightId";
                

                SqlCommand command = new SqlCommand(sqlString, sqlConnection);

                command.Parameters.AddWithValue("@PlaneType", planeModel);
                command.Parameters.AddWithValue("@maxCapacity", capacity);
                command.Parameters.AddWithValue("@flightId", flightId);
                

                command.ExecuteNonQuery();

            }
        }

        public static DataTable updateEditGridViewTable(string orig, string dest)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable newDataTable = new DataTable();

                string requestString;
                int option = 0;
                if (!(orig == null) && (dest == null))
                {
                    requestString = "SELECT * FROM Flights WHERE originAbv LIKE @origin";
                    option = 1;
                }
                else if ((orig == null) && !(dest == null))
                {
                    requestString = "SELECT * FROM Flights WHERE destAbv LIKE @destination";
                    option = 2;
                }
                else if (!(orig == null) && !(dest == null))
                {
                    requestString = "SELECT * FROM Flights WHERE originAbv LIKE @origin AND destAbv LIKE @destination";
                    option = 3;
                }
                else
                {
                    requestString = "SELECT * FROM Flights";
                    option = 4;
                }

                using (SqlCommand sqlCommand = new SqlCommand(requestString, sqlConnection))
                {
                    switch (option)
                    {
                        case 1: // origin only supplied
                            sqlCommand.Parameters.AddWithValue("@origin",orig);

                            break;
                        case 2: // destination only supplied
                            sqlCommand.Parameters.AddWithValue("@destination", dest);

                            break;
                        case 3: // origin and destination supplied
                            sqlCommand.Parameters.AddWithValue("@origin", orig);
                            sqlCommand.Parameters.AddWithValue("@destination", dest);

                            break;
                        case 4: // nothing supplied
                            // nothing happens here
                            break;
                        default:
                            return null;
                            break;
                    }

                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(newDataTable);

                    return newDataTable;
                }
            }
        }
        public static String getAirportAbvFromCity(String city)
        {
            string airportAbv="";
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT AirportAbbrev FROM AirportList WHERE City LIKE @city ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@city", city);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            airportAbv = sqlReader["AirportAbbrev"].ToString();
                        }
                    }
                    else
                    {
                        Console.Write("Not in database");
                    }
                    sqlReader.Close();
                }
            }



            return airportAbv;
        }

        public static int[] FindFlights(String originAbv,String destAbv,DateTime deptDate)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            ArrayList flightsFound = new ArrayList();
            int[] bookedFlightsfound = { 0, 0 };

            //Searching if the route actually exists in flights table

            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT id FROM Flights " +
                                                              "WHERE originAbv LIKE @originAbv AND " +
                                                              "destAbv LIKE @destAbv", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@originAbv", originAbv);
                    sqlCommand.Parameters.AddWithValue("@destAbv", destAbv);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            flightsFound.Add((int)sqlReader["Id"]);
                        }
                    }
                    else
                    {
                       // using (SqlCommand sqlCommand = new SqlCommand("SELECT destAbv FROM () " , sqlConnection))
                    }
                    sqlReader.Close();
                }
            }

            Console.WriteLine(flightsFound[0]);


            return bookedFlightsfound;
        }

       
        public static String getAirportAbvFromCity(String city)
        {
            String airportAbbv = "";
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT AirportAbbrev FROM AirportList WHERE City LIKE @City ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@City", city);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();



                    while (sqlReader.Read())
                    {
                        airportAbbv = sqlReader["AirportAbbrev"].ToString();
                    }

                    sqlReader.Close();
                }
            }

            return airportAbbv;
        }







    } 
}
