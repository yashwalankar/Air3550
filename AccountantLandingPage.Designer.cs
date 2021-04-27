
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
            ((System.ComponentModel.ISupportInitialize)(this.flights_dataview)).BeginInit();
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
            this.flights_dataview.Location = new System.Drawing.Point(35, 238);
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
            this.clearSort_button.Location = new System.Drawing.Point(96, 156);
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
            this.beforeDate_DTP.Location = new System.Drawing.Point(342, 124);
            this.beforeDate_DTP.Name = "beforeDate_DTP";
            this.beforeDate_DTP.Size = new System.Drawing.Size(106, 20);
            this.beforeDate_DTP.TabIndex = 45;
            this.beforeDate_DTP.ValueChanged += new System.EventHandler(this.beforeDate_DTP_ValueChanged);
            // 
            // edit_arrival_label
            // 
            this.edit_arrival_label.AutoSize = true;
            this.edit_arrival_label.Location = new System.Drawing.Point(273, 126);
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
            this.afterDate_DTP.Location = new System.Drawing.Point(342, 93);
            this.afterDate_DTP.Name = "afterDate_DTP";
            this.afterDate_DTP.Size = new System.Drawing.Size(106, 20);
            this.afterDate_DTP.TabIndex = 44;
            this.afterDate_DTP.ValueChanged += new System.EventHandler(this.afterDate_DTP_ValueChanged);
            // 
            // edit_dept_label
            // 
            this.edit_dept_label.AutoSize = true;
            this.edit_dept_label.Location = new System.Drawing.Point(273, 99);
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
            this.dest_combobox.Location = new System.Drawing.Point(96, 123);
            this.dest_combobox.Name = "dest_combobox";
            this.dest_combobox.Size = new System.Drawing.Size(121, 21);
            this.dest_combobox.TabIndex = 43;
            this.dest_combobox.SelectedIndexChanged += new System.EventHandler(this.dest_combobox_SelectedIndexChanged);
            // 
            // edit_dest_label
            // 
            this.edit_dest_label.AutoSize = true;
            this.edit_dest_label.Location = new System.Drawing.Point(32, 126);
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
            this.origin_combobox.Location = new System.Drawing.Point(96, 91);
            this.origin_combobox.Name = "origin_combobox";
            this.origin_combobox.Size = new System.Drawing.Size(121, 21);
            this.origin_combobox.TabIndex = 42;
            this.origin_combobox.SelectedIndexChanged += new System.EventHandler(this.origin_combobox_SelectedIndexChanged);
            // 
            // edit_origin_label
            // 
            this.edit_origin_label.AutoSize = true;
            this.edit_origin_label.Location = new System.Drawing.Point(32, 99);
            this.edit_origin_label.Name = "edit_origin_label";
            this.edit_origin_label.Size = new System.Drawing.Size(34, 13);
            this.edit_origin_label.TabIndex = 46;
            this.edit_origin_label.Text = "Origin";
            // 
            // origin_dest_checkbox
            // 
            this.origin_dest_checkbox.AutoSize = true;
            this.origin_dest_checkbox.Location = new System.Drawing.Point(35, 67);
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
            this.date_checkbox.Location = new System.Drawing.Point(276, 67);
            this.date_checkbox.Name = "date_checkbox";
            this.date_checkbox.Size = new System.Drawing.Size(147, 17);
            this.date_checkbox.TabIndex = 54;
            this.date_checkbox.Text = "Only include flights dated:";
            this.date_checkbox.UseVisualStyleBackColor = true;
            this.date_checkbox.CheckedChanged += new System.EventHandler(this.date_checkbox_CheckedChanged);
            // 
            // generate_submit_button
            // 
            this.generate_submit_button.Location = new System.Drawing.Point(554, 211);
            this.generate_submit_button.Name = "generate_submit_button";
            this.generate_submit_button.Size = new System.Drawing.Size(121, 21);
            this.generate_submit_button.TabIndex = 60;
            this.generate_submit_button.Text = "Generate Report";
            this.generate_submit_button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "To generate report for specific flight sort with above criteria and double click " +
    "specific flight below.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "To generate report using above criteria use \"Generate Report\" button.";
            // 
            // date_after_checkbox
            // 
            this.date_after_checkbox.AutoSize = true;
            this.date_after_checkbox.Enabled = false;
            this.date_after_checkbox.Location = new System.Drawing.Point(321, 96);
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
            this.date_before_checkbox.Location = new System.Drawing.Point(321, 126);
            this.date_before_checkbox.Name = "date_before_checkbox";
            this.date_before_checkbox.Size = new System.Drawing.Size(15, 14);
            this.date_before_checkbox.TabIndex = 64;
            this.date_before_checkbox.UseVisualStyleBackColor = true;
            this.date_before_checkbox.CheckedChanged += new System.EventHandler(this.date_before_checkbox_CheckedChanged);
            // 
            // AccountantLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 609);
            this.Controls.Add(this.date_before_checkbox);
            this.Controls.Add(this.date_after_checkbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generate_submit_button);
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
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flights_dataview);
            this.Controls.Add(this.logout_button);
            this.Name = "AccountantLandingPage";
            this.Text = "Accountant Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountantLandingPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.flights_dataview)).EndInit();
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
    }
}