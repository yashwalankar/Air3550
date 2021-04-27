
namespace Air3550
{
    partial class AccountantLandingPage
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
            this.logout_button = new System.Windows.Forms.Button();
            this.flights_dataview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.clearSort_button = new System.Windows.Forms.Button();
            this.beforeDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.edit_arrival_label = new System.Windows.Forms.Label();
            this.afterDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.edit_dept_label = new System.Windows.Forms.Label();
            this.dest_combobox = new System.Windows.Forms.ComboBox();
            this.edit_dest_label = new System.Windows.Forms.Label();
            this.origin_combobox = new System.Windows.Forms.ComboBox();
            this.edit_origin_label = new System.Windows.Forms.Label();
            this.origin_dest_checkbox = new System.Windows.Forms.CheckBox();
            this.date_checkbox = new System.Windows.Forms.CheckBox();
            this.generate_submit_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_after_checkbox = new System.Windows.Forms.CheckBox();
            this.date_before_checkbox = new System.Windows.Forms.CheckBox();
            this.tools_groupbox = new System.Windows.Forms.GroupBox();
            this.single_report_button = new System.Windows.Forms.Button();
            this.singleflight_report_groupbox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.single_transactions_datagridview = new System.Windows.Forms.DataGridView();
            this.single_arrivalDate_label = new System.Windows.Forms.Label();
            this.single_depDate_label = new System.Windows.Forms.Label();
            this.single_destCode_label = new System.Windows.Forms.Label();
            this.single_originCode_label = new System.Windows.Forms.Label();
            this.single_flightID_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.single_pointRev_label = new System.Windows.Forms.Label();
            this.single_cardRev_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.single_percFill_label = new System.Windows.Forms.Label();
            this.single_curr_cap_label = new System.Windows.Forms.Label();
            this.single_max_cap_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close_single_report_button = new System.Windows.Forms.Button();
            this.fullReport_groupbox = new System.Windows.Forms.GroupBox();
            this.full_report_datagridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.full_report_close_button = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.full_flightCount_label = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.full_cardRev_label = new System.Windows.Forms.Label();
            this.full_pointRev_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flights_dataview)).BeginInit();
            this.tools_groupbox.SuspendLayout();
            this.singleflight_report_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.single_transactions_datagridview)).BeginInit();
            this.fullReport_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.full_report_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(713, 12);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 23);
            this.logout_button.TabIndex = 12;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            // 
            // flights_dataview
            // 
            this.flights_dataview.AllowUserToAddRows = false;
            this.flights_dataview.AllowUserToDeleteRows = false;
            this.flights_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flights_dataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.flights_dataview.Location = new System.Drawing.Point(14, 189);
            this.flights_dataview.Name = "flights_dataview";
            this.flights_dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flights_dataview.Size = new System.Drawing.Size(640, 339);
            this.flights_dataview.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logout_button_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(32, 23);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(113, 13);
            this.welcome_label.TabIndex = 30;
            this.welcome_label.Text = "Welcome, Accountant";
            // 
            // clearSort_button
            // 
            this.clearSort_button.Enabled = false;
            this.clearSort_button.Location = new System.Drawing.Point(75, 107);
            this.clearSort_button.Name = "clearSort_button";
            this.clearSort_button.Size = new System.Drawing.Size(121, 21);
            this.clearSort_button.TabIndex = 52;
            this.clearSort_button.Text = "Clear Origin/Dest";
            this.clearSort_button.UseVisualStyleBackColor = true;
            this.clearSort_button.Click += new System.EventHandler(this.clearSort_button_Click);
            // 
            // beforeDate_DTP
            // 
            this.beforeDate_DTP.CustomFormat = "h:mm tt";
            this.beforeDate_DTP.Enabled = false;
            this.beforeDate_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.beforeDate_DTP.Location = new System.Drawing.Point(321, 75);
            this.beforeDate_DTP.Name = "beforeDate_DTP";
            this.beforeDate_DTP.Size = new System.Drawing.Size(106, 20);
            this.beforeDate_DTP.TabIndex = 45;
            this.beforeDate_DTP.ValueChanged += new System.EventHandler(this.beforeDate_DTP_ValueChanged);
            // 
            // edit_arrival_label
            // 
            this.edit_arrival_label.AutoSize = true;
            this.edit_arrival_label.Location = new System.Drawing.Point(252, 77);
            this.edit_arrival_label.Name = "edit_arrival_label";
            this.edit_arrival_label.Size = new System.Drawing.Size(38, 13);
            this.edit_arrival_label.TabIndex = 49;
            this.edit_arrival_label.Text = "Before";
            // 
            // afterDate_DTP
            // 
            this.afterDate_DTP.CustomFormat = "h:mm tt";
            this.afterDate_DTP.Enabled = false;
            this.afterDate_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.afterDate_DTP.Location = new System.Drawing.Point(321, 44);
            this.afterDate_DTP.Name = "afterDate_DTP";
            this.afterDate_DTP.Size = new System.Drawing.Size(106, 20);
            this.afterDate_DTP.TabIndex = 44;
            this.afterDate_DTP.ValueChanged += new System.EventHandler(this.afterDate_DTP_ValueChanged);
            // 
            // edit_dept_label
            // 
            this.edit_dept_label.AutoSize = true;
            this.edit_dept_label.Location = new System.Drawing.Point(252, 50);
            this.edit_dept_label.Name = "edit_dept_label";
            this.edit_dept_label.Size = new System.Drawing.Size(29, 13);
            this.edit_dept_label.TabIndex = 48;
            this.edit_dept_label.Text = "After";
            // 
            // dest_combobox
            // 
            this.dest_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dest_combobox.Enabled = false;
            this.dest_combobox.FormattingEnabled = true;
            this.dest_combobox.Location = new System.Drawing.Point(75, 74);
            this.dest_combobox.Name = "dest_combobox";
            this.dest_combobox.Size = new System.Drawing.Size(121, 21);
            this.dest_combobox.TabIndex = 43;
            this.dest_combobox.SelectedIndexChanged += new System.EventHandler(this.dest_combobox_SelectedIndexChanged);
            // 
            // edit_dest_label
            // 
            this.edit_dest_label.AutoSize = true;
            this.edit_dest_label.Location = new System.Drawing.Point(11, 77);
            this.edit_dest_label.Name = "edit_dest_label";
            this.edit_dest_label.Size = new System.Drawing.Size(60, 13);
            this.edit_dest_label.TabIndex = 47;
            this.edit_dest_label.Text = "Destination";
            // 
            // origin_combobox
            // 
            this.origin_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origin_combobox.Enabled = false;
            this.origin_combobox.FormattingEnabled = true;
            this.origin_combobox.Location = new System.Drawing.Point(75, 42);
            this.origin_combobox.Name = "origin_combobox";
            this.origin_combobox.Size = new System.Drawing.Size(121, 21);
            this.origin_combobox.TabIndex = 42;
            this.origin_combobox.SelectedIndexChanged += new System.EventHandler(this.origin_combobox_SelectedIndexChanged);
            // 
            // edit_origin_label
            // 
            this.edit_origin_label.AutoSize = true;
            this.edit_origin_label.Location = new System.Drawing.Point(11, 50);
            this.edit_origin_label.Name = "edit_origin_label";
            this.edit_origin_label.Size = new System.Drawing.Size(34, 13);
            this.edit_origin_label.TabIndex = 46;
            this.edit_origin_label.Text = "Origin";
            // 
            // origin_dest_checkbox
            // 
            this.origin_dest_checkbox.AutoSize = true;
            this.origin_dest_checkbox.Location = new System.Drawing.Point(14, 18);
            this.origin_dest_checkbox.Name = "origin_dest_checkbox";
            this.origin_dest_checkbox.Size = new System.Drawing.Size(140, 17);
            this.origin_dest_checkbox.TabIndex = 53;
            this.origin_dest_checkbox.Text = "Only include flights from:";
            this.origin_dest_checkbox.UseVisualStyleBackColor = true;
            this.origin_dest_checkbox.CheckedChanged += new System.EventHandler(this.origin_dest_checkbox_CheckedChanged);
            // 
            // date_checkbox
            // 
            this.date_checkbox.AutoSize = true;
            this.date_checkbox.Location = new System.Drawing.Point(255, 18);
            this.date_checkbox.Name = "date_checkbox";
            this.date_checkbox.Size = new System.Drawing.Size(147, 17);
            this.date_checkbox.TabIndex = 54;
            this.date_checkbox.Text = "Only include flights dated:";
            this.date_checkbox.UseVisualStyleBackColor = true;
            this.date_checkbox.CheckedChanged += new System.EventHandler(this.date_checkbox_CheckedChanged);
            // 
            // generate_submit_button
            // 
            this.generate_submit_button.Location = new System.Drawing.Point(533, 139);
            this.generate_submit_button.Name = "generate_submit_button";
            this.generate_submit_button.Size = new System.Drawing.Size(121, 21);
            this.generate_submit_button.TabIndex = 60;
            this.generate_submit_button.Text = "Generate Report";
            this.generate_submit_button.UseVisualStyleBackColor = true;
            this.generate_submit_button.Click += new System.EventHandler(this.generate_submit_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "To generate report for specific flight sort with above criteria and use \"Single R" +
    "eport\" button.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "To generate full revenue report for all airports use \"Generate Report\" button.";
            // 
            // date_after_checkbox
            // 
            this.date_after_checkbox.AutoSize = true;
            this.date_after_checkbox.Enabled = false;
            this.date_after_checkbox.Location = new System.Drawing.Point(300, 47);
            this.date_after_checkbox.Name = "date_after_checkbox";
            this.date_after_checkbox.Size = new System.Drawing.Size(15, 14);
            this.date_after_checkbox.TabIndex = 63;
            this.date_after_checkbox.UseVisualStyleBackColor = true;
            this.date_after_checkbox.CheckedChanged += new System.EventHandler(this.date_after_checkbox_CheckedChanged);
            // 
            // date_before_checkbox
            // 
            this.date_before_checkbox.AutoSize = true;
            this.date_before_checkbox.Enabled = false;
            this.date_before_checkbox.Location = new System.Drawing.Point(300, 77);
            this.date_before_checkbox.Name = "date_before_checkbox";
            this.date_before_checkbox.Size = new System.Drawing.Size(15, 14);
            this.date_before_checkbox.TabIndex = 64;
            this.date_before_checkbox.UseVisualStyleBackColor = true;
            this.date_before_checkbox.CheckedChanged += new System.EventHandler(this.date_before_checkbox_CheckedChanged);
            // 
            // tools_groupbox
            // 
            this.tools_groupbox.Controls.Add(this.single_report_button);
            this.tools_groupbox.Controls.Add(this.flights_dataview);
            this.tools_groupbox.Controls.Add(this.date_before_checkbox);
            this.tools_groupbox.Controls.Add(this.label4);
            this.tools_groupbox.Controls.Add(this.label3);
            this.tools_groupbox.Controls.Add(this.date_after_checkbox);
            this.tools_groupbox.Controls.Add(this.generate_submit_button);
            this.tools_groupbox.Controls.Add(this.date_checkbox);
            this.tools_groupbox.Controls.Add(this.origin_dest_checkbox);
            this.tools_groupbox.Controls.Add(this.clearSort_button);
            this.tools_groupbox.Controls.Add(this.beforeDate_DTP);
            this.tools_groupbox.Controls.Add(this.edit_arrival_label);
            this.tools_groupbox.Controls.Add(this.afterDate_DTP);
            this.tools_groupbox.Controls.Add(this.edit_dept_label);
            this.tools_groupbox.Controls.Add(this.dest_combobox);
            this.tools_groupbox.Controls.Add(this.edit_dest_label);
            this.tools_groupbox.Controls.Add(this.origin_combobox);
            this.tools_groupbox.Controls.Add(this.edit_origin_label);
            this.tools_groupbox.Location = new System.Drawing.Point(21, 49);
            this.tools_groupbox.Name = "tools_groupbox";
            this.tools_groupbox.Size = new System.Drawing.Size(669, 548);
            this.tools_groupbox.TabIndex = 65;
            this.tools_groupbox.TabStop = false;
            this.tools_groupbox.Visible = false;
            // 
            // single_report_button
            // 
            this.single_report_button.Location = new System.Drawing.Point(533, 162);
            this.single_report_button.Name = "single_report_button";
            this.single_report_button.Size = new System.Drawing.Size(121, 21);
            this.single_report_button.TabIndex = 65;
            this.single_report_button.Text = "Single Report";
            this.single_report_button.UseVisualStyleBackColor = true;
            this.single_report_button.Click += new System.EventHandler(this.single_report_button_Click);
            // 
            // singleflight_report_groupbox
            // 
            this.singleflight_report_groupbox.Controls.Add(this.label14);
            this.singleflight_report_groupbox.Controls.Add(this.label7);
            this.singleflight_report_groupbox.Controls.Add(this.single_transactions_datagridview);
            this.singleflight_report_groupbox.Controls.Add(this.single_arrivalDate_label);
            this.singleflight_report_groupbox.Controls.Add(this.single_depDate_label);
            this.singleflight_report_groupbox.Controls.Add(this.single_destCode_label);
            this.singleflight_report_groupbox.Controls.Add(this.single_originCode_label);
            this.singleflight_report_groupbox.Controls.Add(this.single_flightID_label);
            this.singleflight_report_groupbox.Controls.Add(this.label13);
            this.singleflight_report_groupbox.Controls.Add(this.label10);
            this.singleflight_report_groupbox.Controls.Add(this.label9);
            this.singleflight_report_groupbox.Controls.Add(this.label8);
            this.singleflight_report_groupbox.Controls.Add(this.label24);
            this.singleflight_report_groupbox.Controls.Add(this.single_pointRev_label);
            this.singleflight_report_groupbox.Controls.Add(this.single_cardRev_label);
            this.singleflight_report_groupbox.Controls.Add(this.label11);
            this.singleflight_report_groupbox.Controls.Add(this.label12);
            this.singleflight_report_groupbox.Controls.Add(this.single_percFill_label);
            this.singleflight_report_groupbox.Controls.Add(this.single_curr_cap_label);
            this.singleflight_report_groupbox.Controls.Add(this.single_max_cap_label);
            this.singleflight_report_groupbox.Controls.Add(this.label6);
            this.singleflight_report_groupbox.Controls.Add(this.label5);
            this.singleflight_report_groupbox.Controls.Add(this.label2);
            this.singleflight_report_groupbox.Controls.Add(this.close_single_report_button);
            this.singleflight_report_groupbox.Location = new System.Drawing.Point(21, 49);
            this.singleflight_report_groupbox.Name = "singleflight_report_groupbox";
            this.singleflight_report_groupbox.Size = new System.Drawing.Size(669, 548);
            this.singleflight_report_groupbox.TabIndex = 66;
            this.singleflight_report_groupbox.TabStop = false;
            this.singleflight_report_groupbox.Text = "Single Flight Report";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "%";
            // 
            // single_transactions_datagridview
            // 
            this.single_transactions_datagridview.AllowUserToAddRows = false;
            this.single_transactions_datagridview.AllowUserToDeleteRows = false;
            this.single_transactions_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.single_transactions_datagridview.Location = new System.Drawing.Point(14, 189);
            this.single_transactions_datagridview.Name = "single_transactions_datagridview";
            this.single_transactions_datagridview.ReadOnly = true;
            this.single_transactions_datagridview.Size = new System.Drawing.Size(640, 339);
            this.single_transactions_datagridview.TabIndex = 24;
            // 
            // single_arrivalDate_label
            // 
            this.single_arrivalDate_label.AutoSize = true;
            this.single_arrivalDate_label.Location = new System.Drawing.Point(202, 74);
            this.single_arrivalDate_label.Name = "single_arrivalDate_label";
            this.single_arrivalDate_label.Size = new System.Drawing.Size(10, 13);
            this.single_arrivalDate_label.TabIndex = 23;
            this.single_arrivalDate_label.Text = "-";
            // 
            // single_depDate_label
            // 
            this.single_depDate_label.AutoSize = true;
            this.single_depDate_label.Location = new System.Drawing.Point(202, 51);
            this.single_depDate_label.Name = "single_depDate_label";
            this.single_depDate_label.Size = new System.Drawing.Size(10, 13);
            this.single_depDate_label.TabIndex = 22;
            this.single_depDate_label.Text = "-";
            // 
            // single_destCode_label
            // 
            this.single_destCode_label.AutoSize = true;
            this.single_destCode_label.Location = new System.Drawing.Point(63, 74);
            this.single_destCode_label.Name = "single_destCode_label";
            this.single_destCode_label.Size = new System.Drawing.Size(10, 13);
            this.single_destCode_label.TabIndex = 21;
            this.single_destCode_label.Text = "-";
            // 
            // single_originCode_label
            // 
            this.single_originCode_label.AutoSize = true;
            this.single_originCode_label.Location = new System.Drawing.Point(63, 51);
            this.single_originCode_label.Name = "single_originCode_label";
            this.single_originCode_label.Size = new System.Drawing.Size(10, 13);
            this.single_originCode_label.TabIndex = 20;
            this.single_originCode_label.Text = "-";
            // 
            // single_flightID_label
            // 
            this.single_flightID_label.AutoSize = true;
            this.single_flightID_label.Location = new System.Drawing.Point(63, 29);
            this.single_flightID_label.Name = "single_flightID_label";
            this.single_flightID_label.Size = new System.Drawing.Size(10, 13);
            this.single_flightID_label.TabIndex = 19;
            this.single_flightID_label.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Arrival";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Departure";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "From";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "Flight ID";
            // 
            // single_pointRev_label
            // 
            this.single_pointRev_label.AutoSize = true;
            this.single_pointRev_label.Location = new System.Drawing.Point(343, 147);
            this.single_pointRev_label.Name = "single_pointRev_label";
            this.single_pointRev_label.Size = new System.Drawing.Size(10, 13);
            this.single_pointRev_label.TabIndex = 11;
            this.single_pointRev_label.Text = "-";
            // 
            // single_cardRev_label
            // 
            this.single_cardRev_label.AutoSize = true;
            this.single_cardRev_label.Location = new System.Drawing.Point(343, 126);
            this.single_cardRev_label.Name = "single_cardRev_label";
            this.single_cardRev_label.Size = new System.Drawing.Size(10, 13);
            this.single_cardRev_label.TabIndex = 10;
            this.single_cardRev_label.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Reward Point Revenue";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Revenue from Cards";
            // 
            // single_percFill_label
            // 
            this.single_percFill_label.AutoSize = true;
            this.single_percFill_label.Location = new System.Drawing.Point(117, 167);
            this.single_percFill_label.Name = "single_percFill_label";
            this.single_percFill_label.Size = new System.Drawing.Size(10, 13);
            this.single_percFill_label.TabIndex = 6;
            this.single_percFill_label.Text = "-";
            // 
            // single_curr_cap_label
            // 
            this.single_curr_cap_label.AutoSize = true;
            this.single_curr_cap_label.Location = new System.Drawing.Point(117, 147);
            this.single_curr_cap_label.Name = "single_curr_cap_label";
            this.single_curr_cap_label.Size = new System.Drawing.Size(10, 13);
            this.single_curr_cap_label.TabIndex = 5;
            this.single_curr_cap_label.Text = "-";
            // 
            // single_max_cap_label
            // 
            this.single_max_cap_label.AutoSize = true;
            this.single_max_cap_label.Location = new System.Drawing.Point(117, 126);
            this.single_max_cap_label.Name = "single_max_cap_label";
            this.single_max_cap_label.Size = new System.Drawing.Size(10, 13);
            this.single_max_cap_label.TabIndex = 4;
            this.single_max_cap_label.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Percentage Fill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Current Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Capacity";
            // 
            // close_single_report_button
            // 
            this.close_single_report_button.Location = new System.Drawing.Point(579, 19);
            this.close_single_report_button.Name = "close_single_report_button";
            this.close_single_report_button.Size = new System.Drawing.Size(75, 23);
            this.close_single_report_button.TabIndex = 0;
            this.close_single_report_button.Text = "CloseReport";
            this.close_single_report_button.UseVisualStyleBackColor = true;
            this.close_single_report_button.Click += new System.EventHandler(this.close_single_report_button_Click);
            // 
            // fullReport_groupbox
            // 
            this.fullReport_groupbox.Controls.Add(this.full_report_datagridview);
            this.fullReport_groupbox.Controls.Add(this.label1);
            this.fullReport_groupbox.Controls.Add(this.full_report_close_button);
            this.fullReport_groupbox.Controls.Add(this.label26);
            this.fullReport_groupbox.Controls.Add(this.full_flightCount_label);
            this.fullReport_groupbox.Controls.Add(this.label30);
            this.fullReport_groupbox.Controls.Add(this.label29);
            this.fullReport_groupbox.Controls.Add(this.full_cardRev_label);
            this.fullReport_groupbox.Controls.Add(this.full_pointRev_label);
            this.fullReport_groupbox.Location = new System.Drawing.Point(21, 49);
            this.fullReport_groupbox.Name = "fullReport_groupbox";
            this.fullReport_groupbox.Size = new System.Drawing.Size(669, 548);
            this.fullReport_groupbox.TabIndex = 67;
            this.fullReport_groupbox.TabStop = false;
            this.fullReport_groupbox.Text = "Full Report";
            // 
            // full_report_datagridview
            // 
            this.full_report_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.full_report_datagridview.Location = new System.Drawing.Point(14, 90);
            this.full_report_datagridview.Name = "full_report_datagridview";
            this.full_report_datagridview.Size = new System.Drawing.Size(640, 438);
            this.full_report_datagridview.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "$";
            // 
            // full_report_close_button
            // 
            this.full_report_close_button.Location = new System.Drawing.Point(579, 18);
            this.full_report_close_button.Name = "full_report_close_button";
            this.full_report_close_button.Size = new System.Drawing.Size(75, 23);
            this.full_report_close_button.TabIndex = 1;
            this.full_report_close_button.Text = "CloseReport";
            this.full_report_close_button.UseVisualStyleBackColor = true;
            this.full_report_close_button.Click += new System.EventHandler(this.full_report_close_button_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(11, 24);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(168, 13);
            this.label26.TabIndex = 78;
            this.label26.Text = "Number of currently booked flights";
            // 
            // full_flightCount_label
            // 
            this.full_flightCount_label.AutoSize = true;
            this.full_flightCount_label.Location = new System.Drawing.Point(186, 24);
            this.full_flightCount_label.Name = "full_flightCount_label";
            this.full_flightCount_label.Size = new System.Drawing.Size(10, 13);
            this.full_flightCount_label.TabIndex = 83;
            this.full_flightCount_label.Text = "-";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(11, 44);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 13);
            this.label30.TabIndex = 74;
            this.label30.Text = "Revenue from Cards";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 65);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(118, 13);
            this.label29.TabIndex = 75;
            this.label29.Text = "Reward Point Revenue";
            // 
            // full_cardRev_label
            // 
            this.full_cardRev_label.AutoSize = true;
            this.full_cardRev_label.Location = new System.Drawing.Point(144, 44);
            this.full_cardRev_label.Name = "full_cardRev_label";
            this.full_cardRev_label.Size = new System.Drawing.Size(10, 13);
            this.full_cardRev_label.TabIndex = 76;
            this.full_cardRev_label.Text = "-";
            // 
            // full_pointRev_label
            // 
            this.full_pointRev_label.AutoSize = true;
            this.full_pointRev_label.Location = new System.Drawing.Point(144, 65);
            this.full_pointRev_label.Name = "full_pointRev_label";
            this.full_pointRev_label.Size = new System.Drawing.Size(10, 13);
            this.full_pointRev_label.TabIndex = 77;
            this.full_pointRev_label.Text = "-";
            // 
            // AccountantLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 609);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.singleflight_report_groupbox);
            this.Controls.Add(this.tools_groupbox);
            this.Controls.Add(this.fullReport_groupbox);
            this.Name = "AccountantLandingPage";
            this.Text = "Accountant Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountantLandingPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.flights_dataview)).EndInit();
            this.tools_groupbox.ResumeLayout(false);
            this.tools_groupbox.PerformLayout();
            this.singleflight_report_groupbox.ResumeLayout(false);
            this.singleflight_report_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.single_transactions_datagridview)).EndInit();
            this.fullReport_groupbox.ResumeLayout(false);
            this.fullReport_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.full_report_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.DataGridView flights_dataview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button clearSort_button;
        private System.Windows.Forms.DateTimePicker beforeDate_DTP;
        private System.Windows.Forms.Label edit_arrival_label;
        private System.Windows.Forms.DateTimePicker afterDate_DTP;
        private System.Windows.Forms.Label edit_dept_label;
        private System.Windows.Forms.ComboBox dest_combobox;
        private System.Windows.Forms.Label edit_dest_label;
        private System.Windows.Forms.ComboBox origin_combobox;
        private System.Windows.Forms.Label edit_origin_label;
        private System.Windows.Forms.CheckBox origin_dest_checkbox;
        private System.Windows.Forms.CheckBox date_checkbox;
        private System.Windows.Forms.Button generate_submit_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox date_after_checkbox;
        private System.Windows.Forms.CheckBox date_before_checkbox;
        private System.Windows.Forms.GroupBox tools_groupbox;
        private System.Windows.Forms.GroupBox singleflight_report_groupbox;
        private System.Windows.Forms.Button close_single_report_button;
        private System.Windows.Forms.DataGridView single_transactions_datagridview;
        private System.Windows.Forms.Label single_arrivalDate_label;
        private System.Windows.Forms.Label single_depDate_label;
        private System.Windows.Forms.Label single_destCode_label;
        private System.Windows.Forms.Label single_originCode_label;
        private System.Windows.Forms.Label single_flightID_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label single_pointRev_label;
        private System.Windows.Forms.Label single_cardRev_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label single_percFill_label;
        private System.Windows.Forms.Label single_curr_cap_label;
        private System.Windows.Forms.Label single_max_cap_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button single_report_button;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox fullReport_groupbox;
        private System.Windows.Forms.Button full_report_close_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label full_flightCount_label;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label full_cardRev_label;
        private System.Windows.Forms.Label full_pointRev_label;
        private System.Windows.Forms.DataGridView full_report_datagridview;
    }
}