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
        public UserLandingPage(User user)
        {
            InitializeComponent();
            welcome_label.Text = "Welcome, " + user.firstName + " " + user.lastName;
            userId_value_label.Text = user.id.ToString();
            rewardBalance_value_label.Text = user.rewardBalance.ToString();

            FormDatabaseHelper.fillAirportsCity(origin_comboBox);
            FormDatabaseHelper.fillAirportsCity(destination_comboBox);

            bookFlights_groupBox.Hide();
            upcomingFlights_groupBox.Hide();
            pastFlights_groupBox.Hide();

            oneway_groupBox.Hide();
            return_groupBox.Hide();
            ShowReturnComponents(false);
        }
        
        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Login s = new Login();
            s.Visible = true;
        }

        private void bookFlights_btn_Click(object sender, EventArgs e)
        {
            
            upcomingFlights_groupBox.Hide();
            pastFlights_groupBox.Hide();
            bookFlights_groupBox.Show();
        }

        

        private void pastFlights_btn_Click(object sender, EventArgs e)
        {
            bookFlights_groupBox.Hide();
            upcomingFlights_groupBox.Hide();
            pastFlights_groupBox.Show();
        }

        private void upComingFlights_btn_Click(object sender, EventArgs e)
        {
            bookFlights_groupBox.Hide();
            pastFlights_groupBox.Hide();
            upcomingFlights_groupBox.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bookFlights_groupBox_Enter(object sender, EventArgs e)
        {

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

       

        private void showFlights_btn_Click(object sender, EventArgs e)
        {
            if(origin_comboBox.SelectedItem != null && destination_comboBox.SelectedItem != null)
            {
                String originCity  = origin_comboBox.SelectedItem.ToString();
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
                        if (returnDate > deptDate)
                        {
                            oneway_groupBox.Show();
                            DataTable onewayOptionsTable = FormDatabaseHelper.getAvailableFlights(originAbv, destAbv, deptDate);
                            populateDataGridView(oneway_datagridview, onewayOptionsTable);
                            return_groupBox.Show();
                            DataTable returnOptionsTable = FormDatabaseHelper.getAvailableFlights(destAbv, originAbv, returnDate);
                            populateDataGridView(return_datagridview, returnOptionsTable);
                        }
                        else
                        {
                            Console.WriteLine("return should be after departure date");
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

        private void oneway_datagridview_SelectionChanged(object sender, EventArgs e)
        { 
            if (oneway_datagridview.SelectedRows.Count>0)
            {
                DataGridViewRow currentRow = oneway_datagridview.SelectedRows[0];

                if (currentRow != null)
                {
                    String originAbv = currentRow.Cells["originAbv"].Value.ToString();
                    String leg1destAbv = currentRow.Cells["leg1dest"].Value.ToString();
                    String leg1deptTime = currentRow.Cells["leg1DeptTime"].Value.ToString();
                    String leg1ArrivalTime = currentRow.Cells["leg1ArrivalTime"].Value.ToString();

                    String leg1id = currentRow.Cells["leg1id"].Value.ToString();
                    Console.WriteLine("-------------->" + leg1id);
                    one_leg1_selectedFlight_label.Text = originAbv + "-->" + leg1destAbv;
                    one_leg1_departure_label.Text = "Departure: " + leg1deptTime;
                    one_leg1_arrival_label.Text = "Arrival: " + leg1ArrivalTime;
                    
                    double cost_total_oneway = 0;
                    double cost_leg1 = FormDatabaseHelper.getCostFromBookingTable(Convert.ToInt32(leg1id));
                    cost_total_oneway += cost_leg1;
                    string cost_str_oneway = "Cost: "+cost_leg1.ToString();

                    String leg2origin = "";//6 
                    String leg2dest = ""; //7
                    String leg2deptTime = ""; //8
                    String leg2arrivalTime = "";//9
                    double cost_leg2 = 0;
                    int leg2id = (int)currentRow.Cells["leg2id"].Value; 
                    if(leg2id != 0)
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
                        cost_str_oneway = cost_str_oneway+ " + " + cost_leg2.ToString() + " + 8 = " ;
                        cost_total_oneway += (cost_leg2 +8);
                    }
                    else
                    {
                        oneway_leg2_groupBox.Hide();
                    }

                    cost_str_oneway = cost_str_oneway + cost_total_oneway.ToString();
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

                    String leg1id = currentRow.Cells["leg1id"].Value.ToString();
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
                        cost_str_return += " + " + cost_leg2.ToString() + " + 8 = ";
                        cost_total_return += (cost_leg2 + 8);
                    }
                    else
                    {
                        return_leg2_groupbox.Hide();
                    }
                    cost_str_return += cost_str_return.ToString();
                    oneway_cost_label.Text = cost_str_return;
                }
            }
        }

        private void return_confirm_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
