
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
            this.bookFlights_groupBox = new System.Windows.Forms.GroupBox();
            this.currSysTime_DTP = new System.Windows.Forms.DateTimePicker();
            this.currSysTime_label = new System.Windows.Forms.Label();
            this.rewardUsed_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upcomingFlights_datagridview = new System.Windows.Forms.DataGridView();
            this.upcomingFlights_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingFlights_datagridview)).BeginInit();
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
            // bookFlights_groupBox
            // 
            this.bookFlights_groupBox.Location = new System.Drawing.Point(46, 155);
            this.bookFlights_groupBox.Name = "bookFlights_groupBox";
            this.bookFlights_groupBox.Size = new System.Drawing.Size(774, 324);
            this.bookFlights_groupBox.TabIndex = 22;
            this.bookFlights_groupBox.TabStop = false;
            this.bookFlights_groupBox.Text = "Book Flight";
            // 
            // currSysTime_DTP
            // 
            this.currSysTime_DTP.CustomFormat = "yyyy/MM/dd - hh:mm tt";
            this.currSysTime_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.currSysTime_DTP.Location = new System.Drawing.Point(119, 13);
            this.currSysTime_DTP.Name = "currSysTime_DTP";
            this.currSysTime_DTP.Size = new System.Drawing.Size(133, 20);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "_____";
            // 
            // upcomingFlights_datagridview
            // 
            this.upcomingFlights_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcomingFlights_datagridview.Location = new System.Drawing.Point(15, 19);
            this.upcomingFlights_datagridview.Name = "upcomingFlights_datagridview";
            this.upcomingFlights_datagridview.Size = new System.Drawing.Size(463, 286);
            this.upcomingFlights_datagridview.TabIndex = 0;
            // 
            // UserLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 505);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.upcomingFlights_groupBox);
            this.Controls.Add(this.pastFlights_groupBox);
            this.Controls.Add(this.bookFlights_groupBox);
            this.Name = "UserLandingPage";
            this.Text = "UserLandingPage";
            this.upcomingFlights_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upcomingFlights_datagridview)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView upcomingFlights_datagridview;
    }
}