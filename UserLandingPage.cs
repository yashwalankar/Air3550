using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air3550
{
    public partial class UserLandingPage : Form
    {
        User USER;
        int oneway_leg1;
        int oneway_leg2;
        int return_leg1;
        int return_leg2;
        int upcoming_selectedID_ufh;
        DateTime upcoming_selected_dept;

        public UserLandingPage(User user)
        {
            USER = user;
            InitializeComponent();
            Console.WriteLine(user.firstName);
            welcome_label.Text = "Welcome, " + user.firstName + " " + user.lastName;
            userId_value_label.Text = user.id.ToString();
            rewardBalance_value_label.Text = user.rewardBalance.ToString();

            FormDatabaseHelper.fillAirportsCity(origin_comboBox);
            FormDatabaseHelper.fillAirportsCity(destination_comboBox);

            bookFlights_groupBox.Hide();
            upcomingFlights_groupBox.Show();
            pastFlights_groupBox.Hide();

            oneway_groupBox.Hide();
            return_groupBox.Hide();
            ShowReturnComponents(false);

            oneway_leg1=0;
            oneway_leg2=0;
            return_leg1=0;
            return_leg2=0;

            populateUpcomingFlightsGrid(upcomingFlights_datagridview);
            populatePastFlightsGrid(pastflights_datagridview);
            populateCancelledFlightsGrid(cancelled_datagridview);
        }
        
        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Login s = new Login();
            s.Visible = true;
        }

        // ==============================================================================
        // Book Flights Functionality ===================================================
        // ==============================================================================

        private void bookFlights_btn_Click(object sender, EventArgs e)
        {
            upcomingFlights_groupBox.Hide();
            pastFlights_groupBox.Hide();
            bookFlights_groupBox.Show();
            booking_error_label.Text = "";
        }

        private void return_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (return_rBtn.Checked == true)
            {
                ShowReturnComponents(true);
            }
            else
            {
                ShowReturnComponents(false);
            }

            updateTables();
        }

        private void oneWay_rBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (oneWay_rBtn.Checked == true)
            {
                ShowReturnComponents(false);
            }
            else
            {
                ShowReturnComponents(true);
            }

            updateTables();
        }

        private void ShowReturnComponents(bool show)
        {
            if (show)
            {
                returnDate_label.Show();
                returnDate_dtp.Show();
                arrow_label.Text = "<---->";
            }
            else
            {
                returnDate_label.Hide();
                returnDate_dtp.Hide();

                arrow_label.Text = " ---->";
            }
        }

        private void origin_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTables();
        }

        private void destination_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTables();
        }

        private void deptDate_dtp_ValueChanged(object sender, EventArgs e)
        {
            updateTables();
        }

        private void returnDate_dtp_ValueChanged(object sender, EventArgs e)
        {
            updateTables();
        }

        private void updateTables()
        {
            DateTime currentDate = DateTime.Now;

            if (deptDate_dtp.Value < currentDate)
            {
                booking_error_label.Text = "Error - Departure date must be later than current date";
            }
            else if (origin_comboBox.SelectedItem == null || destination_comboBox.SelectedItem == null)
            {
                booking_error_label.Text = "Please select both origin and destination to view flights";
            }
            else if (origin_comboBox.SelectedItem != null && destination_comboBox.SelectedItem != null)
            {
                booking_error_label.Text = "";

                String originCity = origin_comboBox.SelectedItem.ToString();
                String destCity = destination_comboBox.SelectedItem.ToString();

                String originAbv = FormDatabaseHelper.getAirportAbvFromCity(originCity);
                String destAbv = FormDatabaseHelper.getAirportAbvFromCity(destCity);

                DateTime currSysTime = currSysTime_DTP.Value;
                DateTime deptDate = deptDate_dtp.Value;
                DateTime returnDate;
                bool oneWay = oneWay_rBtn.Checked;
                bool returnBooking = return_rBtn.Checked;

                oneway_groupBox.Text = originCity + "-->" + destCity;
                return_groupBox.Text = destCity + "-->" + originCity;

                if (originAbv != destAbv && (deptDate <= currSysTime.AddDays(60)))
                {

                    if (returnBooking)
                    {
                        returnDate = returnDate_dtp.Value;
                        if (returnDate >= deptDate.AddDays(1))
                        {
                            booking_error_label.Text = "";
                            oneway_groupBox.Show();
                            DataTable onewayOptionsTable = FormDatabaseHelper.getAvailableFlights(originAbv, destAbv, deptDate);
                            populateDataGridView(oneway_datagridview, onewayOptionsTable);
                            return_groupBox.Show();
                            DataTable returnOptionsTable = FormDatabaseHelper.getAvailableFlights(destAbv, originAbv, returnDate);
                            populateDataGridView(return_datagridview, returnOptionsTable);
                        }
                        else
                        {
                            booking_error_label.Text = "Error - Return date must be later than departure date";
                        }
                    }
                    else
                    {
                        return_groupBox.Hide();
                        oneway_groupBox.Show();
                        DataTable onewayOptionsTable = FormDatabaseHelper.getAvailableFlights(originAbv, destAbv, deptDate);
                        populateDataGridView(oneway_datagridview, onewayOptionsTable);
                    }
                }
                else
                {
                    Console.WriteLine("Depature date should be within 6 months AND ");
                    Console.WriteLine("origin and dest cannot be same");
                }
            }
        }

        private void oneway_datagridview_SelectionChanged(object sender, EventArgs e)
        {
            if (oneway_datagridview.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = oneway_datagridview.SelectedRows[0];

                if (currentRow != null)
                {

                    String originAbv = currentRow.Cells["originAbv"].Value.ToString();
                    String leg1destAbv = currentRow.Cells["leg1dest"].Value.ToString();
                    String leg1deptTime = currentRow.Cells["leg1DeptTime"].Value.ToString();
                    String leg1ArrivalTime = currentRow.Cells["leg1ArrivalTime"].Value.ToString();

                    int leg1id = (int)currentRow.Cells["leg1id"].Value;

                    one_leg1_selectedFlight_label.Text = originAbv + "-->" + leg1destAbv;
                    one_leg1_departure_label.Text = "Departure: " + leg1deptTime;
                    one_leg1_arrival_label.Text = "Arrival: " + leg1ArrivalTime;

                    double cost_total_oneway = 0;
                    double cost_leg1 = FormDatabaseHelper.getCostFromBookingTable(Convert.ToInt32(leg1id));
                    cost_total_oneway += cost_leg1;
                    string cost_str_oneway = "Cost: " + cost_leg1.ToString();

                    String leg2origin = "";//6 
                    String leg2dest = ""; //7
                    String leg2deptTime = ""; //8
                    String leg2arrivalTime = "";//9
                    double cost_leg2 = 0;
                    int leg2id = (int)currentRow.Cells["leg2id"].Value;

                    oneway_leg1 = 0;
                    oneway_leg2 = 0;

                    oneway_leg1 = leg1id;
                    oneway_leg2 = leg2id;

                    if (leg2id != 0)
                    {
                        leg2origin = currentRow.Cells["leg2origin"].Value.ToString();
                        leg2dest = currentRow.Cells["leg2Dest"].Value.ToString();
                        leg2deptTime = currentRow.Cells["leg2deptTime"].Value.ToString();
                        leg2arrivalTime = currentRow.Cells["leg2ArrivalTime"].Value.ToString();

                        oneway_leg2_groupBox.Show();
                        one_leg2_selectedFlight_label.Text = leg2origin + "-->" + leg2dest;
                        one_leg2_dept_label.Text = "Departure: " + leg2deptTime;
                        one_leg2_arrival_label.Text = "Arrival: " + leg2arrivalTime;

                        cost_leg2 = FormDatabaseHelper.getCostFromBookingTable(Convert.ToInt32(leg2id));
                        cost_str_oneway = cost_str_oneway + " + " + cost_leg2.ToString() + " + 8 = ";
                        cost_total_oneway += (cost_leg2 + 8);
                        cost_str_oneway = cost_str_oneway + cost_total_oneway.ToString();

                    }
                    else
                    {
                        oneway_leg2_groupBox.Hide();
                    }


                    oneway_cost_label.Text = cost_str_oneway;
                }
            }
        }

        private void return_datagridview_SelectionChanged(object sender, EventArgs e)
        {
            if (return_datagridview.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = return_datagridview.SelectedRows[0];

                if (currentRow != null)
                {
                    String originAbv = currentRow.Cells["originAbv"].Value.ToString();
                    String leg1destAbv = currentRow.Cells["leg1dest"].Value.ToString();
                    String leg1deptTime = currentRow.Cells["leg1DeptTime"].Value.ToString();
                    String leg1ArrivalTime = currentRow.Cells["leg1ArrivalTime"].Value.ToString();

                    int leg1id = (int)currentRow.Cells["leg1id"].Value;
                    Console.WriteLine("-------------->" + leg1id);
                    return_leg1_selectedflight_label.Text = originAbv + "-->" + leg1destAbv;
                    return_leg1_departure_label.Text = "Departure: " + leg1deptTime;
                    return_leg1_arrival_label.Text = "Arrival: " + leg1ArrivalTime;

                    double cost_total_return = 0;
                    double cost_leg1 = FormDatabaseHelper.getCostFromBookingTable(Convert.ToInt32(leg1id));
                    cost_total_return += cost_leg1;
                    string cost_str_return = "Cost: " + cost_leg1.ToString();


                    String leg2origin = "";//6 
                    String leg2dest = ""; //7
                    String leg2deptTime = ""; //8
                    String leg2arrivalTime = "";//9
                    double cost_leg2 = 0;
                    int leg2id = (int)currentRow.Cells["leg2id"].Value;

                    return_leg1 = 0;
                    return_leg2 = 0;

                    return_leg1 = leg1id;
                    return_leg2 = leg2id;



                    if (leg2id != 0)
                    {
                        leg2origin = currentRow.Cells["leg2origin"].Value.ToString();
                        leg2dest = currentRow.Cells["leg2Dest"].Value.ToString();
                        leg2deptTime = currentRow.Cells["leg2deptTime"].Value.ToString();
                        leg2arrivalTime = currentRow.Cells["leg2ArrivalTime"].Value.ToString();
                        return_leg2_groupbox.Show();
                        return_leg2_selectedflight_label.Text = leg2origin + "-->" + leg2dest;
                        return_leg2_departure_label.Text = "Departure: " + leg2deptTime;
                        return_leg2_arrival_label.Text = "Arrival: " + leg2arrivalTime;

                        cost_leg2 = FormDatabaseHelper.getCostFromBookingTable(Convert.ToInt32(leg2id));
                        cost_str_return = cost_str_return + " + " + cost_leg2.ToString() + " + 8 = ";
                        cost_total_return += (cost_leg2 + 8);
                        cost_str_return = cost_str_return + cost_total_return.ToString();
                    }
                    else
                    {
                        return_leg2_groupbox.Hide();
                    }

                    return_cost_label.Text = cost_str_return;
                }
            }
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            bool confirmed = false;
            if (return_rBtn.Checked == true)
            {
                confirmed = onewayConfirm_checkbox.Checked && return_confirm_checkBox.Checked;
            }
            else
            {
                confirmed = onewayConfirm_checkbox.Checked;
            }

            if (confirmed)
            {
                Console.WriteLine("one way ids" + oneway_leg1 + " &" + oneway_leg2);
                Console.WriteLine("one way ids" + return_leg1 + " &" + return_leg2);
                UserFlightHistory ticket1 = new UserFlightHistory(USER.id, oneway_leg1, oneway_leg2);
                if (return_rBtn.Checked == true)
                {
                    UserFlightHistory ticket2 = new UserFlightHistory(USER.id, return_leg1, return_leg2);
                    Checkout checkout = new Checkout(true, USER, ticket1, ticket2);
                    checkout.Show();
                }
                else
                {
                    Checkout checkout = new Checkout(false, USER, ticket1, null);
                    checkout.Show();
                }
            }
            else
            {
                booking_error_label.Text = "Error - Please confirm both flights";
            }
        }

        // ==============================================================================
        // Upcoming Flights Functionality ===============================================
        // ==============================================================================

        private void pastFlights_btn_Click(object sender, EventArgs e)
        {
            bookFlights_groupBox.Hide();
            upcomingFlights_groupBox.Hide();
            pastFlights_groupBox.Show();
            populatePastFlightsGrid(pastflights_datagridview);
            populateCancelledFlightsGrid(cancelled_datagridview);
        }

        private void upComingFlights_btn_Click(object sender, EventArgs e)
        {
            bookFlights_groupBox.Hide();
            pastFlights_groupBox.Hide();
            upcomingFlights_groupBox.Show();

            populateUpcomingFlightsGrid(upcomingFlights_datagridview);
        }

        public static void populateDataGridView(DataGridView gridview,DataTable table)
        {
            foreach (DataColumn column in table.Columns)
            {
                Console.Write(column.ColumnName);
                Console.Write(" ");
            }
            Console.WriteLine("\n -------------------\n");

            foreach (DataRow dataRow in table.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("");
            }
            if (table.Rows.Count>0)
            {
                gridview.DefaultCellStyle.Format = "g";
                gridview.DataSource = table;
                gridview.AutoGenerateColumns = false;
                gridview.Columns[0].Name = "originAbv"; // name
                gridview.Columns[0].HeaderText = "Origin "; // header text
                gridview.Columns[0].DataPropertyName = "originAbv"; // field name

                gridview.Columns[1].Name = "leg1dest"; // name
                gridview.Columns[1].HeaderText = "Leg 1 Dest"; // header text
                gridview.Columns[1].DataPropertyName = "leg1dest"; // field name

                gridview.Columns[2].Name = "leg2dest"; // name
                gridview.Columns[2].HeaderText = "Leg 2 Dest"; // header text
                gridview.Columns[2].DataPropertyName = "leg2dest"; // field name

                gridview.Columns[3].Name = "leg1deptTime"; // name
                gridview.Columns[3].HeaderText = "Leg 1 Dept"; // header text
                gridview.Columns[3].DataPropertyName = "leg1deptTime"; // field name

                gridview.Columns[4].Name = "leg1ArrivalTime"; // name
                gridview.Columns[4].HeaderText = "Leg 1 Arrival"; // header text
                gridview.Columns[4].DataPropertyName = "leg1ArrivalTime"; // field name

                gridview.Columns[5].Name = "leg2deptTime"; // name
                gridview.Columns[5].HeaderText = "Leg 2 Departure"; // header text
                gridview.Columns[5].DataPropertyName = "leg2deptTime"; // field name

                gridview.Columns[6].Name = "leg2ArrivalTime"; // name
                gridview.Columns[6].HeaderText = "Leg 2 Arrival"; // header text
                gridview.Columns[6].DataPropertyName = "leg2ArrivalTime"; // field name

                gridview.Columns[7].Name = "leg1id"; // name
                gridview.Columns[7].HeaderText = "Leg 1 ID"; // header text
                gridview.Columns[7].DataPropertyName = "leg1id"; // field name

                gridview.Columns[8].Name = "leg2origin"; // name
                gridview.Columns[8].HeaderText = "leg2 origin"; // header text
                gridview.Columns[8].DataPropertyName = "leg2origin"; // field name
                gridview.Columns[8].Visible = false;

                gridview.Columns[9].Name = "leg2id"; // name
                gridview.Columns[9].HeaderText = "leg 2 id"; // header text
                gridview.Columns[9].DataPropertyName = "leg2id"; // field name
   
                gridview.Columns[10].Visible = false;
            }
            else
            {
                gridview.DataSource = new DataTable();
            }
        }

        private void populateUpcomingFlightsGrid(DataGridView gridview)
        {
            //upcomingFlights_datagridview

            Console.WriteLine("-------------currsys time->"+ currSysTime_DTP.Value.ToString());
            DataTable upcoming = FormDatabaseHelper.generateUpcomingFlightsDataTable(USER.id, currSysTime_DTP.Value);

            gridview.DefaultCellStyle.Format = "g";
            gridview.DataSource = upcoming;
            gridview.AutoGenerateColumns = false;
            gridview.Columns[0].Name = "OriginAbv"; // name
            gridview.Columns[0].HeaderText = "Origin "; // header text
            gridview.Columns[0].DataPropertyName = "OriginAbv"; // field name
            
            gridview.Columns[1].Name = "connectionAbv"; // name
            gridview.Columns[1].HeaderText = "Connection "; // header text
            gridview.Columns[1].DataPropertyName = "connectionAbv"; // field name

            gridview.Columns[2].Name = "finaldestAbv"; // name
            gridview.Columns[2].HeaderText = "Destination"; // header text
            gridview.Columns[2].DataPropertyName = "finaldestAbv"; // field name

            gridview.Columns[3].Name = "DepartureDate"; // name
            gridview.Columns[3].HeaderText = "Departure Origin"; // header text
            gridview.Columns[3].DataPropertyName = "DepartureDate"; // field name

            gridview.Columns[4].Name = "ArrivalDate"; // name
            gridview.Columns[4].HeaderText = "Arrival final Dest"; // header text
            gridview.Columns[4].DataPropertyName = "ArrivalDate"; // field name

            gridview.Columns[5].Name = "PaymentType"; // name
            gridview.Columns[5].HeaderText = "1- Card 2-Rewards"; // header text
            gridview.Columns[5].DataPropertyName = "PaymentType"; // field name

            gridview.Columns[6].Name = "PaymentAmount"; // name
            gridview.Columns[6].HeaderText = "Cost"; // header text
            gridview.Columns[6].DataPropertyName = "PaymentAmount"; // field name

            gridview.Columns[7].Name = "UserHistId"; // name
            gridview.Columns[7].HeaderText = "UserHist ID"; // header text
            gridview.Columns[7].DataPropertyName = "UserHistId"; // field name
            

            gridview.Columns[8].Visible = false;

            gridview.Columns[9].Visible = false;

            gridview.Columns[10].Visible = false;

            gridview.Columns[11].Visible = false;

            gridview.Columns[12].Visible = false;

            gridview.Columns[13].Visible = false;

            gridview.Columns[14].Visible = false;

        }

        private void currSysTime_DTP_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(currSysTime_DTP.Value.ToString());
            populateUpcomingFlightsGrid(upcomingFlights_datagridview);
            populatePastFlightsGrid(pastflights_datagridview);
            populateCancelledFlightsGrid(cancelled_datagridview);
        }

        private void populatePastFlightsGrid(DataGridView gridview)
        {
            

            DataTable past = FormDatabaseHelper.generatePastFlightsDataTable(USER.id, currSysTime_DTP.Value);

            gridview.DefaultCellStyle.Format = "g";
            gridview.DataSource = past;
            gridview.AutoGenerateColumns = false;
            gridview.Columns[0].Name = "OriginAbv"; // name
            gridview.Columns[0].HeaderText = "Origin "; // header text
            gridview.Columns[0].DataPropertyName = "OriginAbv"; // field name

            gridview.Columns[1].Name = "connectionAbv"; // name
            gridview.Columns[1].HeaderText = "Connection "; // header text
            gridview.Columns[1].DataPropertyName = "connectionAbv"; // field name

            gridview.Columns[2].Name = "finaldestAbv"; // name
            gridview.Columns[2].HeaderText = "Destination"; // header text
            gridview.Columns[2].DataPropertyName = "finaldestAbv"; // field name

            gridview.Columns[3].Name = "DepartureDate"; // name
            gridview.Columns[3].HeaderText = "Departure Origin"; // header text
            gridview.Columns[3].DataPropertyName = "DepartureDate"; // field name

            gridview.Columns[4].Name = "ArrivalDate"; // name
            gridview.Columns[4].HeaderText = "Arrival final Dest"; // header text
            gridview.Columns[4].DataPropertyName = "ArrivalDate"; // field name

            gridview.Columns[5].Name = "PaymentType"; // name
            gridview.Columns[5].HeaderText = "1- Card 2-Rewards"; // header text
            gridview.Columns[5].DataPropertyName = "PaymentType"; // field name

            gridview.Columns[6].Name = "PaymentAmount"; // name
            gridview.Columns[6].HeaderText = "Cost"; // header text
            gridview.Columns[6].DataPropertyName = "PaymentAmount"; // field name


            gridview.Columns[7].Name = "UserHistId"; // name
            gridview.Columns[7].HeaderText = "UserHist ID"; // header text
            gridview.Columns[7].DataPropertyName = "UserHistId"; // field name
            gridview.Columns[7].Visible = false;

            gridview.Columns[8].Visible = false;

            gridview.Columns[9].Visible = false;

            gridview.Columns[10].Visible = false;

            gridview.Columns[11].Visible = false;

            gridview.Columns[12].Visible = false;

            gridview.Columns[13].Visible = false;

            gridview.Columns[14].Visible = false;

        }

        private void populateCancelledFlightsGrid(DataGridView gridview)
        {
            DataTable past = FormDatabaseHelper.generateCancelledFlightsDataTable(USER.id);

            gridview.DefaultCellStyle.Format = "g";
            gridview.DataSource = past;
            gridview.AutoGenerateColumns = false;

            gridview.Columns[0].Name = "Status"; // name
            gridview.Columns[0].HeaderText = "Status "; // header text
            gridview.Columns[0].DataPropertyName = "Status"; // field name

            gridview.Columns[1].Name = "OriginAbv"; // name
            gridview.Columns[1].HeaderText = "Origin "; // header text
            gridview.Columns[1].DataPropertyName = "OriginAbv"; // field name

            gridview.Columns[2].Name = "connectionAbv"; // name
            gridview.Columns[2].HeaderText = "Connection "; // header text
            gridview.Columns[2].DataPropertyName = "connectionAbv"; // field name

            gridview.Columns[3].Name = "finaldestAbv"; // name
            gridview.Columns[3].HeaderText = "Destination"; // header text
            gridview.Columns[3].DataPropertyName = "finaldestAbv"; // field name

            gridview.Columns[4].Name = "DepartureDate"; // name
            gridview.Columns[4].HeaderText = "Departure Origin"; // header text
            gridview.Columns[4].DataPropertyName = "DepartureDate"; // field name

            gridview.Columns[5].Name = "ArrivalDate"; // name
            gridview.Columns[5].HeaderText = "Arrival final Dest"; // header text
            gridview.Columns[5].DataPropertyName = "ArrivalDate"; // field name

            gridview.Columns[6].Name = "PaymentType"; // name
            gridview.Columns[6].HeaderText = "1- Card 2-Rewards"; // header text
            gridview.Columns[6].DataPropertyName = "PaymentType"; // field name

            gridview.Columns[7].Name = "PaymentAmount"; // name
            gridview.Columns[7].HeaderText = "Cost"; // header text
            gridview.Columns[7].DataPropertyName = "PaymentAmount"; // field name


            gridview.Columns[8].Name = "UserHistId"; // name
            gridview.Columns[8].HeaderText = "UserHist ID"; // header text
            gridview.Columns[8].DataPropertyName = "UserHistId"; // field name
            gridview.Columns[8].Visible = false;

            gridview.Columns[9].Visible = false;

            gridview.Columns[10].Visible = false;

            
            gridview.Columns[11].Visible = false;

            gridview.Columns[12].Visible = false;

            gridview.Columns[13].Visible = false;

            gridview.Columns[14].Visible = false;
        }
        

        private void upcomingFlights_datagridview_SelectionChanged(object sender, EventArgs e)
        {
            
            if (upcomingFlights_datagridview.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = upcomingFlights_datagridview.SelectedRows[0];

                if (currentRow != null)
                {
                    string userhistID =  currentRow.Cells["UserHistID"].Value.ToString();
                    upcoming_selectedval_label.Text = userhistID;

                    upcoming_selectedID_ufh = Convert.ToInt32(userhistID);

                    upcoming_selected_dept = DateTime.Parse(currentRow.Cells["DepartureDate"].Value.ToString()) ;

                    if (upcoming_selected_dept.AddDays(-1) < currSysTime_DTP.Value)
                    {
                        printboardingpass_btn.Enabled = true;
                        print_pass_label1.Visible = false;
                        print_pass_label2.Visible = false;
                    }
                    else
                    {
                        printboardingpass_btn.Enabled = false;
                        print_pass_label1.Visible = true;
                        print_pass_label2.Visible = true;
                    }
                }
            }
        }

        private void printboardingpass_btn_Click(object sender, EventArgs e)
        {
            if (upcoming_selected_dept.AddDays(-1) < currSysTime_DTP.Value)
            {
                //within 24hrs
                //print boarding pass

            }
            else
            {
                MessageBox.Show("Boarding Pass Available 24hours prior to flight");
            }
        }

        private void cancelFlight_btn_Click(object sender, EventArgs e)
        {
            if (currSysTime_DTP.Value > upcoming_selected_dept.AddDays(-1))
            {
                //flight within 24 hours cannot cancel
                MessageBox.Show("Flight takes off in 24 hours cannot cancel");

            }
            else
            {
                //cancel in userhistid
                Console.WriteLine("cancelling the booking");
                FormDatabaseHelper.cancelBooking(upcoming_selectedID_ufh);
                populateUpcomingFlightsGrid(upcomingFlights_datagridview);
            }
        }

        private void UserLandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
