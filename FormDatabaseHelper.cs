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

        /*Returns a list of int[2] of flightId of posssible ways to go from origin A to destination B
         * [flighId,0] if direct flight form A to B
         * [flighIdX,flighIdY] for connecting flights where flighIdX is for A to C and flighIdY is for C to A , where C is the connection 
         */
        public static List<int[]> FindFlights_helper(String originAbv,String destAbv)
        {
            int MIN_LAYOVER_TIME_MIN = 40; //in minutes
            int MAX_LAYOVER_TIME_HOURS = 8; //in hours
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            List<int[]> flightsFound = new List<int[]>();

            var possibeRoutesleg1 = new[] { new { id = 1 , dest = "dest" ,arrivalTime =new DateTime() } }.ToList();
            possibeRoutesleg1.Clear();


            //Searching if the route actually exists in flights table

            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                //get all the flights from orign 
                using (SqlCommand sqlCommand = new SqlCommand("SELECT id, destAbv , arrivalTime FROM Flights " +
                                                              "WHERE originAbv LIKE @originAbv ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@originAbv", originAbv);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            int possibleId = (int)sqlReader["id"];
                            String possibleDest = sqlReader["destAbv"].ToString();
                            DateTime arrivalTime = DateTime.Parse(sqlReader["arrivalTime"].ToString());
                            //check for direct flights to destination 
                            if (possibleDest.Equals(destAbv))
                            {
                                flightsFound.Add(new int[]{ possibleId,0});
                            }
                            else
                            {
                                //add all the destination served by origin to a list 
                                possibeRoutesleg1.Add(new { id = possibleId, dest = possibleDest , arrivalTime = arrivalTime });

                            }              
                        }
                    }
                    else
                    {
                       // No flights from origin
                    }
                    sqlReader.Close();
                }
            }

            //check for legged connections
            var possibeRoutesleg2 = new[] { new { id = 1, origin = "dest" ,departureTime = new DateTime()} }.ToList();
            possibeRoutesleg2.Clear();
            
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                
                using (SqlCommand sqlCommand = new SqlCommand("SELECT id, originAbv,departureTime FROM Flights " +
                                                              "WHERE destAbv LIKE @destAbv ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@destAbv", destAbv);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            int possibleId = (int) sqlReader["id"];
                            String possibleConnection = sqlReader["originAbv"].ToString();
                            DateTime departureTime = DateTime.Parse(sqlReader["departureTime"].ToString());
                            possibeRoutesleg2.Add(new { id = possibleId, origin = possibleConnection , departureTime = departureTime});
                        }
                    }
                    
                    sqlReader.Close();
                }

                foreach(var leg1 in possibeRoutesleg1)
                {
                    foreach(var leg2 in possibeRoutesleg2)
                    {
                        if (leg1.dest.Equals(leg2.origin))
                        {
                            bool leg2DepartsAfterMinLayover = (leg2.departureTime >= leg1.arrivalTime.AddMinutes(MIN_LAYOVER_TIME_MIN));
                            bool leg2DepartsBeforeMaxLayover = (leg2.departureTime <= leg1.arrivalTime.AddHours(MAX_LAYOVER_TIME_HOURS));
                            if (leg2DepartsAfterMinLayover && leg2DepartsBeforeMaxLayover)
                            {
                                flightsFound.Add(new int[] { leg1.id, leg2.id });
                            }
                            
                        }
                    }
                }




            }

            /*printing the flights found to test
            foreach (int[] item in flightsFound)
            {
                Console.WriteLine(item[0] + " " + item[1]);

            }*/

            return flightsFound;
        }

       
        public static String getAirportAbvFromCity2(String city)
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

        public static void removeFlightFromRoutes(int flightID)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                string sqlString = "DELETE FROM Flights WHERE Id = @flightId";

                SqlCommand command = new SqlCommand(sqlString, sqlConnection);

                command.Parameters.AddWithValue("@flightId", flightID);

                command.ExecuteNonQuery();
            }
        }

        public static void updateTimesInFlightsTable(int flightID, DateTime arrivalTime, DateTime departureTime, double cost)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();

                string sqlString = "UPDATE Flights SET departureTime = @departTime, arrivalTime = @arrivalTime, cost = @cost " +
                    "WHERE Id = @flightId";

                SqlCommand command = new SqlCommand(sqlString, sqlConnection);

                command.Parameters.AddWithValue("@arrivalTime", arrivalTime);
                command.Parameters.AddWithValue("@departTime", departureTime);
                command.Parameters.AddWithValue("@flightId", flightID);
                command.Parameters.AddWithValue("@cost", cost);

                command.ExecuteNonQuery();
            }
        }

        public static void CheckFlights(List<int[]> flightsFound, DateTime deptDate)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT id FROM BookedFlights WHERE flightId LIKE @flightId AND maxCapcity > currCapacity ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", 1);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            string airportAbv = sqlReader["AirportAbbrev"].ToString();
                        }
                    }
                    
                    sqlReader.Close();
                }
            }

        }

        //returns booked flights id for flights id given the departure date(if exists) 
        public static int getBookedFlights_ID(int flightId, DateTime deptDateChosen)
        {
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT id FROM BookedFlights WHERE flightId LIKE @flightId AND " +
                                                              "CAST( departureTime AS DATE ) LIKE CAST( @deptDateChosen AS DATE) " +
                                                              "", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@flightId", flightId);
                    sqlCommand.Parameters.AddWithValue("@deptDateChosen", deptDateChosen.ToString());
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            return (int) sqlReader["id"];
                        }
                    }
                    else
                    {
                        //flight to insert 
                        flight fl = getFlight_fromFlightsTable(flightId);
                        //insert into BookedFlights table

                        

                        return 0;
                    }

                    sqlReader.Close();
                }
               
            }
            return 0;
        }


        public static void showAvailableFlights(String originAbv, String deptAbv,DateTime deptDate)
        {
            List<int[]> flightsFound = FindFlights_helper(originAbv, deptAbv);



        }

        public static flight getFlight_fromFlightsTable(int flightID)
        {
            flight fl = new flight();
            fl.Id = flightID ;
            string dbString = Properties.Settings.Default.Air3550DBConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(dbString))
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();


                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Flights WHERE Id LIKE @flightID ", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@flightID", flightID);

                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();



                    while (sqlReader.Read())
                    {
                        fl.origin = sqlReader["originAbv"].ToString();
                        fl.dest = sqlReader["destAbv"].ToString();
                        fl.deptTime = DateTime.Parse(sqlReader["departureTime"].ToString());
                        fl.arrivalTime = DateTime.Parse(sqlReader["arrivalTime"].ToString());
                        fl.planeType = sqlReader["PlaneType"].ToString();
                        fl.cost = Convert.ToDouble( sqlReader["cost"].ToString());
                        fl.maxCapacity = (int)sqlReader["maxCapacity"];
                        fl.currCapacity = (int)sqlReader["currCapacity"];
                        fl.distance = (double) sqlReader["distance"];

                    }

                    sqlReader.Close();
                }
            }




            return fl;
        }


    } 
}
