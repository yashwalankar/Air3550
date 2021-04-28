using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using DataGrid = System.Windows.Controls.DataGrid;

namespace Air3550
{
    public partial class MarketingLandingPage : Form
    {
        public MarketingLandingPage()
        {
            InitializeComponent();

            DataTable newEditTable = FormDatabaseHelper.updateAccountGridViewTable();
            BindingSource SBind = new BindingSource();
            SBind.DataSource = newEditTable;
            flightsTableColumnSetup();
            marketing_datagrid.DataSource = SBind;
            marketing_datagrid.Refresh();

            FormDatabaseHelper.FillPlaneModelsBox(planesModels_comboBox);
            FormDatabaseHelper.fillAirportsAbv(origin_combobox);
            FormDatabaseHelper.fillAirportsAbv(dest_combobox);
        }

        private void MarketingLandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void marketing_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            
                DataGridViewRow currentRow = marketing_datagrid.CurrentRow;
                String flightId = "";
                String flight_string = "";
                String plane_type = "";
                String maxCapacity = "";
                String filledSeats = "";
                if (currentRow != null)
                {
                    flightId = currentRow.Cells[0].Value.ToString();
                    flight_string = currentRow.Cells[1].Value.ToString() +
                                    "--> " + currentRow.Cells[2].Value.ToString();

                    plane_type = currentRow.Cells[5].Value.ToString();
                    maxCapacity = currentRow.Cells[6].Value.ToString();
                    filledSeats = currentRow.Cells[7].Value.ToString();
                }

                selFlightValue_textbox.Text = flight_string;
                currPlane_textbox.Text = plane_type;
                curr_maxCapacity_textbox.Text = maxCapacity;
                selFlightId_textbox.Text = flightId;
                filledSeatsValue_textBox.Text = filledSeats;
            
        }


