
namespace Air3550
{
    partial class Signup
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
            this.userID_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.confirmpass_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.confirmpass_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userID_label
            // 
            this.userID_label.AutoSize = true;
            this.userID_label.Location = new System.Drawing.Point(200, 79);
            this.userID_label.Name = "userID_label";
            this.userID_label.Size = new System.Drawing.Size(40, 13);
            this.userID_label.TabIndex = 1;
            this.userID_label.Text = "UserID";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(200, 104);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(53, 13);
            this.pass_label.TabIndex = 2;
            this.pass_label.Text = "Password";
            // 
            // confirmpass_label
            // 
            this.confirmpass_label.AutoSize = true;
            this.confirmpass_label.Location = new System.Drawing.Point(200, 128);
            this.confirmpass_label.Name = "confirmpass_label";
            this.confirmpass_label.Size = new System.Drawing.Size(91, 13);
            this.confirmpass_label.TabIndex = 3;
            this.confirmpass_label.Text = "Confirm Password";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(200, 152);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Name";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(200, 177);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(45, 13);
            this.address_label.TabIndex = 5;
            this.address_label.Text = "Address";
            // 
            // pass_textbox
            // 
            this.pass_textbox.Location = new System.Drawing.Point(330, 97);
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.Size = new System.Drawing.Size(100, 20);
            this.pass_textbox.TabIndex = 7;
            // 
            // confirmpass_textbox
            // 
            this.confirmpass_textbox.Location = new System.Drawing.Point(330, 121);
            this.confirmpass_textbox.Name = "confirmpass_textbox";
            this.confirmpass_textbox.Size = new System.Drawing.Size(100, 20);
            this.confirmpass_textbox.TabIndex = 8;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(330, 147);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 9;
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(330, 174);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(226, 20);
            this.address_textbox.TabIndex = 10;
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(330, 221);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 11;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.confirmpass_textbox);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.confirmpass_label);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.userID_label);
            this.Name = "Signup";
            this.Text = "Create new account";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userID_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label confirmpass_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox pass_textbox;
        private System.Windows.Forms.TextBox confirmpass_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Button signup_btn;
    }
}