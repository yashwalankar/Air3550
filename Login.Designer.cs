
namespace Air3550
{
    partial class Login
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
            this.userID_textbox = new System.Windows.Forms.TextBox();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.signup_btn = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userID_label
            // 
            this.userID_label.AutoSize = true;
            this.userID_label.Location = new System.Drawing.Point(200, 68);
            this.userID_label.Name = "userID_label";
            this.userID_label.Size = new System.Drawing.Size(40, 13);
            this.userID_label.TabIndex = 0;
            this.userID_label.Text = "UserID";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(200, 104);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(53, 13);
            this.pass_label.TabIndex = 1;
            this.pass_label.Text = "Password";
            // 
            // userID_textbox
            // 
            this.userID_textbox.Location = new System.Drawing.Point(273, 65);
            this.userID_textbox.Name = "userID_textbox";
            this.userID_textbox.Size = new System.Drawing.Size(100, 20);
            this.userID_textbox.TabIndex = 2;
            // 
            // pass_textbox
            // 
            this.pass_textbox.Location = new System.Drawing.Point(273, 101);
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.Size = new System.Drawing.Size(100, 20);
            this.pass_textbox.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(273, 138);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(273, 167);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 5;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(200, 208);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(267, 13);
            this.error_label.TabIndex = 6;
            this.error_label.Text = "* error logging in please retype username and password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 338);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.userID_textbox);
            this.Controls.Add(this.userID_label);
            this.Controls.Add(this.pass_label);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userID_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox userID_textbox;
        private System.Windows.Forms.TextBox pass_textbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label error_label;
    }
}