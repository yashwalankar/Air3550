
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
            ((System.ComponentModel.ISupportInitialize)(this.marketing_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.air3550DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // marketingManger_welcome_label
            // 
            this.marketingManger_welcome_label.AutoSize = true;
            this.marketingManger_welcome_label.Location = new System.Drawing.Point(30, 22);
            this.marketingManger_welcome_label.Name = "marketingManger_welcome_label";
            this.marketingManger_welcome_label.Size = new System.Drawing.Size(144, 13);
            this.marketingManger_welcome_label.TabIndex = 0;
            this.marketingManger_welcome_label.Text = "Welcome, Marketing Manger";
            // 
            // marketing_datagrid
            // 
            this.marketing_datagrid.AllowUserToAddRows = false;
            this.marketing_datagrid.AllowUserToDeleteRows = false;
            this.marketing_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marketing_datagrid.Location = new System.Drawing.Point(12, 290);
            this.marketing_datagrid.Name = "marketing_datagrid";
            this.marketing_datagrid.ReadOnly = true;
            this.marketing_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marketing_datagrid.Size = new System.Drawing.Size(690, 307);
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
            this.selectedFlight_label.Location = new System.Drawing.Point(9, 55);
            this.selectedFlight_label.Name = "selectedFlight_label";
            this.selectedFlight_label.Size = new System.Drawing.Size(80, 13);
            this.selectedFlight_label.TabIndex = 2;
            this.selectedFlight_label.Text = "Selected Flight:";
            // 
            // planesModels_comboBox
            // 
            this.planesModels_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.planesModels_comboBox.FormattingEnabled = true;
            this.planesModels_comboBox.Location = new System.Drawing.Point(573, 52);
            this.planesModels_comboBox.Name = "planesModels_comboBox";
            this.planesModels_comboBox.Size = new System.Drawing.Size(121, 21);
            this.planesModels_comboBox.TabIndex = 3;
            this.planesModels_comboBox.SelectedIndexChanged += new System.EventHandler(this.planesModels_comboBox_SelectedIndexChanged);
            // 
            // currPlane_label
            // 
            this.currPlane_label.AutoSize = true;
            this.currPlane_label.Location = new System.Drawing.Point(253, 81);
            this.currPlane_label.Name = "currPlane_label";
            this.currPlane_label.Size = new System.Drawing.Size(74, 13);
            this.currPlane_label.TabIndex = 4;
            this.currPlane_label.Text = "Current Plane:";
            // 
            // curr_capacity_label
            // 
            this.curr_capacity_label.AutoSize = true;
            this.curr_capacity_label.Location = new System.Drawing.Point(253, 107);
            this.curr_capacity_label.Name = "curr_capacity_label";
            this.curr_capacity_label.Size = new System.Drawing.Size(74, 13);
            this.curr_capacity_label.TabIndex = 5;
            this.curr_capacity_label.Text = "Max Capacity:";
            // 
            // new_capacity_label
            // 
            this.new_capacity_label.AutoSize = true;
            this.new_capacity_label.Location = new System.Drawing.Point(468, 82);
            this.new_capacity_label.Name = "new_capacity_label";
            this.new_capacity_label.Size = new System.Drawing.Size(99, 13);
            this.new_capacity_label.TabIndex = 7;
            this.new_capacity_label.Text = "New Max Capacity:";
            // 
            // set_plane_label
            // 
            this.set_plane_label.AutoSize = true;
            this.set_plane_label.Location = new System.Drawing.Point(468, 55);
            this.set_plane_label.Name = "set_plane_label";
            this.set_plane_label.Size = new System.Drawing.Size(56, 13);
            this.set_plane_label.TabIndex = 6;
            this.set_plane_label.Text = "Set Plane:";
            // 
            // updatePlane_btn
            // 
            this.updatePlane_btn.Location = new System.Drawing.Point(573, 106);
            this.updatePlane_btn.Name = "updatePlane_btn";
            this.updatePlane_btn.Size = new System.Drawing.Size(126, 23);
            this.updatePlane_btn.TabIndex = 8;
            this.updatePlane_btn.Text = "Update Plane";
            this.updatePlane_btn.UseVisualStyleBackColor = true;
            this.updatePlane_btn.Click += new System.EventHandler(this.updatePlane_btn_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(713, 12);
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
            this.selFlightValue_textbox.Location = new System.Drawing.Point(95, 78);
            this.selFlightValue_textbox.Name = "selFlightValue_textbox";
            this.selFlightValue_textbox.ReadOnly = true;
            this.selFlightValue_textbox.Size = new System.Drawing.Size(121, 20);
            this.selFlightValue_textbox.TabIndex = 11;
            // 
            // currPlane_textbox
            // 
            this.currPlane_textbox.Enabled = false;
            this.currPlane_textbox.Location = new System.Drawing.Point(339, 78);
            this.currPlane_textbox.Name = "currPlane_textbox";
            this.currPlane_textbox.ReadOnly = true;
            this.currPlane_textbox.Size = new System.Drawing.Size(70, 20);
            this.currPlane_textbox.TabIndex = 12;
            // 
            // curr_maxCapacity_textbox
            // 
            this.curr_maxCapacity_textbox.Enabled = false;
            this.curr_maxCapacity_textbox.Location = new System.Drawing.Point(339, 104);
            this.curr_maxCapacity_textbox.Name = "curr_maxCapacity_textbox";
            this.curr_maxCapacity_textbox.ReadOnly = true;
            this.curr_maxCapacity_textbox.Size = new System.Drawing.Size(70, 20);
            this.curr_maxCapacity_textbox.TabIndex = 13;
            // 
            // newCapacityValue_textBox
            // 
            this.newCapacityValue_textBox.Enabled = false;
            this.newCapacityValue_textBox.Location = new System.Drawing.Point(573, 79);
            this.newCapacityValue_textBox.Name = "newCapacityValue_textBox";
            this.newCapacityValue_textBox.ReadOnly = true;
            this.newCapacityValue_textBox.Size = new System.Drawing.Size(70, 20);
            this.newCapacityValue_textBox.TabIndex = 14;
            // 
            // selFlightId_textbox
            // 
            this.selFlightId_textbox.Enabled = false;
            this.selFlightId_textbox.Location = new System.Drawing.Point(95, 52);
            this.selFlightId_textbox.Name = "selFlightId_textbox";
            this.selFlightId_textbox.ReadOnly = true;
            this.selFlightId_textbox.Size = new System.Drawing.Size(70, 20);
            this.selFlightId_textbox.TabIndex = 15;
            // 
            // filledCapacity_label
            // 
            this.filledCapacity_label.AutoSize = true;
            this.filledCapacity_label.Location = new System.Drawing.Point(253, 55);
            this.filledCapacity_label.Name = "filledCapacity_label";
            this.filledCapacity_label.Size = new System.Drawing.Size(64, 13);
            this.filledCapacity_label.TabIndex = 16;
            this.filledCapacity_label.Text = "Filled Seats:";
            // 
            // filledSeatsValue_textBox
            // 
            this.filledSeatsValue_textBox.Enabled = false;
            this.filledSeatsValue_textBox.Location = new System.Drawing.Point(339, 52);
            this.filledSeatsValue_textBox.Name = "filledSeatsValue_textBox";
            this.filledSeatsValue_textBox.ReadOnly = true;
            this.filledSeatsValue_textBox.Size = new System.Drawing.Size(70, 20);
            this.filledSeatsValue_textBox.TabIndex = 17;
            // 
            // date_before_checkbox
            // 
            this.date_before_checkbox.AutoSize = true;
            this.date_before_checkbox.Enabled = false;
            this.date_before_checkbox.Location = new System.Drawing.Point(298, 212);
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
            this.date_after_checkbox.Location = new System.Drawing.Point(298, 182);
            this.date_after_checkbox.Name = "date_after_checkbox";
            this.date_after_checkbox.Size = new System.Drawing.Size(15, 14);
            this.date_after_checkbox.TabIndex = 76;
            this.date_after_checkbox.UseVisualStyleBackColor = true;
            this.date_after_checkbox.CheckedChanged += new System.EventHandler(this.date_after_checkbox_CheckedChanged);
            // 
            // date_checkbox
            // 
            this.date_checkbox.AutoSize = true;
            this.date_checkbox.Location = new System.Drawing.Point(253, 153);
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
            this.origin_dest_checkbox.Location = new System.Drawing.Point(12, 153);
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
            this.clearSort_button.Location = new System.Drawing.Point(73, 242);
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
            this.beforeDate_DTP.Location = new System.Drawing.Point(319, 210);
            this.beforeDate_DTP.Name = "beforeDate_DTP";
            this.beforeDate_DTP.Size = new System.Drawing.Size(106, 20);
            this.beforeDate_DTP.TabIndex = 68;
            this.beforeDate_DTP.ValueChanged += new System.EventHandler(this.beforeDate_DTP_ValueChanged);
            // 
            // edit_arrival_label
            // 
            this.edit_arrival_label.AutoSize = true;
            this.edit_arrival_label.Location = new System.Drawing.Point(250, 212);
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
            this.afterDate_DTP.Location = new System.Drawing.Point(319, 179);
            this.afterDate_DTP.Name = "afterDate_DTP";
            this.afterDate_DTP.Size = new System.Drawing.Size(106, 20);
            this.afterDate_DTP.TabIndex = 67;
            this.afterDate_DTP.ValueChanged += new System.EventHandler(this.afterDate_DTP_ValueChanged);
            // 
            // edit_dept_label
            // 
            this.edit_dept_label.AutoSize = true;
            this.edit_dept_label.Location = new System.Drawing.Point(250, 185);
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
            this.dest_combobox.Location = new System.Drawing.Point(73, 209);
            this.dest_combobox.Name = "dest_combobox";
            this.dest_combobox.Size = new System.Drawing.Size(121, 21);
            this.dest_combobox.TabIndex = 66;
            this.dest_combobox.SelectedIndexChanged += new System.EventHandler(this.dest_combobox_SelectedIndexChanged);
            // 
            // edit_dest_label
            // 
            this.edit_dest_label.AutoSize = true;
            this.edit_dest_label.Location = new System.Drawing.Point(9, 212);
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
            this.origin_combobox.Location = new System.Drawing.Point(73, 177);
            this.origin_combobox.Name = "origin_combobox";
            this.origin_combobox.Size = new System.Drawing.Size(121, 21);
            this.origin_combobox.TabIndex = 65;
            this.origin_combobox.SelectedIndexChanged += new System.EventHandler(this.origin_combobox_SelectedIndexChanged);
            // 
            // edit_origin_label
            // 
            this.edit_origin_label.AutoSize = true;
            this.edit_origin_label.Location = new System.Drawing.Point(9, 185);
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
            this.logout_btn.TabIndex = 68;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // MarketingLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 609);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.date_before_checkbox);
            this.Controls.Add(this.date_after_checkbox);
            this.Controls.Add(this.date_checkbox);
            this.Controls.Add(this.origin_dest_checkbox);
            this.Controls.Add(this.clearSort_button);
            this.Controls.Add(this.beforeDate_DTP);
            this.Controls.Add(this.edit_arrival_label);
            this.Controls.Add(this.afterDate_DTP);
            this.Controls.Add(this.edit_dept_label);
            this.Controls.Add(this.dest_combobox);
            this.Controls.Add(this.edit_dest_label);
            this.Controls.Add(this.origin_combobox);
            this.Controls.Add(this.edit_origin_label);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MarketingLandingPage_FormClosing);
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
        private System.Windows.Forms.Button logout_btn;
    }
}