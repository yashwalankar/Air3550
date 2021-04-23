
namespace Air3550
{
    partial class UserLandingPage
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.userID_label = new System.Windows.Forms.Label();
            this.rewardBalance_label = new System.Windows.Forms.Label();
            this.userId_value_label = new System.Windows.Forms.Label();
            this.rewardBalance_value_label = new System.Windows.Forms.Label();
            this.bookFlights_btn = new System.Windows.Forms.Button();
            this.upComingFlights_btn = new System.Windows.Forms.Button();
            this.pastFlights_btn = new System.Windows.Forms.Button();
            this.pastFlights_groupBox = new System.Windows.Forms.GroupBox();
            this.upcomingFlights_groupBox = new System.Windows.Forms.GroupBox();
            this.upcomingFlights_datagridview = new System.Windows.Forms.DataGridView();
            this.bookFlights_groupBox = new System.Windows.Forms.GroupBox();
            this.returnDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.returnDate_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oneWay_rBtn = new System.Windows.Forms.RadioButton();
            this.return_rBtn = new System.Windows.Forms.RadioButton();
            this.origin_label = new System.Windows.Forms.Label();
            this.deptDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.destination_label = new System.Windows.Forms.Label();
            this.destination_comboBox = new System.Windows.Forms.ComboBox();
            this.origin_comboBox = new System.Windows.Forms.ComboBox();
            this.departureDate_label = new System.Windows.Forms.Label();
            this.currSysTime_DTP = new System.Windows.Forms.DateTimePicker();
            this.currSysTime_label = new System.Windows.Forms.Label();
            this.rewardUsed_label = new System.Windows.Forms.Label();
            this.rewardUsedValue_label = new System.Windows.Forms.Label();
            this.showFlights_btn = new System.Windows.Forms.Button();
            this.upcomingFlights_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingFlights_datagridview)).BeginInit();
            this.bookFlights_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(745, 13);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 23);
            this.logout_button.TabIndex = 11;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(58, 43);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(55, 13);
            this.welcome_label.TabIndex = 12;
            this.welcome_label.Text = "Welcome,";
            // 
            // userID_label
            // 
            this.userID_label.AutoSize = true;
            this.userID_label.Location = new System.Drawing.Point(690, 43);
            this.userID_label.Name = "userID_label";
            this.userID_label.Size = new System.Drawing.Size(46, 13);
            this.userID_label.TabIndex = 13;
            this.userID_label.Text = "User ID:";
            // 
            // rewardBalance_label
            // 
            this.rewardBalance_label.AutoSize = true;
            this.rewardBalance_label.Location = new System.Drawing.Point(647, 65);
            this.rewardBalance_label.Name = "rewardBalance_label";
            this.rewardBalance_label.Size = new System.Drawing.Size(89, 13);
            this.rewardBalance_label.TabIndex = 14;
            this.rewardBalance_label.Text = "Reward Balance:";
            // 
            // userId_value_label
            // 
            this.userId_value_label.AutoSize = true;
            this.userId_value_label.Location = new System.Drawing.Point(742, 43);
            this.userId_value_label.Name = "userId_value_label";
            this.userId_value_label.Size = new System.Drawing.Size(37, 13);
            this.userId_value_label.TabIndex = 15;
            this.userId_value_label.Text = "_____";
            // 
            // rewardBalance_value_label
            // 
            this.rewardBalance_value_label.AutoSize = true;
            this.rewardBalance_value_label.Location = new System.Drawing.Point(742, 65);
            this.rewardBalance_value_label.Name = "rewardBalance_value_label";
            this.rewardBalance_value_label.Size = new System.Drawing.Size(37, 13);
            this.rewardBalance_value_label.TabIndex = 16;
            this.rewardBalance_value_label.Text = "_____";
            // 
            // bookFlights_btn
            // 
            this.bookFlights_btn.Location = new System.Drawing.Point(46, 126);
            this.bookFlights_btn.Name = "bookFlights_btn";
            this.bookFlights_btn.Size = new System.Drawing.Size(104, 23);
            this.bookFlights_btn.TabIndex = 17;
            this.bookFlights_btn.Text = "Book Flight";
            this.bookFlights_btn.UseVisualStyleBackColor = true;
            this.bookFlights_btn.Click += new System.EventHandler(this.bookFlights_btn_Click);
            // 
            // upComingFlights_btn
            // 
            this.upComingFlights_btn.Location = new System.Drawing.Point(170, 126);
            this.upComingFlights_btn.Name = "upComingFlights_btn";
            this.upComingFlights_btn.Size = new System.Drawing.Size(104, 23);
            this.upComingFlights_btn.TabIndex = 18;
            this.upComingFlights_btn.Text = "Upcoming Flights";
            this.upComingFlights_btn.UseVisualStyleBackColor = true;
            this.upComingFlights_btn.Click += new System.EventHandler(this.upComingFlights_btn_Click);
            // 
            // pastFlights_btn
            // 
            this.pastFlights_btn.Location = new System.Drawing.Point(745, 126);
            this.pastFlights_btn.Name = "pastFlights_btn";
            this.pastFlights_btn.Size = new System.Drawing.Size(75, 23);
            this.pastFlights_btn.TabIndex = 19;
            this.pastFlights_btn.Text = "Past Flights";
            this.pastFlights_btn.UseVisualStyleBackColor = true;
            this.pastFlights_btn.Click += new System.EventHandler(this.pastFlights_btn_Click);
            // 
            // pastFlights_groupBox
            // 
            this.pastFlights_groupBox.Location = new System.Drawing.Point(46, 155);
            this.pastFlights_groupBox.Name = "pastFlights_groupBox";
            this.pastFlights_groupBox.Size = new System.Drawing.Size(774, 305);
            this.pastFlights_groupBox.TabIndex = 20;
            this.pastFlights_groupBox.TabStop = false;
            this.pastFlights_groupBox.Text = "Past Flights";
            // 
            // upcomingFlights_groupBox
            // 
            this.upcomingFlights_groupBox.Controls.Add(this.upcomingFlights_datagridview);
            this.upcomingFlights_groupBox.Location = new System.Drawing.Point(46, 155);
            this.upcomingFlights_groupBox.Name = "upcomingFlights_groupBox";
            this.upcomingFlights_groupBox.Size = new System.Drawing.Size(774, 324);
            this.upcomingFlights_groupBox.TabIndex = 21;
            this.upcomingFlights_groupBox.TabStop = false;
            this.upcomingFlights_groupBox.Text = "Upcoming Flights";
            // 
            // upcomingFlights_datagridview
            // 
            this.upcomingFlights_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcomingFlights_datagridview.Location = new System.Drawing.Point(15, 19);
            this.upcomingFlights_datagridview.Name = "upcomingFlights_datagridview";
            this.upcomingFlights_datagridview.Size = new System.Drawing.Size(463, 286);
            this.upcomingFlights_datagridview.TabIndex = 0;
            // 
            // bookFlights_groupBox
            // 
            this.bookFlights_groupBox.Controls.Add(this.showFlights_btn);
            this.bookFlights_groupBox.Controls.Add(this.returnDate_dtp);
            this.bookFlights_groupBox.Controls.Add(this.returnDate_label);
            this.bookFlights_groupBox.Controls.Add(this.groupBox1);
            this.bookFlights_groupBox.Controls.Add(this.origin_label);
            this.bookFlights_groupBox.Controls.Add(this.deptDate_dtp);
            this.bookFlights_groupBox.Controls.Add(this.destination_label);
            this.bookFlights_groupBox.Controls.Add(this.destination_comboBox);
            this.bookFlights_groupBox.Controls.Add(this.origin_comboBox);
            this.bookFlights_groupBox.Controls.Add(this.departureDate_label);
            this.bookFlights_groupBox.Location = new System.Drawing.Point(46, 155);
            this.bookFlights_groupBox.Name = "bookFlights_groupBox";
            this.bookFlights_groupBox.Size = new System.Drawing.Size(774, 324);
            this.bookFlights_groupBox.TabIndex = 22;
            this.bookFlights_groupBox.TabStop = false;
            this.bookFlights_groupBox.Text = "Book Flight";
            this.bookFlights_groupBox.Enter += new System.EventHandler(this.bookFlights_groupBox_Enter);
            // 
            // returnDate_dtp
            // 
            this.returnDate_dtp.CustomFormat = "yyyy/MM/dd - h:mm tt";
            this.returnDate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDate_dtp.Location = new System.Drawing.Point(413, 90);
            this.returnDate_dtp.Name = "returnDate_dtp";
            this.returnDate_dtp.Size = new System.Drawing.Size(152, 20);
            this.returnDate_dtp.TabIndex = 34;
            // 
            // returnDate_label
            // 
            this.returnDate_label.AutoSize = true;
            this.returnDate_label.Location = new System.Drawing.Point(410, 73);
            this.returnDate_label.Name = "returnDate_label";
            this.returnDate_label.Size = new System.Drawing.Size(39, 13);
            this.returnDate_label.TabIndex = 33;
            this.returnDate_label.Text = "Return";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oneWay_rBtn);
            this.groupBox1.Controls.Add(this.return_rBtn);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 39);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trip Type";
            // 
            // oneWay_rBtn
            // 
            this.oneWay_rBtn.AutoSize = true;
            this.oneWay_rBtn.Checked = true;
            this.oneWay_rBtn.Location = new System.Drawing.Point(9, 16);
            this.oneWay_rBtn.Name = "oneWay_rBtn";
            this.oneWay_rBtn.Size = new System.Drawing.Size(70, 17);
            this.oneWay_rBtn.TabIndex = 30;
            this.oneWay_rBtn.TabStop = true;
            this.oneWay_rBtn.Text = "One-Way";
            this.oneWay_rBtn.UseVisualStyleBackColor = true;
            this.oneWay_rBtn.CheckedChanged += new System.EventHandler(this.oneWay_rBtn_CheckedChanged);
            // 
            // return_rBtn
            // 
            this.return_rBtn.AutoSize = true;
            this.return_rBtn.Location = new System.Drawing.Point(85, 16);
            this.return_rBtn.Name = "return_rBtn";
            this.return_rBtn.Size = new System.Drawing.Size(57, 17);
            this.return_rBtn.TabIndex = 31;
            this.return_rBtn.TabStop = true;
            this.return_rBtn.Text = "Return";
            this.return_rBtn.UseVisualStyleBackColor = true;
            this.return_rBtn.CheckedChanged += new System.EventHandler(this.return_rbtn_CheckedChanged);
            // 
            // origin_label
            // 
            this.origin_label.AutoSize = true;
            this.origin_label.Location = new System.Drawing.Point(5, 73);
            this.origin_label.Name = "origin_label";
            this.origin_label.Size = new System.Drawing.Size(34, 13);
            this.origin_label.TabIndex = 27;
            this.origin_label.Text = "Origin";
            // 
            // deptDate_dtp
            // 
            this.deptDate_dtp.CustomFormat = "yyyy/MM/dd - h:mm tt";
            this.deptDate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deptDate_dtp.Location = new System.Drawing.Point(246, 90);
            this.deptDate_dtp.Name = "deptDate_dtp";
            this.deptDate_dtp.Size = new System.Drawing.Size(161, 20);
            this.deptDate_dtp.TabIndex = 27;
            this.deptDate_dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // destination_label
            // 
            this.destination_label.AutoSize = true;
            this.destination_label.Location = new System.Drawing.Point(128, 73);
            this.destination_label.Name = "destination_label";
            this.destination_label.Size = new System.Drawing.Size(60, 13);
            this.destination_label.TabIndex = 28;
            this.destination_label.Text = "Destination";
            // 
            // destination_comboBox
            // 
            this.destination_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destination_comboBox.FormattingEnabled = true;
            this.destination_comboBox.Location = new System.Drawing.Point(131, 89);
            this.destination_comboBox.Name = "destination_comboBox";
            this.destination_comboBox.Size = new System.Drawing.Size(99, 21);
            this.destination_comboBox.TabIndex = 28;
            // 
            // origin_comboBox
            // 
            this.origin_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origin_comboBox.FormattingEnabled = true;
            this.origin_comboBox.Location = new System.Drawing.Point(8, 89);
            this.origin_comboBox.Name = "origin_comboBox";
            this.origin_comboBox.Size = new System.Drawing.Size(96, 21);
            this.origin_comboBox.TabIndex = 27;
            // 
            // departureDate_label
            // 
            this.departureDate_label.AutoSize = true;
            this.departureDate_label.Location = new System.Drawing.Point(243, 73);
            this.departureDate_label.Name = "departureDate_label";
            this.departureDate_label.Size = new System.Drawing.Size(54, 13);
            this.departureDate_label.TabIndex = 29;
            this.departureDate_label.Text = "Departure";
            // 
            // currSysTime_DTP
            // 
            this.currSysTime_DTP.CustomFormat = "yyyy/MM/dd - hh:mm tt";
            this.currSysTime_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.currSysTime_DTP.Location = new System.Drawing.Point(119, 13);
            this.currSysTime_DTP.Name = "currSysTime_DTP";
            this.currSysTime_DTP.Size = new System.Drawing.Size(155, 20);
            this.currSysTime_DTP.TabIndex = 24;
            // 
            // currSysTime_label
            // 
            this.currSysTime_label.AutoSize = true;
            this.currSysTime_label.Location = new System.Drawing.Point(43, 18);
            this.currSysTime_label.Name = "currSysTime_label";
            this.currSysTime_label.Size = new System.Drawing.Size(70, 13);
            this.currSysTime_label.TabIndex = 23;
            this.currSysTime_label.Text = "System Time:";
            // 
            // rewardUsed_label
            // 
            this.rewardUsed_label.AutoSize = true;
            this.rewardUsed_label.Location = new System.Drawing.Point(661, 78);
            this.rewardUsed_label.Name = "rewardUsed_label";
            this.rewardUsed_label.Size = new System.Drawing.Size(75, 13);
            this.rewardUsed_label.TabIndex = 25;
            this.rewardUsed_label.Text = "Reward Used:";
            // 
            // rewardUsedValue_label
            // 
            this.rewardUsedValue_label.AutoSize = true;
            this.rewardUsedValue_label.Location = new System.Drawing.Point(742, 78);
            this.rewardUsedValue_label.Name = "rewardUsedValue_label";
            this.rewardUsedValue_label.Size = new System.Drawing.Size(37, 13);
            this.rewardUsedValue_label.TabIndex = 26;
            this.rewardUsedValue_label.Text = "_____";
            // 
            // showFlights_btn
            // 
            this.showFlights_btn.Location = new System.Drawing.Point(618, 87);
            this.showFlights_btn.Name = "showFlights_btn";
            this.showFlights_btn.Size = new System.Drawing.Size(104, 23);
            this.showFlights_btn.TabIndex = 27;
            this.showFlights_btn.Text = "Show Flights";
            this.showFlights_btn.UseVisualStyleBackColor = true;
            this.showFlights_btn.Click += new System.EventHandler(this.showFlights_btn_Click);
            // 
            // UserLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 505);
            this.Controls.Add(this.rewardUsedValue_label);
            this.Controls.Add(this.rewardUsed_label);
            this.Controls.Add(this.currSysTime_DTP);
            this.Controls.Add(this.currSysTime_label);
            this.Controls.Add(this.pastFlights_btn);
            this.Controls.Add(this.upComingFlights_btn);
            this.Controls.Add(this.bookFlights_btn);
            this.Controls.Add(this.rewardBalance_value_label);
            this.Controls.Add(this.userId_value_label);
            this.Controls.Add(this.rewardBalance_label);
            this.Controls.Add(this.userID_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.bookFlights_groupBox);
            this.Controls.Add(this.upcomingFlights_groupBox);
            this.Controls.Add(this.pastFlights_groupBox);
            this.Name = "UserLandingPage";
            this.Text = "UserLandingPage";
            this.upcomingFlights_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upcomingFlights_datagridview)).EndInit();
            this.bookFlights_groupBox.ResumeLayout(false);
            this.bookFlights_groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label userID_label;
        private System.Windows.Forms.Label rewardBalance_label;
        private System.Windows.Forms.Label userId_value_label;
        private System.Windows.Forms.Label rewardBalance_value_label;
        private System.Windows.Forms.Button bookFlights_btn;
        private System.Windows.Forms.Button upComingFlights_btn;
        private System.Windows.Forms.Button pastFlights_btn;
        private System.Windows.Forms.GroupBox pastFlights_groupBox;
        private System.Windows.Forms.GroupBox upcomingFlights_groupBox;
        private System.Windows.Forms.GroupBox bookFlights_groupBox;
        private System.Windows.Forms.DateTimePicker currSysTime_DTP;
        private System.Windows.Forms.Label currSysTime_label;
        private System.Windows.Forms.Label rewardUsed_label;
        private System.Windows.Forms.Label rewardUsedValue_label;
        private System.Windows.Forms.DataGridView upcomingFlights_datagridview;
        private System.Windows.Forms.ComboBox origin_comboBox;
        private System.Windows.Forms.ComboBox destination_comboBox;
        private System.Windows.Forms.Label departureDate_label;
        private System.Windows.Forms.Label destination_label;
        private System.Windows.Forms.Label origin_label;
        private System.Windows.Forms.DateTimePicker deptDate_dtp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton oneWay_rBtn;
        private System.Windows.Forms.RadioButton return_rBtn;
        private System.Windows.Forms.Label returnDate_label;
        private System.Windows.Forms.DateTimePicker returnDate_dtp;
        private System.Windows.Forms.Button showFlights_btn;
    }
}