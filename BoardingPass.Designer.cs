
namespace Air3550
{
    partial class BoardingPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leg1_groupbox = new System.Windows.Forms.GroupBox();
            this.leg2_groupbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_value_label = new System.Windows.Forms.Label();
            this.account_value_label = new System.Windows.Forms.Label();
            this.fullflight_value_label = new System.Windows.Forms.Label();
            this.leg1_flight_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.leg1_dept_value_label = new System.Windows.Forms.Label();
            this.leg1_arrival_value_label = new System.Windows.Forms.Label();
            this.leg2_arrival_value_label = new System.Windows.Forms.Label();
            this.leg2_dept_value_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.leg2_flight_label = new System.Windows.Forms.Label();
            this.leg2_flightid_label = new System.Windows.Forms.Label();
            this.leg1_flightid_label = new System.Windows.Forms.Label();
            this.layover_label = new System.Windows.Forms.Label();
            this.leg1_groupbox.SuspendLayout();
            this.leg2_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Air 3550";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passenger Name";
            // 
            // leg1_groupbox
            // 
            this.leg1_groupbox.Controls.Add(this.leg1_flightid_label);
            this.leg1_groupbox.Controls.Add(this.leg1_arrival_value_label);
            this.leg1_groupbox.Controls.Add(this.leg1_dept_value_label);
            this.leg1_groupbox.Controls.Add(this.label8);
            this.leg1_groupbox.Controls.Add(this.label7);
            this.leg1_groupbox.Controls.Add(this.label6);
            this.leg1_groupbox.Controls.Add(this.leg1_flight_label);
            this.leg1_groupbox.Location = new System.Drawing.Point(79, 101);
            this.leg1_groupbox.Name = "leg1_groupbox";
            this.leg1_groupbox.Size = new System.Drawing.Size(521, 100);
            this.leg1_groupbox.TabIndex = 2;
            this.leg1_groupbox.TabStop = false;
            this.leg1_groupbox.Text = "Leg1";
            // 
            // leg2_groupbox
            // 
            this.leg2_groupbox.Controls.Add(this.leg2_flightid_label);
            this.leg2_groupbox.Controls.Add(this.leg2_arrival_value_label);
            this.leg2_groupbox.Controls.Add(this.leg2_dept_value_label);
            this.leg2_groupbox.Controls.Add(this.label13);
            this.leg2_groupbox.Controls.Add(this.label14);
            this.leg2_groupbox.Controls.Add(this.label15);
            this.leg2_groupbox.Controls.Add(this.leg2_flight_label);
            this.leg2_groupbox.Location = new System.Drawing.Point(79, 244);
            this.leg2_groupbox.Name = "leg2_groupbox";
            this.leg2_groupbox.Size = new System.Drawing.Size(521, 100);
            this.leg2_groupbox.TabIndex = 3;
            this.leg2_groupbox.TabStop = false;
            this.leg2_groupbox.Text = "Leg2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account #";
            // 
            // name_value_label
            // 
            this.name_value_label.AutoSize = true;
            this.name_value_label.Location = new System.Drawing.Point(170, 49);
            this.name_value_label.Name = "name_value_label";
            this.name_value_label.Size = new System.Drawing.Size(13, 13);
            this.name_value_label.TabIndex = 5;
            this.name_value_label.Text = "_";
            // 
            // account_value_label
            // 
            this.account_value_label.AutoSize = true;
            this.account_value_label.Location = new System.Drawing.Point(487, 49);
            this.account_value_label.Name = "account_value_label";
            this.account_value_label.Size = new System.Drawing.Size(13, 13);
            this.account_value_label.TabIndex = 6;
            this.account_value_label.Text = "_";
            // 
            // fullflight_value_label
            // 
            this.fullflight_value_label.AutoSize = true;
            this.fullflight_value_label.Location = new System.Drawing.Point(120, 73);
            this.fullflight_value_label.Name = "fullflight_value_label";
            this.fullflight_value_label.Size = new System.Drawing.Size(13, 13);
            this.fullflight_value_label.TabIndex = 7;
            this.fullflight_value_label.Text = "_";
            // 
            // leg1_flight_label
            // 
            this.leg1_flight_label.AutoSize = true;
            this.leg1_flight_label.Location = new System.Drawing.Point(35, 48);
            this.leg1_flight_label.Name = "leg1_flight_label";
            this.leg1_flight_label.Size = new System.Drawing.Size(13, 13);
            this.leg1_flight_label.TabIndex = 8;
            this.leg1_flight_label.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Departure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Arrival";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Flight #";
            // 
            // leg1_dept_value_label
            // 
            this.leg1_dept_value_label.AutoSize = true;
            this.leg1_dept_value_label.Location = new System.Drawing.Point(206, 48);
            this.leg1_dept_value_label.Name = "leg1_dept_value_label";
            this.leg1_dept_value_label.Size = new System.Drawing.Size(13, 13);
            this.leg1_dept_value_label.TabIndex = 12;
            this.leg1_dept_value_label.Text = "_";
            // 
            // leg1_arrival_value_label
            // 
            this.leg1_arrival_value_label.AutoSize = true;
            this.leg1_arrival_value_label.Location = new System.Drawing.Point(398, 48);
            this.leg1_arrival_value_label.Name = "leg1_arrival_value_label";
            this.leg1_arrival_value_label.Size = new System.Drawing.Size(13, 13);
            this.leg1_arrival_value_label.TabIndex = 13;
            this.leg1_arrival_value_label.Text = "_";
            // 
            // leg2_arrival_value_label
            // 
            this.leg2_arrival_value_label.AutoSize = true;
            this.leg2_arrival_value_label.Location = new System.Drawing.Point(398, 48);
            this.leg2_arrival_value_label.Name = "leg2_arrival_value_label";
            this.leg2_arrival_value_label.Size = new System.Drawing.Size(13, 13);
            this.leg2_arrival_value_label.TabIndex = 19;
            this.leg2_arrival_value_label.Text = "_";
            // 
            // leg2_dept_value_label
            // 
            this.leg2_dept_value_label.AutoSize = true;
            this.leg2_dept_value_label.Location = new System.Drawing.Point(206, 48);
            this.leg2_dept_value_label.Name = "leg2_dept_value_label";
            this.leg2_dept_value_label.Size = new System.Drawing.Size(13, 13);
            this.leg2_dept_value_label.TabIndex = 18;
            this.leg2_dept_value_label.Text = "_";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Flight #";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(385, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Arrival";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Departure";
            // 
            // leg2_flight_label
            // 
            this.leg2_flight_label.AutoSize = true;
            this.leg2_flight_label.Location = new System.Drawing.Point(35, 48);
            this.leg2_flight_label.Name = "leg2_flight_label";
            this.leg2_flight_label.Size = new System.Drawing.Size(13, 13);
            this.leg2_flight_label.TabIndex = 14;
            this.leg2_flight_label.Text = "_";
            // 
            // leg2_flightid_label
            // 
            this.leg2_flightid_label.AutoSize = true;
            this.leg2_flightid_label.Location = new System.Drawing.Point(54, 16);
            this.leg2_flightid_label.Name = "leg2_flightid_label";
            this.leg2_flightid_label.Size = new System.Drawing.Size(13, 13);
            this.leg2_flightid_label.TabIndex = 20;
            this.leg2_flightid_label.Text = "_";
            // 
            // leg1_flightid_label
            // 
            this.leg1_flightid_label.AutoSize = true;
            this.leg1_flightid_label.Location = new System.Drawing.Point(54, 16);
            this.leg1_flightid_label.Name = "leg1_flightid_label";
            this.leg1_flightid_label.Size = new System.Drawing.Size(13, 13);
            this.leg1_flightid_label.TabIndex = 21;
            this.leg1_flightid_label.Text = "_";
            // 
            // layover_label
            // 
            this.layover_label.AutoSize = true;
            this.layover_label.Location = new System.Drawing.Point(76, 217);
            this.layover_label.Name = "layover_label";
            this.layover_label.Size = new System.Drawing.Size(13, 13);
            this.layover_label.TabIndex = 8;
            this.layover_label.Text = "_";
            // 
            // BoardingPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 404);
            this.Controls.Add(this.layover_label);
            this.Controls.Add(this.fullflight_value_label);
            this.Controls.Add(this.account_value_label);
            this.Controls.Add(this.name_value_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.leg2_groupbox);
            this.Controls.Add(this.leg1_groupbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BoardingPass";
            this.Text = "BoardingPass";
            this.leg1_groupbox.ResumeLayout(false);
            this.leg1_groupbox.PerformLayout();
            this.leg2_groupbox.ResumeLayout(false);
            this.leg2_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox leg1_groupbox;
        private System.Windows.Forms.GroupBox leg2_groupbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name_value_label;
        private System.Windows.Forms.Label account_value_label;
        private System.Windows.Forms.Label leg1_flightid_label;
        private System.Windows.Forms.Label leg1_arrival_value_label;
        private System.Windows.Forms.Label leg1_dept_value_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label leg1_flight_label;
        private System.Windows.Forms.Label leg2_flightid_label;
        private System.Windows.Forms.Label leg2_arrival_value_label;
        private System.Windows.Forms.Label leg2_dept_value_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label leg2_flight_label;
        private System.Windows.Forms.Label fullflight_value_label;
        private System.Windows.Forms.Label layover_label;
    }
}