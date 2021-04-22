
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flightman_welcome_label = new System.Windows.Forms.Label();
            this.selected_flight_label = new System.Windows.Forms.Label();
            this.printManifest_btn = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.currSysTime_DTP = new System.Windows.Forms.DateTimePicker();
            this.currSysTime_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // flightman_welcome_label
            // 
            this.flightman_welcome_label.AutoSize = true;
            this.flightman_welcome_label.Location = new System.Drawing.Point(28, 44);
            this.flightman_welcome_label.Name = "flightman_welcome_label";
            this.flightman_welcome_label.Size = new System.Drawing.Size(128, 13);
            this.flightman_welcome_label.TabIndex = 1;
            this.flightman_welcome_label.Text = "Welcome, Flight Manager";
            // 
            // selected_flight_label
            // 
            this.selected_flight_label.AutoSize = true;
            this.selected_flight_label.Location = new System.Drawing.Point(530, 101);
            this.selected_flight_label.Name = "selected_flight_label";
            this.selected_flight_label.Size = new System.Drawing.Size(83, 13);
            this.selected_flight_label.TabIndex = 2;
            this.selected_flight_label.Text = "Selected Flight: ";
            // 
            // printManifest_btn
            // 
            this.printManifest_btn.Location = new System.Drawing.Point(564, 161);
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
            // currSysTime_DTP
            // 
            this.currSysTime_DTP.CustomFormat = "yyyy/MM/dd - hh:mm tt";
            this.currSysTime_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.currSysTime_DTP.Location = new System.Drawing.Point(106, 15);
            this.currSysTime_DTP.Name = "currSysTime_DTP";
            this.currSysTime_DTP.Size = new System.Drawing.Size(133, 20);
            this.currSysTime_DTP.TabIndex = 26;
            // 
            // currSysTime_label
            // 
            this.currSysTime_label.AutoSize = true;
            this.currSysTime_label.Location = new System.Drawing.Point(28, 21);
            this.currSysTime_label.Name = "currSysTime_label";
            this.currSysTime_label.Size = new System.Drawing.Size(70, 13);
            this.currSysTime_label.TabIndex = 25;
            this.currSysTime_label.Text = "System Time:";
            // 
            // FlightManLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currSysTime_DTP);
            this.Controls.Add(this.currSysTime_label);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.printManifest_btn);
            this.Controls.Add(this.selected_flight_label);
            this.Controls.Add(this.flightman_welcome_label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FlightManLandingPage";
            this.Text = "FlightManLandingPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label flightman_welcome_label;
        private System.Windows.Forms.Label selected_flight_label;
        private System.Windows.Forms.Button printManifest_btn;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.DateTimePicker currSysTime_DTP;
        private System.Windows.Forms.Label currSysTime_label;
    }
}