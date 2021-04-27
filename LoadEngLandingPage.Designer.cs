
namespace Air3550
{
    partial class LoadEngLandingPage
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.addRoute_btn = new System.Windows.Forms.Button();
            this.editRoute_btn = new System.Windows.Forms.Button();
            this.deleteRoute_btn = new System.Windows.Forms.Button();
            this.addRoute_groupBox = new System.Windows.Forms.GroupBox();
            this.add_status_label = new System.Windows.Forms.Label();
            this.cost_postfix_label = new System.Windows.Forms.Label();
            this.add_cost_label = new System.Windows.Forms.Label();
            this.cost_label = new System.Windows.Forms.Label();
            this.mile_label = new System.Windows.Forms.Label();
            this.add_arrival_time_DTP = new System.Windows.Forms.DateTimePicker();
            this.add_depart_time_DTP = new System.Windows.Forms.DateTimePicker();
            this.add_distanceValue_label = new System.Windows.Forms.Label();
            this.add_distance_label = new System.Windows.Forms.Label();
            this.addRoute_submit_btn = new System.Windows.Forms.Button();
            this.add_arrival_time_label = new System.Windows.Forms.Label();
            this.add_dept_time_label = new System.Windows.Forms.Label();
            this.add_dest_comboBox = new System.Windows.Forms.ComboBox();
            this.add_dest_label = new System.Windows.Forms.Label();
            this.add_origin_comboBox = new System.Windows.Forms.ComboBox();
            this.add_origin_label = new System.Windows.Forms.Label();
            this.editRoute_groupBox = new System.Windows.Forms.GroupBox();
            this.edit_clearSort_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_costValue_label = new System.Windows.Forms.Label();
            this.edit_cost_label = new System.Windows.Forms.Label();
            this.edit_flights_dataview = new System.Windows.Forms.DataGridView();
            this.edit_submit_btn = new System.Windows.Forms.Button();
            this.edit_arrival_time_DTP = new System.Windows.Forms.DateTimePicker();
            this.edit_arrival_label = new System.Windows.Forms.Label();
            this.edit_depart_time_DTP = new System.Windows.Forms.DateTimePicker();
            this.edit_dept_label = new System.Windows.Forms.Label();
            this.edit_dest_combobox = new System.Windows.Forms.ComboBox();
            this.edit_dest_label = new System.Windows.Forms.Label();
            this.edit_origin_combobox = new System.Windows.Forms.ComboBox();
            this.edit_origin_label = new System.Windows.Forms.Label();
            this.flightsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.air3550DBDataSet = new Air3550.Air3550DBDataSet();
            this.deleteRoute_groupBox = new System.Windows.Forms.GroupBox();
            this.del_clearSort_button = new System.Windows.Forms.Button();
            this.del_flightidvalue_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.del_destination_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.del_origin_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.del_submit_button = new System.Windows.Forms.Button();
            this.del_flights_datagridview = new System.Windows.Forms.DataGridView();
            this.del_selected_route_label = new System.Windows.Forms.Label();
            this.flightsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logout_button = new System.Windows.Forms.Button();
            this.flightsTableAdapter1 = new Air3550.Air3550DBDataSetTableAdapters.FlightsTableAdapter();
            this.addRoute_groupBox.SuspendLayout();
            this.editRoute_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_flights_dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.air3550DBDataSet)).BeginInit();
            this.deleteRoute_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.del_flights_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(32, 23);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(127, 13);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome, Load Engineer";
            // 
            // addRoute_btn
            // 
            this.addRoute_btn.Location = new System.Drawing.Point(48, 59);
            this.addRoute_btn.Name = "addRoute_btn";
            this.addRoute_btn.Size = new System.Drawing.Size(75, 23);
            this.addRoute_btn.TabIndex = 1;
            this.addRoute_btn.Text = "Add Route";
            this.addRoute_btn.UseVisualStyleBackColor = true;
            this.addRoute_btn.Click += new System.EventHandler(this.addRoute_btn_Click);
            // 
            // editRoute_btn
            // 
            this.editRoute_btn.Location = new System.Drawing.Point(171, 59);
            this.editRoute_btn.Name = "editRoute_btn";
            this.editRoute_btn.Size = new System.Drawing.Size(75, 23);
            this.editRoute_btn.TabIndex = 2;
            this.editRoute_btn.Text = "Edit Route";
            this.editRoute_btn.UseVisualStyleBackColor = true;
            this.editRoute_btn.Click += new System.EventHandler(this.editRoute_btn_Click);
            // 
            // deleteRoute_btn
            // 
            this.deleteRoute_btn.Location = new System.Drawing.Point(290, 59);
            this.deleteRoute_btn.Name = "deleteRoute_btn";
            this.deleteRoute_btn.Size = new System.Drawing.Size(86, 23);
            this.deleteRoute_btn.TabIndex = 3;
            this.deleteRoute_btn.Text = "Delete Route";
            this.deleteRoute_btn.UseVisualStyleBackColor = true;
            this.deleteRoute_btn.Click += new System.EventHandler(this.deleteRoute_btn_Click);
            // 
            // addRoute_groupBox
            // 
            this.addRoute_groupBox.Controls.Add(this.add_status_label);
            this.addRoute_groupBox.Controls.Add(this.cost_postfix_label);
            this.addRoute_groupBox.Controls.Add(this.add_cost_label);
            this.addRoute_groupBox.Controls.Add(this.cost_label);
            this.addRoute_groupBox.Controls.Add(this.mile_label);
            this.addRoute_groupBox.Controls.Add(this.add_arrival_time_DTP);
            this.addRoute_groupBox.Controls.Add(this.add_depart_time_DTP);
            this.addRoute_groupBox.Controls.Add(this.add_distanceValue_label);
            this.addRoute_groupBox.Controls.Add(this.add_distance_label);
            this.addRoute_groupBox.Controls.Add(this.addRoute_submit_btn);
            this.addRoute_groupBox.Controls.Add(this.add_arrival_time_label);
            this.addRoute_groupBox.Controls.Add(this.add_dept_time_label);
            this.addRoute_groupBox.Controls.Add(this.add_dest_comboBox);
            this.addRoute_groupBox.Controls.Add(this.add_dest_label);
            this.addRoute_groupBox.Controls.Add(this.add_origin_comboBox);
            this.addRoute_groupBox.Controls.Add(this.add_origin_label);
            this.addRoute_groupBox.Location = new System.Drawing.Point(35, 98);
            this.addRoute_groupBox.Name = "addRoute_groupBox";
            this.addRoute_groupBox.Size = new System.Drawing.Size(625, 385);
            this.addRoute_groupBox.TabIndex = 4;
            this.addRoute_groupBox.TabStop = false;
            this.addRoute_groupBox.Text = "Add Route";
            // 
            // add_status_label
            // 
            this.add_status_label.AutoSize = true;
            this.add_status_label.Location = new System.Drawing.Point(206, 193);
            this.add_status_label.Name = "add_status_label";
            this.add_status_label.Size = new System.Drawing.Size(16, 13);
            this.add_status_label.TabIndex = 37;
            this.add_status_label.Text = "---";
            // 
            // cost_postfix_label
            // 
            this.cost_postfix_label.AutoSize = true;
            this.cost_postfix_label.Location = new System.Drawing.Point(144, 160);
            this.cost_postfix_label.Name = "cost_postfix_label";
            this.cost_postfix_label.Size = new System.Drawing.Size(13, 13);
            this.cost_postfix_label.TabIndex = 36;
            this.cost_postfix_label.Text = "$";
            // 
            // add_cost_label
            // 
            this.add_cost_label.AutoSize = true;
            this.add_cost_label.Location = new System.Drawing.Point(86, 160);
            this.add_cost_label.Name = "add_cost_label";
            this.add_cost_label.Size = new System.Drawing.Size(16, 13);
            this.add_cost_label.TabIndex = 35;
            this.add_cost_label.Text = "---";
            // 
            // cost_label
            // 
            this.cost_label.AutoSize = true;
            this.cost_label.Location = new System.Drawing.Point(24, 160);
            this.cost_label.Name = "cost_label";
            this.cost_label.Size = new System.Drawing.Size(28, 13);
            this.cost_label.TabIndex = 34;
            this.cost_label.Text = "Cost";
            // 
            // mile_label
            // 
            this.mile_label.AutoSize = true;
            this.mile_label.Location = new System.Drawing.Point(144, 79);
            this.mile_label.Name = "mile_label";
            this.mile_label.Size = new System.Drawing.Size(31, 13);
            this.mile_label.TabIndex = 33;
            this.mile_label.Text = "Miles";
            // 
            // add_arrival_time_DTP
            // 
            this.add_arrival_time_DTP.CustomFormat = "h:mm tt";
            this.add_arrival_time_DTP.Enabled = false;
            this.add_arrival_time_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.add_arrival_time_DTP.Location = new System.Drawing.Point(88, 127);
            this.add_arrival_time_DTP.Name = "add_arrival_time_DTP";
            this.add_arrival_time_DTP.ShowUpDown = true;
            this.add_arrival_time_DTP.Size = new System.Drawing.Size(96, 20);
            this.add_arrival_time_DTP.TabIndex = 10;
            // 
            // add_depart_time_DTP
            // 
            this.add_depart_time_DTP.CustomFormat = "h:mm tt";
            this.add_depart_time_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.add_depart_time_DTP.Location = new System.Drawing.Point(88, 100);
            this.add_depart_time_DTP.Name = "add_depart_time_DTP";
            this.add_depart_time_DTP.ShowUpDown = true;
            this.add_depart_time_DTP.Size = new System.Drawing.Size(96, 20);
            this.add_depart_time_DTP.TabIndex = 8;
            this.add_depart_time_DTP.Value = new System.DateTime(2021, 4, 21, 15, 3, 0, 0);
            this.add_depart_time_DTP.ValueChanged += new System.EventHandler(this.add_depart_time_DTP_ValueChanged);
            // 
            // add_distanceValue_label
            // 
            this.add_distanceValue_label.AutoSize = true;
            this.add_distanceValue_label.Location = new System.Drawing.Point(86, 79);
            this.add_distanceValue_label.Name = "add_distanceValue_label";
            this.add_distanceValue_label.Size = new System.Drawing.Size(13, 13);
            this.add_distanceValue_label.TabIndex = 32;
            this.add_distanceValue_label.Text = "0";
            // 
            // add_distance_label
            // 
            this.add_distance_label.AutoSize = true;
            this.add_distance_label.Location = new System.Drawing.Point(24, 79);
            this.add_distance_label.Name = "add_distance_label";
            this.add_distance_label.Size = new System.Drawing.Size(49, 13);
            this.add_distance_label.TabIndex = 31;
            this.add_distance_label.Text = "Distance";
            // 
            // addRoute_submit_btn
            // 
            this.addRoute_submit_btn.Location = new System.Drawing.Point(89, 188);
            this.addRoute_submit_btn.Name = "addRoute_submit_btn";
            this.addRoute_submit_btn.Size = new System.Drawing.Size(75, 23);
            this.addRoute_submit_btn.TabIndex = 12;
            this.addRoute_submit_btn.Text = "Submit";
            this.addRoute_submit_btn.UseVisualStyleBackColor = true;
            this.addRoute_submit_btn.Click += new System.EventHandler(this.addRoute_submit_btn_Click);
            // 
            // add_arrival_time_label
            // 
            this.add_arrival_time_label.AutoSize = true;
            this.add_arrival_time_label.Location = new System.Drawing.Point(24, 133);
            this.add_arrival_time_label.Name = "add_arrival_time_label";
            this.add_arrival_time_label.Size = new System.Drawing.Size(36, 13);
            this.add_arrival_time_label.TabIndex = 14;
            this.add_arrival_time_label.Text = "Arrival";
            // 
            // add_dept_time_label
            // 
            this.add_dept_time_label.AutoSize = true;
            this.add_dept_time_label.Location = new System.Drawing.Point(24, 106);
            this.add_dept_time_label.Name = "add_dept_time_label";
            this.add_dept_time_label.Size = new System.Drawing.Size(54, 13);
            this.add_dept_time_label.TabIndex = 10;
            this.add_dept_time_label.Text = "Departure";
            // 
            // add_dest_comboBox
            // 
            this.add_dest_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_dest_comboBox.FormattingEnabled = true;
            this.add_dest_comboBox.Location = new System.Drawing.Point(88, 49);
            this.add_dest_comboBox.Name = "add_dest_comboBox";
            this.add_dest_comboBox.Size = new System.Drawing.Size(121, 21);
            this.add_dest_comboBox.TabIndex = 6;
            this.add_dest_comboBox.TextChanged += new System.EventHandler(this.add_dest_comboBox_TextChanged);
            // 
            // add_dest_label
            // 
            this.add_dest_label.AutoSize = true;
            this.add_dest_label.Location = new System.Drawing.Point(24, 52);
            this.add_dest_label.Name = "add_dest_label";
            this.add_dest_label.Size = new System.Drawing.Size(60, 13);
            this.add_dest_label.TabIndex = 7;
            this.add_dest_label.Text = "Destination";
            // 
            // add_origin_comboBox
            // 
            this.add_origin_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_origin_comboBox.FormattingEnabled = true;
            this.add_origin_comboBox.Location = new System.Drawing.Point(88, 22);
            this.add_origin_comboBox.Name = "add_origin_comboBox";
            this.add_origin_comboBox.Size = new System.Drawing.Size(121, 21);
            this.add_origin_comboBox.TabIndex = 5;
            this.add_origin_comboBox.TextChanged += new System.EventHandler(this.add_origin_comboBox_TextChanged);
            // 
            // add_origin_label
            // 
            this.add_origin_label.AutoSize = true;
            this.add_origin_label.Location = new System.Drawing.Point(24, 25);
            this.add_origin_label.Name = "add_origin_label";
            this.add_origin_label.Size = new System.Drawing.Size(34, 13);
            this.add_origin_label.TabIndex = 0;
            this.add_origin_label.Text = "Origin";
            // 
            // editRoute_groupBox
            // 
            this.editRoute_groupBox.Controls.Add(this.edit_clearSort_button);
            this.editRoute_groupBox.Controls.Add(this.label3);
            this.editRoute_groupBox.Controls.Add(this.label2);
            this.editRoute_groupBox.Controls.Add(this.label1);
            this.editRoute_groupBox.Controls.Add(this.edit_costValue_label);
            this.editRoute_groupBox.Controls.Add(this.edit_cost_label);
            this.editRoute_groupBox.Controls.Add(this.edit_flights_dataview);
            this.editRoute_groupBox.Controls.Add(this.edit_submit_btn);
            this.editRoute_groupBox.Controls.Add(this.edit_arrival_time_DTP);
            this.editRoute_groupBox.Controls.Add(this.edit_arrival_label);
            this.editRoute_groupBox.Controls.Add(this.edit_depart_time_DTP);
            this.editRoute_groupBox.Controls.Add(this.edit_dept_label);
            this.editRoute_groupBox.Controls.Add(this.edit_dest_combobox);
            this.editRoute_groupBox.Controls.Add(this.edit_dest_label);
            this.editRoute_groupBox.Controls.Add(this.edit_origin_combobox);
            this.editRoute_groupBox.Controls.Add(this.edit_origin_label);
            this.editRoute_groupBox.Location = new System.Drawing.Point(35, 98);
            this.editRoute_groupBox.Name = "editRoute_groupBox";
            this.editRoute_groupBox.Size = new System.Drawing.Size(625, 385);
            this.editRoute_groupBox.TabIndex = 5;
            this.editRoute_groupBox.TabStop = false;
            this.editRoute_groupBox.Text = "Edit Route";
            // 
            // edit_clearSort_button
            // 
            this.edit_clearSort_button.Location = new System.Drawing.Point(108, 114);
            this.edit_clearSort_button.Name = "edit_clearSort_button";
            this.edit_clearSort_button.Size = new System.Drawing.Size(121, 21);
            this.edit_clearSort_button.TabIndex = 41;
            this.edit_clearSort_button.Text = "Clear Sort Criteria";
            this.edit_clearSort_button.UseVisualStyleBackColor = true;
            this.edit_clearSort_button.Click += new System.EventHandler(this.edit_clearSort_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Edit flight route";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Sort flight routes by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "$";
            // 
            // edit_costValue_label
            // 
            this.edit_costValue_label.AutoSize = true;
            this.edit_costValue_label.Location = new System.Drawing.Point(511, 57);
            this.edit_costValue_label.Name = "edit_costValue_label";
            this.edit_costValue_label.Size = new System.Drawing.Size(13, 13);
            this.edit_costValue_label.TabIndex = 31;
            this.edit_costValue_label.Text = "0";
            // 
            // edit_cost_label
            // 
            this.edit_cost_label.AutoSize = true;
            this.edit_cost_label.Location = new System.Drawing.Point(450, 57);
            this.edit_cost_label.Name = "edit_cost_label";
            this.edit_cost_label.Size = new System.Drawing.Size(53, 13);
            this.edit_cost_label.TabIndex = 30;
            this.edit_cost_label.Text = "New Cost";
            // 
            // edit_flights_dataview
            // 
            this.edit_flights_dataview.AllowUserToAddRows = false;
            this.edit_flights_dataview.AllowUserToDeleteRows = false;
            this.edit_flights_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edit_flights_dataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.edit_flights_dataview.Location = new System.Drawing.Point(47, 149);
            this.edit_flights_dataview.Name = "edit_flights_dataview";
            this.edit_flights_dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.edit_flights_dataview.Size = new System.Drawing.Size(523, 221);
            this.edit_flights_dataview.TabIndex = 27;
            this.edit_flights_dataview.SelectionChanged += new System.EventHandler(this.edit_flights_dataview_SelectionChanged);
            // 
            // edit_submit_btn
            // 
            this.edit_submit_btn.Location = new System.Drawing.Point(453, 81);
            this.edit_submit_btn.Name = "edit_submit_btn";
            this.edit_submit_btn.Size = new System.Drawing.Size(117, 23);
            this.edit_submit_btn.TabIndex = 17;
            this.edit_submit_btn.Text = "Submit Changes";
            this.edit_submit_btn.UseVisualStyleBackColor = true;
            this.edit_submit_btn.Click += new System.EventHandler(this.edit_submit_btn_Click);
            // 
            // edit_arrival_time_DTP
            // 
            this.edit_arrival_time_DTP.CustomFormat = "h:mm tt";
            this.edit_arrival_time_DTP.Enabled = false;
            this.edit_arrival_time_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.edit_arrival_time_DTP.Location = new System.Drawing.Point(332, 82);
            this.edit_arrival_time_DTP.Name = "edit_arrival_time_DTP";
            this.edit_arrival_time_DTP.ShowUpDown = true;
            this.edit_arrival_time_DTP.Size = new System.Drawing.Size(86, 20);
            this.edit_arrival_time_DTP.TabIndex = 16;
            // 
            // edit_arrival_label
            // 
            this.edit_arrival_label.AutoSize = true;
            this.edit_arrival_label.Location = new System.Drawing.Point(268, 84);
            this.edit_arrival_label.Name = "edit_arrival_label";
            this.edit_arrival_label.Size = new System.Drawing.Size(36, 13);
            this.edit_arrival_label.TabIndex = 25;
            this.edit_arrival_label.Text = "Arrival";
            // 
            // edit_depart_time_DTP
            // 
            this.edit_depart_time_DTP.CustomFormat = "h:mm tt";
            this.edit_depart_time_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.edit_depart_time_DTP.Location = new System.Drawing.Point(332, 51);
            this.edit_depart_time_DTP.Name = "edit_depart_time_DTP";
            this.edit_depart_time_DTP.ShowUpDown = true;
            this.edit_depart_time_DTP.Size = new System.Drawing.Size(86, 20);
            this.edit_depart_time_DTP.TabIndex = 15;
            this.edit_depart_time_DTP.ValueChanged += new System.EventHandler(this.edit_depart_time_DTP_ValueChanged);
            // 
            // edit_dept_label
            // 
            this.edit_dept_label.AutoSize = true;
            this.edit_dept_label.Location = new System.Drawing.Point(268, 57);
            this.edit_dept_label.Name = "edit_dept_label";
            this.edit_dept_label.Size = new System.Drawing.Size(54, 13);
            this.edit_dept_label.TabIndex = 21;
            this.edit_dept_label.Text = "Departure";
            // 
            // edit_dest_combobox
            // 
            this.edit_dest_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edit_dest_combobox.FormattingEnabled = true;
            this.edit_dest_combobox.Location = new System.Drawing.Point(108, 81);
            this.edit_dest_combobox.Name = "edit_dest_combobox";
            this.edit_dest_combobox.Size = new System.Drawing.Size(121, 21);
            this.edit_dest_combobox.TabIndex = 14;
            this.edit_dest_combobox.TextChanged += new System.EventHandler(this.edit_dest_combobox_TextChanged);
            // 
            // edit_dest_label
            // 
            this.edit_dest_label.AutoSize = true;
            this.edit_dest_label.Location = new System.Drawing.Point(44, 84);
            this.edit_dest_label.Name = "edit_dest_label";
            this.edit_dest_label.Size = new System.Drawing.Size(60, 13);
            this.edit_dest_label.TabIndex = 18;
            this.edit_dest_label.Text = "Destination";
            // 
            // edit_origin_combobox
            // 
            this.edit_origin_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edit_origin_combobox.FormattingEnabled = true;
            this.edit_origin_combobox.Location = new System.Drawing.Point(108, 49);
            this.edit_origin_combobox.Name = "edit_origin_combobox";
            this.edit_origin_combobox.Size = new System.Drawing.Size(121, 21);
            this.edit_origin_combobox.TabIndex = 13;
            this.edit_origin_combobox.TextChanged += new System.EventHandler(this.edit_origin_combobox_TextChanged);
            // 
            // edit_origin_label
            // 
            this.edit_origin_label.AutoSize = true;
            this.edit_origin_label.Location = new System.Drawing.Point(44, 57);
            this.edit_origin_label.Name = "edit_origin_label";
            this.edit_origin_label.Size = new System.Drawing.Size(34, 13);
            this.edit_origin_label.TabIndex = 16;
            this.edit_origin_label.Text = "Origin";
            // 
            // flightsBindingSource2
            // 
            this.flightsBindingSource2.DataMember = "Flights";
            this.flightsBindingSource2.DataSource = this.air3550DBDataSet;
            // 
            // air3550DBDataSet
            // 
            this.air3550DBDataSet.DataSetName = "Air3550DBDataSet";
            this.air3550DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteRoute_groupBox
            // 
            this.deleteRoute_groupBox.Controls.Add(this.del_clearSort_button);
            this.deleteRoute_groupBox.Controls.Add(this.del_flightidvalue_label);
            this.deleteRoute_groupBox.Controls.Add(this.label4);
            this.deleteRoute_groupBox.Controls.Add(this.del_destination_combobox);
            this.deleteRoute_groupBox.Controls.Add(this.label5);
            this.deleteRoute_groupBox.Controls.Add(this.del_origin_combobox);
            this.deleteRoute_groupBox.Controls.Add(this.label6);
            this.deleteRoute_groupBox.Controls.Add(this.del_submit_button);
            this.deleteRoute_groupBox.Controls.Add(this.del_flights_datagridview);
            this.deleteRoute_groupBox.Controls.Add(this.del_selected_route_label);
            this.deleteRoute_groupBox.Location = new System.Drawing.Point(35, 98);
            this.deleteRoute_groupBox.Name = "deleteRoute_groupBox";
            this.deleteRoute_groupBox.Size = new System.Drawing.Size(625, 385);
            this.deleteRoute_groupBox.TabIndex = 6;
            this.deleteRoute_groupBox.TabStop = false;
            this.deleteRoute_groupBox.Text = "Delete Route";
            // 
            // del_clearSort_button
            // 
            this.del_clearSort_button.Location = new System.Drawing.Point(108, 114);
            this.del_clearSort_button.Name = "del_clearSort_button";
            this.del_clearSort_button.Size = new System.Drawing.Size(121, 21);
            this.del_clearSort_button.TabIndex = 40;
            this.del_clearSort_button.Text = "Clear Sort Criteria";
            this.del_clearSort_button.UseVisualStyleBackColor = true;
            this.del_clearSort_button.Click += new System.EventHandler(this.del_clearSort_button_Click);
            // 
            // del_flightidvalue_label
            // 
            this.del_flightidvalue_label.AutoSize = true;
            this.del_flightidvalue_label.Location = new System.Drawing.Point(378, 26);
            this.del_flightidvalue_label.Name = "del_flightidvalue_label";
            this.del_flightidvalue_label.Size = new System.Drawing.Size(16, 13);
            this.del_flightidvalue_label.TabIndex = 39;
            this.del_flightidvalue_label.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sort flight routes by";
            // 
            // del_destination_combobox
            // 
            this.del_destination_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.del_destination_combobox.FormattingEnabled = true;
            this.del_destination_combobox.Location = new System.Drawing.Point(108, 82);
            this.del_destination_combobox.Name = "del_destination_combobox";
            this.del_destination_combobox.Size = new System.Drawing.Size(121, 21);
            this.del_destination_combobox.TabIndex = 35;
            this.del_destination_combobox.TextChanged += new System.EventHandler(this.del_destination_combobox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Destination";
            // 
            // del_origin_combobox
            // 
            this.del_origin_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.del_origin_combobox.FormattingEnabled = true;
            this.del_origin_combobox.Location = new System.Drawing.Point(108, 50);
            this.del_origin_combobox.Name = "del_origin_combobox";
            this.del_origin_combobox.Size = new System.Drawing.Size(121, 21);
            this.del_origin_combobox.TabIndex = 34;
            this.del_origin_combobox.TextChanged += new System.EventHandler(this.del_origin_combobox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Origin";
            // 
            // del_submit_button
            // 
            this.del_submit_button.Location = new System.Drawing.Point(381, 50);
            this.del_submit_button.Name = "del_submit_button";
            this.del_submit_button.Size = new System.Drawing.Size(86, 21);
            this.del_submit_button.TabIndex = 18;
            this.del_submit_button.Text = "Delete Route";
            this.del_submit_button.UseVisualStyleBackColor = true;
            this.del_submit_button.Click += new System.EventHandler(this.del_submit_button_Click);
            // 
            // del_flights_datagridview
            // 
            this.del_flights_datagridview.AllowUserToAddRows = false;
            this.del_flights_datagridview.AllowUserToDeleteRows = false;
            this.del_flights_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.del_flights_datagridview.Location = new System.Drawing.Point(47, 149);
            this.del_flights_datagridview.Name = "del_flights_datagridview";
            this.del_flights_datagridview.ReadOnly = true;
            this.del_flights_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.del_flights_datagridview.Size = new System.Drawing.Size(523, 221);
            this.del_flights_datagridview.TabIndex = 7;
            this.del_flights_datagridview.SelectionChanged += new System.EventHandler(this.del_flights_datagridview_SelectionChanged);
            // 
            // del_selected_route_label
            // 
            this.del_selected_route_label.AutoSize = true;
            this.del_selected_route_label.Location = new System.Drawing.Point(268, 26);
            this.del_selected_route_label.Name = "del_selected_route_label";
            this.del_selected_route_label.Size = new System.Drawing.Size(104, 13);
            this.del_selected_route_label.TabIndex = 7;
            this.del_selected_route_label.Text = "Selected Route ID : ";
            // 
            // flightsBindingSource1
            // 
            this.flightsBindingSource1.DataMember = "Flights";
            this.flightsBindingSource1.DataSource = this.air3550DBDataSet;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.air3550DBDataSet;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(627, 12);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 23);
            this.logout_button.TabIndex = 4;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // flightsTableAdapter1
            // 
            this.flightsTableAdapter1.ClearBeforeFill = true;
            // 
            // LoadEngLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 609);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.deleteRoute_btn);
            this.Controls.Add(this.editRoute_btn);
            this.Controls.Add(this.addRoute_btn);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.editRoute_groupBox);
            this.Controls.Add(this.addRoute_groupBox);
            this.Controls.Add(this.deleteRoute_groupBox);
            this.Name = "LoadEngLandingPage";
            this.Text = "LoadEngLandingPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadEngLandingPage_FormClosing);
            this.Load += new System.EventHandler(this.LoadEngLandingPage_Load);
            this.addRoute_groupBox.ResumeLayout(false);
            this.addRoute_groupBox.PerformLayout();
            this.editRoute_groupBox.ResumeLayout(false);
            this.editRoute_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_flights_dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.air3550DBDataSet)).EndInit();
            this.deleteRoute_groupBox.ResumeLayout(false);
            this.deleteRoute_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.del_flights_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.Label welcome_label;
        
        private System.Windows.Forms.Button addRoute_btn;
        private System.Windows.Forms.Button editRoute_btn;
        private System.Windows.Forms.Button deleteRoute_btn;
        private System.Windows.Forms.GroupBox addRoute_groupBox;
        private System.Windows.Forms.Label add_origin_label;
        private System.Windows.Forms.GroupBox editRoute_groupBox;
        private System.Windows.Forms.Label add_arrival_time_label;
        private System.Windows.Forms.Label add_dept_time_label;
        private System.Windows.Forms.ComboBox add_dest_comboBox;
        private System.Windows.Forms.Label add_dest_label;
        private System.Windows.Forms.ComboBox add_origin_comboBox;
        private System.Windows.Forms.Button addRoute_submit_btn;
        private System.Windows.Forms.Button edit_submit_btn;
        private System.Windows.Forms.DateTimePicker edit_arrival_time_DTP;
        private System.Windows.Forms.Label edit_arrival_label;
        private System.Windows.Forms.DateTimePicker edit_depart_time_DTP;
        private System.Windows.Forms.Label edit_dept_label;
        private System.Windows.Forms.ComboBox edit_dest_combobox;
        private System.Windows.Forms.Label edit_dest_label;
        private System.Windows.Forms.ComboBox edit_origin_combobox;
        private System.Windows.Forms.Label edit_origin_label;
        private System.Windows.Forms.GroupBox deleteRoute_groupBox;
        private System.Windows.Forms.Button del_submit_button;
        private System.Windows.Forms.Label del_selected_route_label;
        private System.Windows.Forms.DataGridView edit_flights_dataview;
        private System.Windows.Forms.Label add_distanceValue_label;
        private System.Windows.Forms.Label add_distance_label;
        private Air3550DBDataSet air3550DBDataSet;
        private System.Windows.Forms.DataGridView del_flights_datagridview;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private System.Windows.Forms.BindingSource flightsBindingSource1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.DateTimePicker add_arrival_time_DTP;
        private System.Windows.Forms.DateTimePicker add_depart_time_DTP;
        private System.Windows.Forms.Label mile_label;
        private System.Windows.Forms.Label cost_postfix_label;
        private System.Windows.Forms.Label add_cost_label;
        private System.Windows.Forms.Label cost_label;
        private Air3550.Air3550DBDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.Label add_status_label;
        private System.Windows.Forms.BindingSource flightsBindingSource2;
        private Air3550DBDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter1;
        private System.Windows.Forms.Label edit_cost_label;
        private System.Windows.Forms.Label edit_costValue_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox del_destination_combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox del_origin_combobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label del_flightidvalue_label;
        private System.Windows.Forms.Button del_clearSort_button;
        private System.Windows.Forms.Button edit_clearSort_button;
    }
}