        private void planesModels_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newCapacityValue_textBox.Text = FormDatabaseHelper.getPlaneCapacity(planesModels_comboBox.SelectedItem.ToString()).ToString();
            //FormDatabaseHelper.updateCapacityBox(planesModels_comboBox.SelectedItem.ToString() , newCapacityValue_label);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
            Login s = new Login();
            s.Visible = true;
        }

        private void MarketingLandingPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'air3550DBDataSet.Flights' table. You can move, or remove it, as needed.
            //this.flightsTableAdapter.Fill(this.air3550DBDataSet.Flights);

        }

        private void updatePlane_btn_Click(object sender, EventArgs e)
        {
            String planeModel = "";
            String capacityStr =  newCapacityValue_textBox.Text;

            if (!String.IsNullOrEmpty(capacityStr))
            {
                planeModel = planesModels_comboBox.SelectedItem.ToString();
                int flightId = Int32.Parse(selFlightId_textbox.Text);
                int newCapacity = Int32.Parse(capacityStr);
                int filledSeats = Int32.Parse(filledSeatsValue_textBox.Text);

                //updates in database/flights table
                if (newCapacity > filledSeats)
                {
                    FormDatabaseHelper.updatePlaneInFlightsTable(flightId, planeModel, newCapacity);

                    DataTable newEditTable = FormDatabaseHelper.updateAccountGridViewTable();
                    BindingSource SBind = new BindingSource();
                    SBind.DataSource = newEditTable;
                    flightsTableColumnSetup();
                    marketing_datagrid.DataSource = SBind;
                    marketing_datagrid.Refresh();

                    //update in the data grid view
                    //marketing_datagrid.SelectedRows[0].Cells[6].Value = planeModel;
                    //marketing_datagrid.SelectedRows[0].Cells[5].Value = newCapacity;
                }
                else
                {
                    Console.WriteLine("Select a plane with higher capacity than current");
                }
            }
            
        }

        // =================================================================================================
        // Location Based Search Functionality =============================================================
        // =================================================================================================

        private void origin_dest_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = origin_dest_checkbox.Checked;

            if (isChecked == true)
            {
                origin_combobox.Enabled = true;
                dest_combobox.Enabled = true;
                clearSort_button.Enabled = true;
            }
            else
            {
                origin_combobox.Enabled = false;
                dest_combobox.Enabled = false;
                clearSort_button.Enabled = false;
            }

            updateTable();
        }

        private void clearSort_button_Click(object sender, EventArgs e)
        {
            origin_combobox.SelectedItem = null;
            dest_combobox.SelectedItem = null;

            updateTable();
        }

        private void origin_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void dest_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        // =================================================================================================
        // Date Based Search Functionality =================================================================
        // =================================================================================================

        private void date_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = date_checkbox.Checked;

            if (isChecked == true)
            {
                afterDate_DTP.Enabled = true;
                beforeDate_DTP.Enabled = true;
                date_after_checkbox.Enabled = true;
                date_before_checkbox.Enabled = true;
            }
            else
            {
                afterDate_DTP.Enabled = false;
                beforeDate_DTP.Enabled = false;
                date_after_checkbox.Enabled = false;
                date_before_checkbox.Enabled = false;
            }

            updateTable();
        }

        private void date_after_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void date_before_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void afterDate_DTP_ValueChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        private void beforeDate_DTP_ValueChanged(object sender, EventArgs e)
        {
            updateTable();
        }

        // =================================================================================================
        // General and Helper Functionality ================================================================
        // =================================================================================================

        private void updateTable()
        {
            DataTable newEditTable = new DataTable();
            BindingSource SBind = new BindingSource();

            bool location = false, date = false;
            location = origin_dest_checkbox.Checked;
            date = date_checkbox.Checked;

            bool multiPassTableSort = false;

            if (location && date) multiPassTableSort = true;

            if (location && !multiPassTableSort)
            {


                string origin = origin_combobox.Text;
                string destination = dest_combobox.Text;

                if (origin_combobox.SelectedItem != null && dest_combobox.SelectedItem != null)
                {
                    newEditTable = FormDatabaseHelper.updateAccountGridViewTable(origin, destination);
                }
                else if (origin_combobox.SelectedItem != null && dest_combobox.SelectedItem == null)
                {
                    newEditTable = FormDatabaseHelper.updateAccountGridViewTable(origin, null);
                }
                else if (origin_combobox.SelectedItem == null && dest_combobox.SelectedItem != null)
                {
                    newEditTable = FormDatabaseHelper.updateAccountGridViewTable(null, destination);
                }
                else
                {
                    newEditTable = FormDatabaseHelper.updateAccountGridViewTable(null, null);
                }
            }
            else if (date && !multiPassTableSort)
            {
                DateTime before = beforeDate_DTP.Value.Date;
                DateTime after = afterDate_DTP.Value.Date;

                if (date_after_checkbox.Checked && date_before_checkbox.Checked)
                {
                    newEditTable = FormDatabaseHelper.updateGridViewTableWithDate(true, true, before, after);
                }
                else if (!date_after_checkbox.Checked && date_before_checkbox.Checked)
                {
                    newEditTable = FormDatabaseHelper.updateGridViewTableWithDate(true, false, before);
                }
                else if (date_after_checkbox.Checked && !date_before_checkbox.Checked)
                {
                    newEditTable = FormDatabaseHelper.updateGridViewTableWithDate(false, true, default, after);
                }
                else
                {
                    newEditTable = FormDatabaseHelper.updateGridViewTableWithDate(false, false);
                }
            }
            else if (multiPassTableSort)
            {
                bool tableInitialized = false;
                if (location)
                {
                    string origin = origin_combobox.Text;
                    string destination = dest_combobox.Text;

                    if (origin_combobox.SelectedItem != null && dest_combobox.SelectedItem != null)
                    {
                        newEditTable = FormDatabaseHelper.updateAccountGridViewTable(origin, destination);
                    }
                    else if (origin_combobox.SelectedItem != null && dest_combobox.SelectedItem == null)
                    {
                        newEditTable = FormDatabaseHelper.updateAccountGridViewTable(origin, null);
                    }
                    else if (origin_combobox.SelectedItem == null && dest_combobox.SelectedItem != null)
                    {
                        newEditTable = FormDatabaseHelper.updateAccountGridViewTable(null, destination);
                    }
                    else
                    {
                        newEditTable = FormDatabaseHelper.updateAccountGridViewTable(null, null);
                    }

                    tableInitialized = true;
                }

                if (date && !tableInitialized)
                {
                    DateTime before = beforeDate_DTP.Value.Date;
                    DateTime after = afterDate_DTP.Value.Date;

                    if (date_after_checkbox.Checked && date_before_checkbox.Checked)
                    {
                        newEditTable = FormDatabaseHelper.updateGridViewTableWithDate(true, true, before, after);
                    }
                    else if (!date_after_checkbox.Checked && date_before_checkbox.Checked)
                    {
                        newEditTable = FormDatabaseHelper.updateGridViewTableWithDate(true, false, before);
                    }
                    else if (date_after_checkbox.Checked && !date_before_checkbox.Checked)
                    {
                        newEditTable = FormDatabaseHelper.updateGridViewTableWithDate(false, true, default, after);
                    }
                    else
                    {
                        newEditTable = FormDatabaseHelper.updateGridViewTableWithDate(false, false);
                    }

                    tableInitialized = true;
                }
                else if (date && tableInitialized)
                {
                    DateTime before = beforeDate_DTP.Value.Date;
                    DateTime after = afterDate_DTP.Value.Date;

                    string beforeStr = before.ToString();
                    string afterStr = after.ToString();

                    string search = null;
                    if (date_after_checkbox.Checked && date_before_checkbox.Checked)
                    {
                        search = $"departureTime >= '{afterStr}' AND departureTime <= '{beforeStr}'";
                    }
                    else if (!date_after_checkbox.Checked && date_before_checkbox.Checked)
                    {
                        search = $"departureTime <= '{beforeStr}'";
                    }
                    else if (date_after_checkbox.Checked && !date_before_checkbox.Checked)
                    {
                        search = $"departureTime >= '{afterStr}'";
                    }

                    if (newEditTable.Select(search).Length > 0)
                    {
                        newEditTable = newEditTable.Select(search).CopyToDataTable();
                    }
                    else
                    {
                        newEditTable = new DataTable();
                    }
                }
            }
            else
            {
                newEditTable = FormDatabaseHelper.updateAccountGridViewTable(null, null);
            }

            SBind.DataSource = newEditTable;
            marketing_datagrid.Columns.Clear();
            flightsTableColumnSetup();
            marketing_datagrid.DataSource = SBind;
            marketing_datagrid.Refresh();
        }

        private void flightsTableColumnSetup()
        {
            marketing_datagrid.DataSource = null;

            marketing_datagrid.AutoGenerateColumns = false;
            marketing_datagrid.ColumnCount = 8;

            marketing_datagrid.Columns[0].Name = "id";
            marketing_datagrid.Columns[0].HeaderText = "FlightID";
            marketing_datagrid.Columns[0].DataPropertyName = "id";
            marketing_datagrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            marketing_datagrid.Columns[1].Name = "originAbv";
            marketing_datagrid.Columns[1].HeaderText = "Origin";
            marketing_datagrid.Columns[1].DataPropertyName = "originAbv";
            marketing_datagrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            marketing_datagrid.Columns[2].Name = "destAbv";
            marketing_datagrid.Columns[2].HeaderText = "Destination";
            marketing_datagrid.Columns[2].DataPropertyName = "destAbv";
            marketing_datagrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            marketing_datagrid.Columns[3].Name = "departureTime";
            marketing_datagrid.Columns[3].HeaderText = "Departure (24H)";
            marketing_datagrid.Columns[3].DataPropertyName = "departureTime";
            marketing_datagrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            marketing_datagrid.Columns[4].Name = "arrivalTime";
            marketing_datagrid.Columns[4].HeaderText = "Arrival (24H)";
            marketing_datagrid.Columns[4].DataPropertyName = "arrivalTime";
            marketing_datagrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            marketing_datagrid.Columns[5].Name = "planeType";
            marketing_datagrid.Columns[5].HeaderText = "Current Plane";
            marketing_datagrid.Columns[5].DataPropertyName = "planeType";
            marketing_datagrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            marketing_datagrid.Columns[6].Name = "maxCapacity";
            marketing_datagrid.Columns[6].HeaderText = "Max Capacity";
            marketing_datagrid.Columns[6].DataPropertyName = "maxCapacity";
            marketing_datagrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            marketing_datagrid.Columns[7].Name = "currCapacity";
            marketing_datagrid.Columns[7].HeaderText = "Current Capacity";
            marketing_datagrid.Columns[7].DataPropertyName = "currCapacity";
            marketing_datagrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
