
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
            this.edit_distanceValue_label = new System.Windows.Forms.Label();
            this.edit_distance_label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.edit_submit_btn = new System.Windows.Forms.Button();
            this.edit_arrival_time_DTP = new System.Windows.Forms.DateTimePicker();
            this.edit_arrival_label = new System.Windows.Forms.Label();
            this.edit_depart_time_DTP = new System.Windows.Forms.DateTimePicker();
            this.edit_dept_label = new System.Windows.Forms.Label();
            this.edit_dest_combobox = new System.Windows.Forms.ComboBox();
            this.edit_dest_label = new System.Windows.Forms.Label();
            this.edit_origin_combobox = new System.Windows.Forms.ComboBox();
            this.edit_origin_label = new System.Windows.Forms.Label();
            this.deleteRoute_groupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.del_selected_route_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.originAbvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destAbvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.air3550DBDataSet = new Air3550.Air3550DBDataSet();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logout_button = new System.Windows.Forms.Button();
            this.add_status_label = new System.Windows.Forms.Label();
            this.flightsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.flightsTableAdapter1 = new Air3550.Air3550DBDataSetTableAdapters.FlightsTableAdapter();
            this.originAbvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destAbvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currCapacityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRoute_groupBox.SuspendLayout();
            this.editRoute_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.deleteRoute_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.air3550DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource2)).BeginInit();
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
            this.addRoute_groupBox.Location = new System.Drawing.Point(24, 98);
            this.addRoute_groupBox.Name = "addRoute_groupBox";
            this.addRoute_groupBox.Size = new System.Drawing.Size(630, 379);
            this.addRoute_groupBox.TabIndex = 4;
            this.addRoute_groupBox.TabStop = false;
            this.addRoute_groupBox.Text = "Add Route";
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
            this.add_arrival_time_DTP.CustomFormat = "";
            this.add_arrival_time_DTP.Enabled = false;
            this.add_arrival_time_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.add_arrival_time_DTP.Location = new System.Drawing.Point(88, 127);
            this.add_arrival_time_DTP.Name = "add_arrival_time_DTP";
            this.add_arrival_time_DTP.ShowUpDown = true;
            this.add_arrival_time_DTP.Size = new System.Drawing.Size(96, 20);
            this.add_arrival_time_DTP.TabIndex = 10;
            // 
            // add_depart_time_DTP
            // 
            this.add_depart_time_DTP.CustomFormat = "";
            this.add_depart_time_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
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
            this.editRoute_groupBox.Controls.Add(this.edit_distanceValue_label);
            this.editRoute_groupBox.Controls.Add(this.edit_distance_label);
            this.editRoute_groupBox.Controls.Add(this.dataGridView2);
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
            // edit_distanceValue_label
            // 
            this.edit_distanceValue_label.AutoSize = true;
            this.edit_distanceValue_label.Location = new System.Drawing.Point(519, 30);
            this.edit_distanceValue_label.Name = "edit_distanceValue_label";
            this.edit_distanceValue_label.Size = new System.Drawing.Size(13, 13);
            this.edit_distanceValue_label.TabIndex = 29;
            this.edit_distanceValue_label.Text = "0";
            // 
            // edit_distance_label
            // 
            this.edit_distance_label.AutoSize = true;
            this.edit_distance_label.Location = new System.Drawing.Point(458, 30);
            this.edit_distance_label.Name = "edit_distance_label";
            this.edit_distance_label.Size = new System.Drawing.Size(49, 13);
            this.edit_distance_label.TabIndex = 28;
            this.edit_distance_label.Text = "Distance";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.originAbvDataGridViewTextBoxColumn1,
            this.destAbvDataGridViewTextBoxColumn1,
            this.departureTimeDataGridViewTextBoxColumn1,
            this.arrivalTimeDataGridViewTextBoxColumn1,
            this.maxCapacityDataGridViewTextBoxColumn,
            this.currCapacityDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.flightsBindingSource2;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(6, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(318, 248);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // edit_submit_btn
            // 
            this.edit_submit_btn.Location = new System.Drawing.Point(394, 183);
            this.edit_submit_btn.Name = "edit_submit_btn";
            this.edit_submit_btn.Size = new System.Drawing.Size(102, 23);
            this.edit_submit_btn.TabIndex = 17;
            this.edit_submit_btn.Text = "Submit Changes";
            this.edit_submit_btn.UseVisualStyleBackColor = true;
            // 
            // edit_arrival_time_DTP
            // 
            this.edit_arrival_time_DTP.Enabled = false;
            this.edit_arrival_time_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.edit_arrival_time_DTP.Location = new System.Drawing.Point(308, 51);
            this.edit_arrival_time_DTP.Name = "edit_arrival_time_DTP";
            this.edit_arrival_time_DTP.ShowUpDown = true;
            this.edit_arrival_time_DTP.Size = new System.Drawing.Size(86, 20);
            this.edit_arrival_time_DTP.TabIndex = 16;
            // 
            // edit_arrival_label
            // 
            this.edit_arrival_label.AutoSize = true;
            this.edit_arrival_label.Location = new System.Drawing.Point(244, 57);
            this.edit_arrival_label.Name = "edit_arrival_label";
            this.edit_arrival_label.Size = new System.Drawing.Size(36, 13);
            this.edit_arrival_label.TabIndex = 25;
            this.edit_arrival_label.Text = "Arrival";
            // 
            // edit_depart_time_DTP
            // 
            this.edit_depart_time_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.edit_depart_time_DTP.Location = new System.Drawing.Point(308, 24);
            this.edit_depart_time_DTP.Name = "edit_depart_time_DTP";
            this.edit_depart_time_DTP.ShowUpDown = true;
            this.edit_depart_time_DTP.Size = new System.Drawing.Size(86, 20);
            this.edit_depart_time_DTP.TabIndex = 15;
            // 
            // edit_dept_label
            // 
            this.edit_dept_label.AutoSize = true;
            this.edit_dept_label.Location = new System.Drawing.Point(244, 30);
            this.edit_dept_label.Name = "edit_dept_label";
            this.edit_dept_label.Size = new System.Drawing.Size(54, 13);
            this.edit_dept_label.TabIndex = 21;
            this.edit_dept_label.Text = "Departure";
            // 
            // edit_dest_combobox
            // 
            this.edit_dest_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edit_dest_combobox.FormattingEnabled = true;
            this.edit_dest_combobox.Location = new System.Drawing.Point(78, 54);
            this.edit_dest_combobox.Name = "edit_dest_combobox";
            this.edit_dest_combobox.Size = new System.Drawing.Size(121, 21);
            this.edit_dest_combobox.TabIndex = 14;
            // 
            // edit_dest_label
            // 
            this.edit_dest_label.AutoSize = true;
            this.edit_dest_label.Location = new System.Drawing.Point(14, 57);
            this.edit_dest_label.Name = "edit_dest_label";
            this.edit_dest_label.Size = new System.Drawing.Size(60, 13);
            this.edit_dest_label.TabIndex = 18;
            this.edit_dest_label.Text = "Destination";
            // 
            // edit_origin_combobox
            // 
            this.edit_origin_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edit_origin_combobox.FormattingEnabled = true;
            this.edit_origin_combobox.Location = new System.Drawing.Point(78, 22);
            this.edit_origin_combobox.Name = "edit_origin_combobox";
            this.edit_origin_combobox.Size = new System.Drawing.Size(121, 21);
            this.edit_origin_combobox.TabIndex = 13;
            // 
            // edit_origin_label
            // 
            this.edit_origin_label.AutoSize = true;
            this.edit_origin_label.Location = new System.Drawing.Point(14, 30);
            this.edit_origin_label.Name = "edit_origin_label";
            this.edit_origin_label.Size = new System.Drawing.Size(34, 13);
            this.edit_origin_label.TabIndex = 16;
            this.edit_origin_label.Text = "Origin";
            // 
            // deleteRoute_groupBox
            // 
            this.deleteRoute_groupBox.Controls.Add(this.button1);
            this.deleteRoute_groupBox.Controls.Add(this.del_selected_route_label);
            this.deleteRoute_groupBox.Controls.Add(this.dataGridView1);
            this.deleteRoute_groupBox.Location = new System.Drawing.Point(33, 98);
            this.deleteRoute_groupBox.Name = "deleteRoute_groupBox";
            this.deleteRoute_groupBox.Size = new System.Drawing.Size(627, 499);
            this.deleteRoute_groupBox.TabIndex = 6;
            this.deleteRoute_groupBox.TabStop = false;
            this.deleteRoute_groupBox.Text = "Delete Route";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Delete Route";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // del_selected_route_label
            // 
            this.del_selected_route_label.AutoSize = true;
            this.del_selected_route_label.Location = new System.Drawing.Point(22, 425);
            this.del_selected_route_label.Name = "del_selected_route_label";
            this.del_selected_route_label.Size = new System.Drawing.Size(104, 13);
            this.del_selected_route_label.TabIndex = 7;
            this.del_selected_route_label.Text = "Selected Route ID : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.originAbvDataGridViewTextBoxColumn,
            this.destAbvDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.planeTypeDataGridViewTextBoxColumn,
            this.currCapacityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(524, 383);
            this.dataGridView1.TabIndex = 7;
            // 
            // originAbvDataGridViewTextBoxColumn
            // 
            this.originAbvDataGridViewTextBoxColumn.DataPropertyName = "originAbv";
            this.originAbvDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originAbvDataGridViewTextBoxColumn.Name = "originAbvDataGridViewTextBoxColumn";
            this.originAbvDataGridViewTextBoxColumn.ReadOnly = true;
            this.originAbvDataGridViewTextBoxColumn.Width = 40;
            // 
            // destAbvDataGridViewTextBoxColumn
            // 
            this.destAbvDataGridViewTextBoxColumn.DataPropertyName = "destAbv";
            this.destAbvDataGridViewTextBoxColumn.HeaderText = "Dest";
            this.destAbvDataGridViewTextBoxColumn.Name = "destAbvDataGridViewTextBoxColumn";
            this.destAbvDataGridViewTextBoxColumn.ReadOnly = true;
            this.destAbvDataGridViewTextBoxColumn.Width = 40;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "departureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "Dept";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "arrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "Arriv";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planeTypeDataGridViewTextBoxColumn
            // 
            this.planeTypeDataGridViewTextBoxColumn.DataPropertyName = "PlaneType";
            this.planeTypeDataGridViewTextBoxColumn.HeaderText = "PlaneType";
            this.planeTypeDataGridViewTextBoxColumn.Name = "planeTypeDataGridViewTextBoxColumn";
            this.planeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currCapacityDataGridViewTextBoxColumn
            // 
            this.currCapacityDataGridViewTextBoxColumn.DataPropertyName = "currCapacity";
            this.currCapacityDataGridViewTextBoxColumn.HeaderText = "Curr Capacity";
            this.currCapacityDataGridViewTextBoxColumn.Name = "currCapacityDataGridViewTextBoxColumn";
            this.currCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightsBindingSource1
            // 
            this.flightsBindingSource1.DataMember = "Flights";
            this.flightsBindingSource1.DataSource = this.air3550DBDataSet;
            // 
            // air3550DBDataSet
            // 
            this.air3550DBDataSet.DataSetName = "Air3550DBDataSet";
            this.air3550DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // add_status_label
            // 
            this.add_status_label.AutoSize = true;
            this.add_status_label.Location = new System.Drawing.Point(206, 193);
            this.add_status_label.Name = "add_status_label";
            this.add_status_label.Size = new System.Drawing.Size(16, 13);
            this.add_status_label.TabIndex = 37;
            this.add_status_label.Text = "---";
            // 
            // flightsBindingSource2
            // 
            this.flightsBindingSource2.DataMember = "Flights";
            this.flightsBindingSource2.DataSource = this.air3550DBDataSet;
            // 
            // flightsTableAdapter1
            // 
            this.flightsTableAdapter1.ClearBeforeFill = true;
            // 
            // originAbvDataGridViewTextBoxColumn1
            // 
            this.originAbvDataGridViewTextBoxColumn1.DataPropertyName = "originAbv";
            this.originAbvDataGridViewTextBoxColumn1.HeaderText = "Origin";
            this.originAbvDataGridViewTextBoxColumn1.Name = "originAbvDataGridViewTextBoxColumn1";
            // 
            // destAbvDataGridViewTextBoxColumn1
            // 
            this.destAbvDataGridViewTextBoxColumn1.DataPropertyName = "destAbv";
            this.destAbvDataGridViewTextBoxColumn1.HeaderText = "Destination";
            this.destAbvDataGridViewTextBoxColumn1.Name = "destAbvDataGridViewTextBoxColumn1";
            // 
            // departureTimeDataGridViewTextBoxColumn1
            // 
            this.departureTimeDataGridViewTextBoxColumn1.DataPropertyName = "departureTime";
            this.departureTimeDataGridViewTextBoxColumn1.HeaderText = "Departure";
            this.departureTimeDataGridViewTextBoxColumn1.Name = "departureTimeDataGridViewTextBoxColumn1";
            // 
            // arrivalTimeDataGridViewTextBoxColumn1
            // 
            this.arrivalTimeDataGridViewTextBoxColumn1.DataPropertyName = "arrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn1.HeaderText = "Arrival";
            this.arrivalTimeDataGridViewTextBoxColumn1.Name = "arrivalTimeDataGridViewTextBoxColumn1";
            // 
            // maxCapacityDataGridViewTextBoxColumn
            // 
            this.maxCapacityDataGridViewTextBoxColumn.DataPropertyName = "maxCapacity";
            this.maxCapacityDataGridViewTextBoxColumn.HeaderText = "Max Seats";
            this.maxCapacityDataGridViewTextBoxColumn.Name = "maxCapacityDataGridViewTextBoxColumn";
            // 
            // currCapacityDataGridViewTextBoxColumn1
            // 
            this.currCapacityDataGridViewTextBoxColumn1.DataPropertyName = "currCapacity";
            this.currCapacityDataGridViewTextBoxColumn1.HeaderText = "Filled Seats";
            this.currCapacityDataGridViewTextBoxColumn1.Name = "currCapacityDataGridViewTextBoxColumn1";
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
            this.Load += new System.EventHandler(this.LoadEngLandingPage_Load);
            this.addRoute_groupBox.ResumeLayout(false);
            this.addRoute_groupBox.PerformLayout();
            this.editRoute_groupBox.ResumeLayout(false);
            this.editRoute_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.deleteRoute_groupBox.ResumeLayout(false);
            this.deleteRoute_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.air3550DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource2)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label del_selected_route_label;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label edit_distanceValue_label;
        private System.Windows.Forms.Label edit_distance_label;
        private System.Windows.Forms.Label add_distanceValue_label;
        private System.Windows.Forms.Label add_distance_label;
        private Air3550DBDataSet air3550DBDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn originAbvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destAbvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currCapacityDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn originAbvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn destAbvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currCapacityDataGridViewTextBoxColumn1;
    }
}