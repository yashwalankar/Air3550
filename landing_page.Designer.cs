
namespace Air3550
{
    partial class landing_page
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.usertype_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(61, 27);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(134, 13);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome, ---username---";
            this.welcome_label.Click += new System.EventHandler(this.welcome_label_Click);
            // 
            // label1
            // 
            this.usertype_label.AutoSize = true;
            this.usertype_label.Location = new System.Drawing.Point(626, 27);
            this.usertype_label.Name = "usertype_label";
            this.usertype_label.Size = new System.Drawing.Size(35, 13);
            this.usertype_label.TabIndex = 1;
            this.usertype_label.Text = "User Type : ---user type---";
            // 
            // landing_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usertype_label);
            this.Controls.Add(this.welcome_label);
            this.Name = "landing_page";
            this.Text = "Landing Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label usertype_label;
    }
}