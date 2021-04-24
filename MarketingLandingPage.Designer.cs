
using System;

namespace Air3550
{
    partial class MarketingLandingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.marketingManger_welcome_label = new System.Windows.Forms.Label();
            this.marketing_datagrid = new System.Windows.Forms.DataGridView();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.air3550DBDataSet = new Air3550.Air3550DBDataSet();
            this.selectedFlight_label = new System.Windows.Forms.Label();
            this.planesModels_comboBox = new System.Windows.Forms.ComboBox();
            this.currPlane_label = new System.Windows.Forms.Label();
            this.curr_capacity_label = new System.Windows.Forms.Label();
            this.new_capacity_label = new System.Windows.Forms.Label();
            this.set_plane_label = new System.Windows.Forms.Label();
            this.updatePlane_btn = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.flightsTableAdapter = new Air3550.Air3550DBDataSetTableAdapters.FlightsTableAdapter();
            this.selFlightValue_textbox = new System.Windows.Forms.TextBox();
            this.currPlane_textbox = new System.Windows.Forms.TextBox();
            this.curr_maxCapacity_textbox = new System.Windows.Forms.TextBox();
            this.newCapacityValue_textBox = new System.Windows.Forms.TextBox();
            this.selFlightId_textbox = new System.Windows.Forms.TextBox();
            this.filledCapacity_label = new System.Windows.Forms.Label();
            this.filledSeatsValue_textBox = new System.Windows.Forms.TextBox();
            this.currSysTime_label = new System.Windows.Forms.Label();
            this.currSysTime_DTP = new System.Windows.Forms.DateTimePicker();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originAbvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destAbvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.marketing_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.air3550DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // marketingManger_welcome_label
            // 
            this.marketingManger_welcome_label.AutoSize = true;
            this.marketingManger_welcome_label.Location = new System.Drawing.Point(28, 52);
            this.marketingManger_welcome_label.Name = "marketingManger_welcome_label";
            this.marketingManger_welcome_label.Size = new System.Drawing.Size(144, 13);
            this.marketingManger_welcome_label.TabIndex = 0;
            this.marketingManger_welcome_label.Text = "Welcome, Marketing Manger";
            // 
            // marketing_datagrid
            // 
            this.marketing_datagrid.AllowUserToAddRows = false;
            this.marketing_datagrid.AllowUserToDeleteRows = false;
            this.marketing_datagrid.AutoGenerateColumns = false;
            this.marketing_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marketing_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.originAbvDataGridViewTextBoxColumn,
            this.destAbvDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.planeTypeDataGridViewTextBoxColumn,
            this.maxCapacityDataGridViewTextBoxColumn,
            this.currCapacityDataGridViewTextBoxColumn});
            this.marketing_datagrid.DataSource = this.flightsBindingSource;
            this.marketing_datagrid.Location = new System.Drawing.Point(20, 98);
            this.marketing_datagrid.Name = "marketing_datagrid";
            this.marketing_datagrid.ReadOnly = true;
            this.marketing_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marketing_datagrid.Size = new System.Drawing.Size(470, 323);
            this.marketing_datagrid.TabIndex = 1;
            this.marketing_datagrid.SelectionChanged += new System.EventHandler(this.marketing_datagrid_SelectionChanged);
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.air3550DBDataSet;
            // 
            // air3550DBDataSet
            // 
            this.air3550DBDataSet.DataSetName = "Air3550DBDataSet";
            this.air3550DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectedFlight_label
            // 
            this.selectedFlight_label.AutoSize = true;
            this.selectedFlight_label.Location = new System.Drawing.Point(535, 98);
            this.selectedFlight_label.Name = "selectedFlight_label";
            this.selectedFlight_label.Size = new System.Drawing.Size(80, 13);
            this.selectedFlight_label.TabIndex = 2;
            this.selectedFlight_label.Text = "Selected Flight:";
            // 
            // planesModels_comboBox
            // 
            this.planesModels_comboBox.FormattingEnabled = true;
            this.planesModels_comboBox.Location = new System.Drawing.Point(639, 248);
            this.planesModels_comboBox.Name = "planesModels_comboBox";
            this.planesModels_comboBox.Size = new System.Drawing.Size(121, 21);
            this.planesModels_comboBox.TabIndex = 3;
            this.planesModels_comboBox.SelectedIndexChanged += new System.EventHandler(this.planesModels_comboBox_SelectedIndexChanged);
            // 
            // currPlane_label
            // 
            this.currPlane_label.AutoSize = true;
            this.currPlane_label.Location = new System.Drawing.Point(541, 180);
            this.currPlane_label.Name = "currPlane_label";
            this.currPlane_label.Size = new System.Drawing.Size(74, 13);
            this.currPlane_label.TabIndex = 4;
            this.currPlane_label.Text = "Current Plane:";
            // 
            // curr_capacity_label
            // 
            this.curr_capacity_label.AutoSize = true;
            this.curr_capacity_label.Location = new System.Drawing.Point(541, 203);
            this.curr_capacity_label.Name = "curr_capacity_label";
            this.curr_capacity_label.Size = new System.Drawing.Size(74, 13);
            this.curr_capacity_label.TabIndex = 5;
            this.curr_capacity_label.Text = "Max Capacity:";
            // 
            // new_capacity_label
            // 
            this.new_capacity_label.AutoSize = true;
            this.new_capacity_label.Location = new System.Drawing.Point(516, 285);
            this.new_capacity_label.Name = "new_capacity_label";
            this.new_capacity_label.Size = new System.Drawing.Size(99, 13);
            this.new_capacity_label.TabIndex = 7;
            this.new_capacity_label.Text = "New Max Capacity:";
            // 
            // set_plane_label
            // 
            this.set_plane_label.AutoSize = true;
            this.set_plane_label.Location = new System.Drawing.Point(559, 251);
            this.set_plane_label.Name = "set_plane_label";
            this.set_plane_label.Size = new System.Drawing.Size(56, 13);
            this.set_plane_label.TabIndex = 6;
            this.set_plane_label.Text = "Set Plane:";
            // 
            // updatePlane_btn
            // 
            this.updatePlane_btn.Location = new System.Drawing.Point(583, 345);
            this.updatePlane_btn.Name = "updatePlane_btn";
            this.updatePlane_btn.Size = new System.Drawing.Size(126, 23);
            this.updatePlane_btn.TabIndex = 8;
            this.updatePlane_btn.Text = "Update Plane";
            this.updatePlane_btn.UseVisualStyleBackColor = true;
            this.updatePlane_btn.Click += new System.EventHandler(this.updatePlane_btn_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(683, 18);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 23);
            this.logout_button.TabIndex = 10;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // selFlightValue_textbox
            // 
            this.selFlightValue_textbox.Enabled = false;
            this.selFlightValue_textbox.Location = new System.Drawing.Point(639, 122);
            this.selFlightValue_textbox.Name = "selFlightValue_textbox";
            this.selFlightValue_textbox.ReadOnly = true;
            this.selFlightValue_textbox.Size = new System.Drawing.Size(121, 20);
            this.selFlightValue_textbox.TabIndex = 11;
            // 
            // currPlane_textbox
            // 
            this.currPlane_textbox.Enabled = false;
            this.currPlane_textbox.Location = new System.Drawing.Point(639, 177);
            this.currPlane_textbox.Name = "currPlane_textbox";
            this.currPlane_textbox.ReadOnly = true;
            this.currPlane_textbox.Size = new System.Drawing.Size(70, 20);
            this.currPlane_textbox.TabIndex = 12;
            // 
            // curr_maxCapacity_textbox
            // 
            this.curr_maxCapacity_textbox.Enabled = false;
            this.curr_maxCapacity_textbox.Location = new System.Drawing.Point(639, 200);
            this.curr_maxCapacity_textbox.Name = "curr_maxCapacity_textbox";
            this.curr_maxCapacity_textbox.ReadOnly = true;
            this.curr_maxCapacity_textbox.Size = new System.Drawing.Size(70, 20);
            this.curr_maxCapacity_textbox.TabIndex = 13;
            // 
            // newCapacityValue_textBox
            // 
            this.newCapacityValue_textBox.Enabled = false;
            this.newCapacityValue_textBox.Location = new System.Drawing.Point(639, 282);
            this.newCapacityValue_textBox.Name = "newCapacityValue_textBox";
            this.newCapacityValue_textBox.ReadOnly = true;
            this.newCapacityValue_textBox.Size = new System.Drawing.Size(70, 20);
            this.newCapacityValue_textBox.TabIndex = 14;
            // 
            // selFlightId_textbox
            // 
            this.selFlightId_textbox.Enabled = false;
            this.selFlightId_textbox.Location = new System.Drawing.Point(639, 95);
            this.selFlightId_textbox.Name = "selFlightId_textbox";
            this.selFlightId_textbox.ReadOnly = true;
            this.selFlightId_textbox.Size = new System.Drawing.Size(70, 20);
            this.selFlightId_textbox.TabIndex = 15;
            // 
            // filledCapacity_label
            // 
            this.filledCapacity_label.AutoSize = true;
            this.filledCapacity_label.Location = new System.Drawing.Point(551, 154);
            this.filledCapacity_label.Name = "filledCapacity_label";
            this.filledCapacity_label.Size = new System.Drawing.Size(64, 13);
            this.filledCapacity_label.TabIndex = 16;
            this.filledCapacity_label.Text = "Filled Seats:";
            // 
            // filledSeatsValue_textBox
            // 
            this.filledSeatsValue_textBox.Enabled = false;
            this.filledSeatsValue_textBox.Location = new System.Drawing.Point(639, 151);
            this.filledSeatsValue_textBox.Name = "filledSeatsValue_textBox";
            this.filledSeatsValue_textBox.ReadOnly = true;
            this.filledSeatsValue_textBox.Size = new System.Drawing.Size(70, 20);
            this.filledSeatsValue_textBox.TabIndex = 17;
            // 
            // currSysTime_label
            // 
            this.currSysTime_label.AutoSize = true;
            this.currSysTime_label.Location = new System.Drawing.Point(27, 18);
            this.currSysTime_label.Name = "currSysTime_label";
            this.currSysTime_label.Size = new System.Drawing.Size(70, 13);
            this.currSysTime_label.TabIndex = 18;
            this.currSysTime_label.Text = "System Time:";
            // 
            // currSysTime_DTP
            // 
            this.currSysTime_DTP.CustomFormat = "yyyy/MM/dd - hh:mm tt";
            this.currSysTime_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.currSysTime_DTP.Location = new System.Drawing.Point(121, 12);
            this.currSysTime_DTP.Name = "currSysTime_DTP";
            this.currSysTime_DTP.Size = new System.Drawing.Size(133, 20);
            this.currSysTime_DTP.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originAbvDataGridViewTextBoxColumn
            // 
            this.originAbvDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.originAbvDataGridViewTextBoxColumn.DataPropertyName = "originAbv";
            this.originAbvDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originAbvDataGridViewTextBoxColumn.Name = "originAbvDataGridViewTextBoxColumn";
            this.originAbvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destAbvDataGridViewTextBoxColumn
            // 
            this.destAbvDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destAbvDataGridViewTextBoxColumn.DataPropertyName = "destAbv";
            this.destAbvDataGridViewTextBoxColumn.HeaderText = "Dest";
            this.destAbvDataGridViewTextBoxColumn.Name = "destAbvDataGridViewTextBoxColumn";
            this.destAbvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "departureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "Departure";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planeTypeDataGridViewTextBoxColumn
            // 
            this.planeTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.planeTypeDataGridViewTextBoxColumn.DataPropertyName = "PlaneType";
            this.planeTypeDataGridViewTextBoxColumn.HeaderText = "Plane";
            this.planeTypeDataGridViewTextBoxColumn.Name = "planeTypeDataGridViewTextBoxColumn";
            this.planeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxCapacityDataGridViewTextBoxColumn
            // 
            this.maxCapacityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxCapacityDataGridViewTextBoxColumn.DataPropertyName = "maxCapacity";
            this.maxCapacityDataGridViewTextBoxColumn.HeaderText = "Max Cap";
            this.maxCapacityDataGridViewTextBoxColumn.Name = "maxCapacityDataGridViewTextBoxColumn";
            this.maxCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currCapacityDataGridViewTextBoxColumn
            // 
            this.currCapacityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currCapacityDataGridViewTextBoxColumn.DataPropertyName = "currCapacity";
            this.currCapacityDataGridViewTextBoxColumn.HeaderText = "Curr Cap";
            this.currCapacityDataGridViewTextBoxColumn.Name = "currCapacityDataGridViewTextBoxColumn";
            this.currCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MarketingLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currSysTime_DTP);
            this.Controls.Add(this.currSysTime_label);
            this.Controls.Add(this.filledSeatsValue_textBox);
            this.Controls.Add(this.filledCapacity_label);
            this.Controls.Add(this.selFlightId_textbox);
            this.Controls.Add(this.newCapacityValue_textBox);
            this.Controls.Add(this.curr_maxCapacity_textbox);
            this.Controls.Add(this.currPlane_textbox);
            this.Controls.Add(this.selFlightValue_textbox);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.updatePlane_btn);
            this.Controls.Add(this.new_capacity_label);
            this.Controls.Add(this.set_plane_label);
            this.Controls.Add(this.curr_capacity_label);
            this.Controls.Add(this.currPlane_label);
            this.Controls.Add(this.planesModels_comboBox);
            this.Controls.Add(this.selectedFlight_label);
            this.Controls.Add(this.marketing_datagrid);
            this.Controls.Add(this.marketingManger_welcome_label);
            this.Name = "MarketingLandingPage";
            this.Text = "MarketingLandingPage";
            this.Load += new System.EventHandler(this.MarketingLandingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marketing_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.air3550DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label marketingManger_welcome_label;
        private System.Windows.Forms.DataGridView marketing_datagrid;
        private System.Windows.Forms.Label selectedFlight_label;
        private System.Windows.Forms.ComboBox planesModels_comboBox;
        private System.Windows.Forms.Label currPlane_label;
        private System.Windows.Forms.Label curr_capacity_label;
        private System.Windows.Forms.Label new_capacity_label;
        private System.Windows.Forms.Label set_plane_label;
        private System.Windows.Forms.Button updatePlane_btn;
        private System.Windows.Forms.Button logout_button;
        private Air3550DBDataSet air3550DBDataSet;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private Air3550DBDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.TextBox selFlightValue_textbox;
        private System.Windows.Forms.TextBox currPlane_textbox;
        private System.Windows.Forms.TextBox curr_maxCapacity_textbox;
        private System.Windows.Forms.TextBox newCapacityValue_textBox;
        private System.Windows.Forms.TextBox selFlightId_textbox;
        private System.Windows.Forms.Label filledCapacity_label;
        private System.Windows.Forms.TextBox filledSeatsValue_textBox;
        private System.Windows.Forms.Label currSysTime_label;
        private System.Windows.Forms.DateTimePicker currSysTime_DTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originAbvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destAbvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currCapacityDataGridViewTextBoxColumn;
    }
}