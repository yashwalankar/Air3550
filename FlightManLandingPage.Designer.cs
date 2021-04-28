
namespace Air3550
{
    partial class FlightManLandingPage
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
            this.flights_dataview = new System.Windows.Forms.DataGridView();
            this.flightman_welcome_label = new System.Windows.Forms.Label();
            this.printManifest_btn = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.flight_search_groupbox = new System.Windows.Forms.GroupBox();
            this.date_before_checkbox = new System.Windows.Forms.CheckBox();
            this.date_after_checkbox = new System.Windows.Forms.CheckBox();
            this.date_checkbox = new System.Windows.Forms.CheckBox();
            this.origin_dest_checkbox = new System.Windows.Forms.CheckBox();
            this.clearSort_button = new System.Windows.Forms.Button();
            this.beforeDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.edit_arrival_label = new System.Windows.Forms.Label();
            this.afterDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.edit_dept_label = new System.Windows.Forms.Label();
            this.dest_combobox = new System.Windows.Forms.ComboBox();
            this.edit_dest_label = new System.Windows.Forms.Label();
            this.origin_combobox = new System.Windows.Forms.ComboBox();
            this.edit_origin_label = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.manifest_groupbox = new System.Windows.Forms.GroupBox();
            this.manifest_datagridview = new System.Windows.Forms.DataGridView();
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
            this.manifest_close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flights_dataview)).BeginInit();
            this.flight_search_groupbox.SuspendLayout();
            this.manifest_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manifest_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // flights_dataview
            // 
            this.flights_dataview.AllowUserToAddRows = false;
            this.flights_dataview.AllowUserToDeleteRows = false;
            this.flights_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flights_dataview.Location = new System.Drawing.Point(15, 194);
            this.flights_dataview.Name = "flights_dataview";
            this.flights_dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flights_dataview.Size = new System.Drawing.Size(640, 339);
            this.flights_dataview.TabIndex = 0;
            // 
            // flightman_welcome_label
            // 
            this.flightman_welcome_label.AutoSize = true;
            this.flightman_welcome_label.Location = new System.Drawing.Point(34, 24);
            this.flightman_welcome_label.Name = "flightman_welcome_label";
            this.flightman_welcome_label.Size = new System.Drawing.Size(128, 13);
            this.flightman_welcome_label.TabIndex = 1;
            this.flightman_welcome_label.Text = "Welcome, Flight Manager";
            // 
            // printManifest_btn
            // 
            this.printManifest_btn.Location = new System.Drawing.Point(567, 165);
            this.printManifest_btn.Name = "printManifest_btn";
            this.printManifest_btn.Size = new System.Drawing.Size(88, 23);
            this.printManifest_btn.TabIndex = 3;
            this.printManifest_btn.Text = "Print Manifest";
            this.printManifest_btn.UseVisualStyleBackColor = true;
            this.printManifest_btn.Click += new System.EventHandler(this.printManifest_btn_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(713, 12);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 23);
            this.logout_button.TabIndex = 11;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // flight_search_groupbox
            // 
            this.flight_search_groupbox.Controls.Add(this.date_before_checkbox);
            this.flight_search_groupbox.Controls.Add(this.date_after_checkbox);
            this.flight_search_groupbox.Controls.Add(this.date_checkbox);
            this.flight_search_groupbox.Controls.Add(this.origin_dest_checkbox);
            this.flight_search_groupbox.Controls.Add(this.clearSort_button);
            this.flight_search_groupbox.Controls.Add(this.beforeDate_DTP);
            this.flight_search_groupbox.Controls.Add(this.edit_arrival_label);
            this.flight_search_groupbox.Controls.Add(this.afterDate_DTP);
            this.flight_search_groupbox.Controls.Add(this.edit_dept_label);
            this.flight_search_groupbox.Controls.Add(this.dest_combobox);
            this.flight_search_groupbox.Controls.Add(this.edit_dest_label);
            this.flight_search_groupbox.Controls.Add(this.origin_combobox);
            this.flight_search_groupbox.Controls.Add(this.edit_origin_label);
            this.flight_search_groupbox.Controls.Add(this.flights_dataview);
            this.flight_search_groupbox.Controls.Add(this.printManifest_btn);
            this.flight_search_groupbox.Location = new System.Drawing.Point(22, 49);
            this.flight_search_groupbox.Name = "flight_search_groupbox";
            this.flight_search_groupbox.Size = new System.Drawing.Size(669, 548);
            this.flight_search_groupbox.TabIndex = 27;
            this.flight_search_groupbox.TabStop = false;
            this.flight_search_groupbox.Text = "Flight Selection";
            // 
            // date_before_checkbox
            // 
            this.date_before_checkbox.AutoSize = true;
            this.date_before_checkbox.Enabled = false;
            this.date_before_checkbox.Location = new System.Drawing.Point(301, 87);
            this.date_before_checkbox.Name = "date_before_checkbox";
            this.date_before_checkbox.Size = new System.Drawing.Size(15, 14);
            this.date_before_checkbox.TabIndex = 77;
            this.date_before_checkbox.UseVisualStyleBackColor = true;
            this.date_before_checkbox.CheckedChanged += new System.EventHandler(this.date_before_checkbox_CheckedChanged);
            // 
            // date_after_checkbox
            // 
            this.date_after_checkbox.AutoSize = true;
            this.date_after_checkbox.Enabled = false;
            this.date_after_checkbox.Location = new System.Drawing.Point(301, 57);
            this.date_after_checkbox.Name = "date_after_checkbox";
            this.date_after_checkbox.Size = new System.Drawing.Size(15, 14);
            this.date_after_checkbox.TabIndex = 76;
            this.date_after_checkbox.UseVisualStyleBackColor = true;
            this.date_after_checkbox.CheckedChanged += new System.EventHandler(this.date_after_checkbox_CheckedChanged);
            // 
            // date_checkbox
            // 
            this.date_checkbox.AutoSize = true;
            this.date_checkbox.Location = new System.Drawing.Point(256, 28);
            this.date_checkbox.Name = "date_checkbox";
            this.date_checkbox.Size = new System.Drawing.Size(147, 17);
            this.date_checkbox.TabIndex = 75;
            this.date_checkbox.Text = "Only include flights dated:";
            this.date_checkbox.UseVisualStyleBackColor = true;
            this.date_checkbox.CheckedChanged += new System.EventHandler(this.date_checkbox_CheckedChanged);
            // 
            // origin_dest_checkbox
            // 
            this.origin_dest_checkbox.AutoSize = true;
            this.origin_dest_checkbox.Location = new System.Drawing.Point(15, 28);
            this.origin_dest_checkbox.Name = "origin_dest_checkbox";
            this.origin_dest_checkbox.Size = new System.Drawing.Size(140, 17);
            this.origin_dest_checkbox.TabIndex = 74;
            this.origin_dest_checkbox.Text = "Only include flights from:";
            this.origin_dest_checkbox.UseVisualStyleBackColor = true;
            this.origin_dest_checkbox.CheckedChanged += new System.EventHandler(this.origin_dest_checkbox_CheckedChanged);
            // 
            // clearSort_button
            // 
            this.clearSort_button.Enabled = false;
            this.clearSort_button.Location = new System.Drawing.Point(76, 117);
            this.clearSort_button.Name = "clearSort_button";
            this.clearSort_button.Size = new System.Drawing.Size(121, 21);
            this.clearSort_button.TabIndex = 73;
            this.clearSort_button.Text = "Clear Origin/Dest";
            this.clearSort_button.UseVisualStyleBackColor = true;
            this.clearSort_button.Click += new System.EventHandler(this.clearSort_button_Click);
            // 
            // beforeDate_DTP
            // 
            this.beforeDate_DTP.CustomFormat = "h:mm tt";
            this.beforeDate_DTP.Enabled = false;
            this.beforeDate_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.beforeDate_DTP.Location = new System.Drawing.Point(322, 85);
            this.beforeDate_DTP.Name = "beforeDate_DTP";
            this.beforeDate_DTP.Size = new System.Drawing.Size(106, 20);
            this.beforeDate_DTP.TabIndex = 68;
            this.beforeDate_DTP.ValueChanged += new System.EventHandler(this.beforeDate_DTP_ValueChanged);
            // 
            // edit_arrival_label
            // 
            this.edit_arrival_label.AutoSize = true;
            this.edit_arrival_label.Location = new System.Drawing.Point(253, 87);
            this.edit_arrival_label.Name = "edit_arrival_label";
            this.edit_arrival_label.Size = new System.Drawing.Size(38, 13);
            this.edit_arrival_label.TabIndex = 72;
            this.edit_arrival_label.Text = "Before";
            // 
            // afterDate_DTP
            // 
            this.afterDate_DTP.CustomFormat = "h:mm tt";
            this.afterDate_DTP.Enabled = false;
            this.afterDate_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.afterDate_DTP.Location = new System.Drawing.Point(322, 54);
            this.afterDate_DTP.Name = "afterDate_DTP";
            this.afterDate_DTP.Size = new System.Drawing.Size(106, 20);
            this.afterDate_DTP.TabIndex = 67;
            this.afterDate_DTP.ValueChanged += new System.EventHandler(this.afterDate_DTP_ValueChanged);
            // 
            // edit_dept_label
            // 
            this.edit_dept_label.AutoSize = true;
            this.edit_dept_label.Location = new System.Drawing.Point(253, 60);
            this.edit_dept_label.Name = "edit_dept_label";
            this.edit_dept_label.Size = new System.Drawing.Size(29, 13);
            this.edit_dept_label.TabIndex = 71;
            this.edit_dept_label.Text = "After";
            // 
            // dest_combobox
            // 
            this.dest_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dest_combobox.Enabled = false;
            this.dest_combobox.FormattingEnabled = true;
            this.dest_combobox.Location = new System.Drawing.Point(76, 84);
            this.dest_combobox.Name = "dest_combobox";
            this.dest_combobox.Size = new System.Drawing.Size(121, 21);
            this.dest_combobox.TabIndex = 66;
            this.dest_combobox.SelectedIndexChanged += new System.EventHandler(this.dest_combobox_SelectedIndexChanged);
            // 
            // edit_dest_label
            // 
            this.edit_dest_label.AutoSize = true;
            this.edit_dest_label.Location = new System.Drawing.Point(12, 87);
            this.edit_dest_label.Name = "edit_dest_label";
            this.edit_dest_label.Size = new System.Drawing.Size(60, 13);
            this.edit_dest_label.TabIndex = 70;
            this.edit_dest_label.Text = "Destination";
            // 
            // origin_combobox
            // 
            this.origin_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origin_combobox.Enabled = false;
            this.origin_combobox.FormattingEnabled = true;
            this.origin_combobox.Location = new System.Drawing.Point(76, 52);
            this.origin_combobox.Name = "origin_combobox";
            this.origin_combobox.Size = new System.Drawing.Size(121, 21);
            this.origin_combobox.TabIndex = 65;
            this.origin_combobox.SelectedIndexChanged += new System.EventHandler(this.origin_combobox_SelectedIndexChanged);
            // 
            // edit_origin_label
            // 
            this.edit_origin_label.AutoSize = true;
            this.edit_origin_label.Location = new System.Drawing.Point(12, 60);
            this.edit_origin_label.Name = "edit_origin_label";
            this.edit_origin_label.Size = new System.Drawing.Size(34, 13);
            this.edit_origin_label.TabIndex = 69;
            this.edit_origin_label.Text = "Origin";
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(627, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 30;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // manifest_groupbox
            // 
            this.manifest_groupbox.Controls.Add(this.manifest_datagridview);
            this.manifest_groupbox.Controls.Add(this.single_arrivalDate_label);
            this.manifest_groupbox.Controls.Add(this.single_depDate_label);
            this.manifest_groupbox.Controls.Add(this.single_destCode_label);
            this.manifest_groupbox.Controls.Add(this.single_originCode_label);
            this.manifest_groupbox.Controls.Add(this.single_flightID_label);
            this.manifest_groupbox.Controls.Add(this.label13);
            this.manifest_groupbox.Controls.Add(this.label10);
            this.manifest_groupbox.Controls.Add(this.label9);
            this.manifest_groupbox.Controls.Add(this.label8);
            this.manifest_groupbox.Controls.Add(this.label24);
            this.manifest_groupbox.Controls.Add(this.manifest_close_button);
            this.manifest_groupbox.Location = new System.Drawing.Point(22, 49);
            this.manifest_groupbox.Name = "manifest_groupbox";
            this.manifest_groupbox.Size = new System.Drawing.Size(669, 548);
            this.manifest_groupbox.TabIndex = 78;
            this.manifest_groupbox.TabStop = false;
            this.manifest_groupbox.Text = "Flight Manifest";
            // 
            // manifest_datagridview
            // 
            this.manifest_datagridview.AllowUserToAddRows = false;
            this.manifest_datagridview.AllowUserToDeleteRows = false;
            this.manifest_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manifest_datagridview.Location = new System.Drawing.Point(15, 103);
            this.manifest_datagridview.Name = "manifest_datagridview";
            this.manifest_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.manifest_datagridview.Size = new System.Drawing.Size(640, 430);
            this.manifest_datagridview.TabIndex = 34;
            // 
            // single_arrivalDate_label
            // 
            this.single_arrivalDate_label.AutoSize = true;
            this.single_arrivalDate_label.Location = new System.Drawing.Point(197, 69);
            this.single_arrivalDate_label.Name = "single_arrivalDate_label";
            this.single_arrivalDate_label.Size = new System.Drawing.Size(10, 13);
            this.single_arrivalDate_label.TabIndex = 33;
            this.single_arrivalDate_label.Text = "-";
            // 
            // single_depDate_label
            // 
            this.single_depDate_label.AutoSize = true;
            this.single_depDate_label.Location = new System.Drawing.Point(197, 46);
            this.single_depDate_label.Name = "single_depDate_label";
            this.single_depDate_label.Size = new System.Drawing.Size(10, 13);
            this.single_depDate_label.TabIndex = 32;
            this.single_depDate_label.Text = "-";
            // 
            // single_destCode_label
            // 
            this.single_destCode_label.AutoSize = true;
            this.single_destCode_label.Location = new System.Drawing.Point(58, 69);
            this.single_destCode_label.Name = "single_destCode_label";
            this.single_destCode_label.Size = new System.Drawing.Size(10, 13);
            this.single_destCode_label.TabIndex = 31;
            this.single_destCode_label.Text = "-";
            // 
            // single_originCode_label
            // 
            this.single_originCode_label.AutoSize = true;
            this.single_originCode_label.Location = new System.Drawing.Point(58, 46);
            this.single_originCode_label.Name = "single_originCode_label";
            this.single_originCode_label.Size = new System.Drawing.Size(10, 13);
            this.single_originCode_label.TabIndex = 30;
            this.single_originCode_label.Text = "-";
            // 
            // single_flightID_label
            // 
            this.single_flightID_label.AutoSize = true;
            this.single_flightID_label.Location = new System.Drawing.Point(58, 24);
            this.single_flightID_label.Name = "single_flightID_label";
            this.single_flightID_label.Size = new System.Drawing.Size(10, 13);
            this.single_flightID_label.TabIndex = 29;
            this.single_flightID_label.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Arrival";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Departure";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "From";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "Flight ID";
            // 
            // manifest_close_button
            // 
            this.manifest_close_button.Location = new System.Drawing.Point(567, 19);
            this.manifest_close_button.Name = "manifest_close_button";
            this.manifest_close_button.Size = new System.Drawing.Size(88, 23);
            this.manifest_close_button.TabIndex = 2;
            this.manifest_close_button.Text = "Close Manifest";
            this.manifest_close_button.UseVisualStyleBackColor = true;
            this.manifest_close_button.Click += new System.EventHandler(this.manifest_close_button_Click);
            // 
            // FlightManLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 609);
            this.Controls.Add(this.flight_search_groupbox);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.flightman_welcome_label);
            this.Controls.Add(this.manifest_groupbox);
            this.Name = "FlightManLandingPage";
            this.Text = "FlightManLandingPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightManLandingPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.flights_dataview)).EndInit();
            this.flight_search_groupbox.ResumeLayout(false);
            this.flight_search_groupbox.PerformLayout();
            this.manifest_groupbox.ResumeLayout(false);
            this.manifest_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manifest_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView flights_dataview;
        private System.Windows.Forms.Label flightman_welcome_label;
        private System.Windows.Forms.Button printManifest_btn;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.GroupBox flight_search_groupbox;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.CheckBox date_before_checkbox;
        private System.Windows.Forms.CheckBox date_after_checkbox;
        private System.Windows.Forms.CheckBox date_checkbox;
        private System.Windows.Forms.CheckBox origin_dest_checkbox;
        private System.Windows.Forms.Button clearSort_button;
        private System.Windows.Forms.DateTimePicker beforeDate_DTP;
        private System.Windows.Forms.Label edit_arrival_label;
        private System.Windows.Forms.DateTimePicker afterDate_DTP;
        private System.Windows.Forms.Label edit_dept_label;
        private System.Windows.Forms.ComboBox dest_combobox;
        private System.Windows.Forms.Label edit_dest_label;
        private System.Windows.Forms.ComboBox origin_combobox;
        private System.Windows.Forms.Label edit_origin_label;
        private System.Windows.Forms.GroupBox manifest_groupbox;
        private System.Windows.Forms.Button manifest_close_button;
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
        private System.Windows.Forms.DataGridView manifest_datagridview;
    }
}