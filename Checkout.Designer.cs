
namespace Air3550
{
    partial class Checkout
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
            this.flight2_label = new System.Windows.Forms.Label();
            this.point_payment_rbtn = new System.Windows.Forms.RadioButton();
            this.payemnt_groupBox = new System.Windows.Forms.GroupBox();
            this.card_payment_rbtn = new System.Windows.Forms.RadioButton();
            this.notenoughpoints_label = new System.Windows.Forms.Label();
            this.flight1_value_label = new System.Windows.Forms.Label();
            this.flight2_value_label = new System.Windows.Forms.Label();
            this.book_btn = new System.Windows.Forms.Button();
            this.userid_label = new System.Windows.Forms.Label();
            this.flight1_label = new System.Windows.Forms.Label();
            this.userreward_balance_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.payemnt_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flight2_label
            // 
            this.flight2_label.AutoSize = true;
            this.flight2_label.Location = new System.Drawing.Point(51, 95);
            this.flight2_label.Name = "flight2_label";
            this.flight2_label.Size = new System.Drawing.Size(44, 13);
            this.flight2_label.TabIndex = 1;
            this.flight2_label.Text = "Flight 2:";
            // 
            // point_payment_rbtn
            // 
            this.point_payment_rbtn.AutoSize = true;
            this.point_payment_rbtn.Location = new System.Drawing.Point(60, 19);
            this.point_payment_rbtn.Name = "point_payment_rbtn";
            this.point_payment_rbtn.Size = new System.Drawing.Size(100, 17);
            this.point_payment_rbtn.TabIndex = 2;
            this.point_payment_rbtn.Text = "Pay With Points";
            this.point_payment_rbtn.UseVisualStyleBackColor = true;
            // 
            // payemnt_groupBox
            // 
            this.payemnt_groupBox.Controls.Add(this.card_payment_rbtn);
            this.payemnt_groupBox.Controls.Add(this.point_payment_rbtn);
            this.payemnt_groupBox.Controls.Add(this.notenoughpoints_label);
            this.payemnt_groupBox.Location = new System.Drawing.Point(122, 135);
            this.payemnt_groupBox.Name = "payemnt_groupBox";
            this.payemnt_groupBox.Size = new System.Drawing.Size(220, 70);
            this.payemnt_groupBox.TabIndex = 3;
            this.payemnt_groupBox.TabStop = false;
            this.payemnt_groupBox.Text = "Payment Method";
            // 
            // card_payment_rbtn
            // 
            this.card_payment_rbtn.AutoSize = true;
            this.card_payment_rbtn.Checked = true;
            this.card_payment_rbtn.Location = new System.Drawing.Point(60, 42);
            this.card_payment_rbtn.Name = "card_payment_rbtn";
            this.card_payment_rbtn.Size = new System.Drawing.Size(83, 17);
            this.card_payment_rbtn.TabIndex = 3;
            this.card_payment_rbtn.TabStop = true;
            this.card_payment_rbtn.Text = "Pay By Card";
            this.card_payment_rbtn.UseVisualStyleBackColor = true;
            // 
            // notenoughpoints_label
            // 
            this.notenoughpoints_label.AutoSize = true;
            this.notenoughpoints_label.Location = new System.Drawing.Point(37, 21);
            this.notenoughpoints_label.Name = "notenoughpoints_label";
            this.notenoughpoints_label.Size = new System.Drawing.Size(151, 13);
            this.notenoughpoints_label.TabIndex = 11;
            this.notenoughpoints_label.Text = "Not Enough Points to Redeem";
            // 
            // flight1_value_label
            // 
            this.flight1_value_label.AutoSize = true;
            this.flight1_value_label.Location = new System.Drawing.Point(135, 62);
            this.flight1_value_label.Name = "flight1_value_label";
            this.flight1_value_label.Size = new System.Drawing.Size(13, 13);
            this.flight1_value_label.TabIndex = 4;
            this.flight1_value_label.Text = "_";
            // 
            // flight2_value_label
            // 
            this.flight2_value_label.AutoSize = true;
            this.flight2_value_label.Location = new System.Drawing.Point(135, 95);
            this.flight2_value_label.Name = "flight2_value_label";
            this.flight2_value_label.Size = new System.Drawing.Size(13, 13);
            this.flight2_value_label.TabIndex = 5;
            this.flight2_value_label.Text = "_";
            // 
            // book_btn
            // 
            this.book_btn.Location = new System.Drawing.Point(122, 211);
            this.book_btn.Name = "book_btn";
            this.book_btn.Size = new System.Drawing.Size(75, 23);
            this.book_btn.TabIndex = 6;
            this.book_btn.Text = "Book";
            this.book_btn.UseVisualStyleBackColor = true;
            this.book_btn.Click += new System.EventHandler(this.book_btn_Click);
            // 
            // userid_label
            // 
            this.userid_label.AutoSize = true;
            this.userid_label.Location = new System.Drawing.Point(403, 9);
            this.userid_label.Name = "userid_label";
            this.userid_label.Size = new System.Drawing.Size(32, 13);
            this.userid_label.TabIndex = 7;
            this.userid_label.Text = "User:";
            // 
            // flight1_label
            // 
            this.flight1_label.AutoSize = true;
            this.flight1_label.Location = new System.Drawing.Point(51, 62);
            this.flight1_label.Name = "flight1_label";
            this.flight1_label.Size = new System.Drawing.Size(44, 13);
            this.flight1_label.TabIndex = 0;
            this.flight1_label.Text = "Flight 1:";
            // 
            // userreward_balance_label
            // 
            this.userreward_balance_label.AutoSize = true;
            this.userreward_balance_label.Location = new System.Drawing.Point(403, 22);
            this.userreward_balance_label.Name = "userreward_balance_label";
            this.userreward_balance_label.Size = new System.Drawing.Size(95, 13);
            this.userreward_balance_label.TabIndex = 8;
            this.userreward_balance_label.Text = "Reward Balance:  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Arrival Final Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Departure Origin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(267, 211);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 349);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userreward_balance_label);
            this.Controls.Add(this.userid_label);
            this.Controls.Add(this.book_btn);
            this.Controls.Add(this.flight2_value_label);
            this.Controls.Add(this.flight1_value_label);
            this.Controls.Add(this.payemnt_groupBox);
            this.Controls.Add(this.flight2_label);
            this.Controls.Add(this.flight1_label);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Checkout_FormClosing);
            this.payemnt_groupBox.ResumeLayout(false);
            this.payemnt_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label flight2_label;
        private System.Windows.Forms.RadioButton point_payment_rbtn;
        private System.Windows.Forms.GroupBox payemnt_groupBox;
        private System.Windows.Forms.RadioButton card_payment_rbtn;
        private System.Windows.Forms.Label flight1_value_label;
        private System.Windows.Forms.Label flight2_value_label;
        private System.Windows.Forms.Button book_btn;
        private System.Windows.Forms.Label userid_label;
        private System.Windows.Forms.Label flight1_label;
        private System.Windows.Forms.Label userreward_balance_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label notenoughpoints_label;
        private System.Windows.Forms.Button cancel;
    }
}