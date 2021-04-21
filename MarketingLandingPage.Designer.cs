
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
            this.marketingManger_welcome_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectedFlight_label = new System.Windows.Forms.Label();
            this.planesModels_comboBox = new System.Windows.Forms.ComboBox();
            this.currPlane_label = new System.Windows.Forms.Label();
            this.curr_capacity_label = new System.Windows.Forms.Label();
            this.new_capacity_label = new System.Windows.Forms.Label();
            this.set_plane_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newCapacityValue_label = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // marketingManger_welcome_label
            // 
            this.marketingManger_welcome_label.AutoSize = true;
            this.marketingManger_welcome_label.Location = new System.Drawing.Point(30, 19);
            this.marketingManger_welcome_label.Name = "marketingManger_welcome_label";
            this.marketingManger_welcome_label.Size = new System.Drawing.Size(144, 13);
            this.marketingManger_welcome_label.TabIndex = 0;
            this.marketingManger_welcome_label.Text = "Welcome, Marketing Manger";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 340);
            this.dataGridView1.TabIndex = 1;
            // 
            // selectedFlight_label
            // 
            this.selectedFlight_label.AutoSize = true;
            this.selectedFlight_label.Location = new System.Drawing.Point(517, 86);
            this.selectedFlight_label.Name = "selectedFlight_label";
            this.selectedFlight_label.Size = new System.Drawing.Size(80, 13);
            this.selectedFlight_label.TabIndex = 2;
            this.selectedFlight_label.Text = "Selected Flight:";
            // 
            // planesModels_comboBox
            // 
            this.planesModels_comboBox.FormattingEnabled = true;
            this.planesModels_comboBox.Location = new System.Drawing.Point(617, 173);
            this.planesModels_comboBox.Name = "planesModels_comboBox";
            this.planesModels_comboBox.Size = new System.Drawing.Size(121, 21);
            this.planesModels_comboBox.TabIndex = 3;
            this.planesModels_comboBox.SelectedIndexChanged += new System.EventHandler(this.planesModels_comboBox_SelectedIndexChanged);
            // 
            // currPlane_label
            // 
            this.currPlane_label.AutoSize = true;
            this.currPlane_label.Location = new System.Drawing.Point(523, 109);
            this.currPlane_label.Name = "currPlane_label";
            this.currPlane_label.Size = new System.Drawing.Size(74, 13);
            this.currPlane_label.TabIndex = 4;
            this.currPlane_label.Text = "Current Plane:";
            // 
            // curr_capacity_label
            // 
            this.curr_capacity_label.AutoSize = true;
            this.curr_capacity_label.Location = new System.Drawing.Point(509, 132);
            this.curr_capacity_label.Name = "curr_capacity_label";
            this.curr_capacity_label.Size = new System.Drawing.Size(88, 13);
            this.curr_capacity_label.TabIndex = 5;
            this.curr_capacity_label.Text = "Current Capacity:";
            // 
            // new_capacity_label
            // 
            this.new_capacity_label.AutoSize = true;
            this.new_capacity_label.Location = new System.Drawing.Point(521, 210);
            this.new_capacity_label.Name = "new_capacity_label";
            this.new_capacity_label.Size = new System.Drawing.Size(76, 13);
            this.new_capacity_label.TabIndex = 7;
            this.new_capacity_label.Text = "New Capacity:";
            // 
            // set_plane_label
            // 
            this.set_plane_label.AutoSize = true;
            this.set_plane_label.Location = new System.Drawing.Point(541, 176);
            this.set_plane_label.Name = "set_plane_label";
            this.set_plane_label.Size = new System.Drawing.Size(56, 13);
            this.set_plane_label.TabIndex = 6;
            this.set_plane_label.Text = "Set Plane:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update Plane";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newCapacityValue_label
            // 
            this.newCapacityValue_label.AutoSize = true;
            this.newCapacityValue_label.Location = new System.Drawing.Point(614, 210);
            this.newCapacityValue_label.Name = "newCapacityValue_label";
            this.newCapacityValue_label.Size = new System.Drawing.Size(13, 13);
            this.newCapacityValue_label.TabIndex = 9;
            this.newCapacityValue_label.Text = "0";
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
            // MarketingLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.newCapacityValue_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.new_capacity_label);
            this.Controls.Add(this.set_plane_label);
            this.Controls.Add(this.curr_capacity_label);
            this.Controls.Add(this.currPlane_label);
            this.Controls.Add(this.planesModels_comboBox);
            this.Controls.Add(this.selectedFlight_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.marketingManger_welcome_label);
            this.Name = "MarketingLandingPage";
            this.Text = "MarketingLandingPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label marketingManger_welcome_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label selectedFlight_label;
        private System.Windows.Forms.ComboBox planesModels_comboBox;
        private System.Windows.Forms.Label currPlane_label;
        private System.Windows.Forms.Label curr_capacity_label;
        private System.Windows.Forms.Label new_capacity_label;
        private System.Windows.Forms.Label set_plane_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label newCapacityValue_label;
        private System.Windows.Forms.Button logout_button;
    }
}