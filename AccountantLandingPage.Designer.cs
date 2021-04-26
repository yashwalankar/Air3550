
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
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // flights_dataview
            // 
            this.flights_dataview.AllowUserToAddRows = false;
            this.flights_dataview.AllowUserToDeleteRows = false;
            this.flights_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flights_dataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.flights_dataview.Location = new System.Drawing.Point(12, 257);
            this.flights_dataview.Name = "flights_dataview";
            this.flights_dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flights_dataview.Size = new System.Drawing.Size(690, 340);
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
            // AccountantLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 609);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flights_dataview);
            this.Controls.Add(this.logout_button);
            this.Name = "AccountantLandingPage";
            this.Text = "Accountant Tools";
            ((System.ComponentModel.ISupportInitialize)(this.flights_dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.DataGridView flights_dataview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label welcome_label;
    }
}