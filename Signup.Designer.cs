
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
            this.firstname_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.lastname_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userid_textbox = new System.Windows.Forms.TextBox();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userID_label
            // 
            this.userID_label.AutoSize = true;
            this.userID_label.Location = new System.Drawing.Point(200, 107);
            this.userID_label.Name = "userID_label";
            this.userID_label.Size = new System.Drawing.Size(40, 13);
            this.userID_label.TabIndex = 1;
            this.userID_label.Text = "UserID";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(200, 133);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(53, 13);
            this.pass_label.TabIndex = 2;
            this.pass_label.Text = "Password";
            // 
            // confirmpass_label
            // 
            this.confirmpass_label.AutoSize = true;
            this.confirmpass_label.Location = new System.Drawing.Point(200, 159);
            this.confirmpass_label.Name = "confirmpass_label";
            this.confirmpass_label.Size = new System.Drawing.Size(91, 13);
            this.confirmpass_label.TabIndex = 3;
            this.confirmpass_label.Text = "Confirm Password";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(200, 185);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(57, 13);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "First Name";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(200, 237);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(45, 13);
            this.address_label.TabIndex = 5;
            this.address_label.Text = "Address";
            // 
            // pass_textbox
            // 
            this.pass_textbox.Location = new System.Drawing.Point(330, 130);
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.Size = new System.Drawing.Size(226, 20);
            this.pass_textbox.TabIndex = 7;
            // 
            // confirmpass_textbox
            // 
            this.confirmpass_textbox.Location = new System.Drawing.Point(330, 156);
            this.confirmpass_textbox.Name = "confirmpass_textbox";
            this.confirmpass_textbox.Size = new System.Drawing.Size(226, 20);
            this.confirmpass_textbox.TabIndex = 8;
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Location = new System.Drawing.Point(330, 182);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(226, 20);
            this.firstname_textbox.TabIndex = 9;
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(330, 234);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(226, 20);
            this.address_textbox.TabIndex = 10;
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(330, 338);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 11;
            this.signup_btn.Text = "Enter";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(330, 208);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(226, 20);
            this.lastname_textbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Last Name";
            // 
            // userid_textbox
            // 
            this.userid_textbox.Enabled = false;
            this.userid_textbox.Location = new System.Drawing.Point(330, 104);
            this.userid_textbox.Name = "userid_textbox";
            this.userid_textbox.Size = new System.Drawing.Size(226, 20);
            this.userid_textbox.TabIndex = 14;
            this.userid_textbox.Text = "*Error Loading ID";
            // 
            // age_textbox
            // 
            this.age_textbox.Location = new System.Drawing.Point(330, 260);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(226, 20);
            this.age_textbox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Age";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(330, 367);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 17;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(330, 286);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(226, 20);
            this.email_textbox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(330, 312);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(226, 20);
            this.phone_textbox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userid_textbox);
            this.Controls.Add(this.lastname_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.firstname_textbox);
            this.Controls.Add(this.confirmpass_textbox);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.confirmpass_label);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.userID_label);
            this.Name = "Signup";
            this.Text = "Create new account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signup_FormClosing);
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
        private System.Windows.Forms.TextBox firstname_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox lastname_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userid_textbox;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label label4;
    }
}