namespace QLSV
{
    partial class SignUpForm
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
            this.closeBTN = new System.Windows.Forms.Button();
            this.CreateBtn_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.verifiPassText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.DarkCyan;
            this.closeBTN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBTN.ForeColor = System.Drawing.Color.Transparent;
            this.closeBTN.Location = new System.Drawing.Point(196, 317);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(191, 55);
            this.closeBTN.TabIndex = 0;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // CreateBtn_Click
            // 
            this.CreateBtn_Click.BackColor = System.Drawing.Color.DarkCyan;
            this.CreateBtn_Click.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn_Click.ForeColor = System.Drawing.Color.Transparent;
            this.CreateBtn_Click.Location = new System.Drawing.Point(419, 317);
            this.CreateBtn_Click.Name = "CreateBtn_Click";
            this.CreateBtn_Click.Size = new System.Drawing.Size(187, 55);
            this.CreateBtn_Click.TabIndex = 1;
            this.CreateBtn_Click.Text = "Create";
            this.CreateBtn_Click.UseVisualStyleBackColor = false;
            this.CreateBtn_Click.Click += new System.EventHandler(this.CreateBtn_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(196, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(210, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(371, 104);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(235, 31);
            this.userNameText.TabIndex = 4;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(371, 171);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(235, 31);
            this.passwordText.TabIndex = 5;
            // 
            // verifiPassText
            // 
            this.verifiPassText.Location = new System.Drawing.Point(371, 234);
            this.verifiPassText.Name = "verifiPassText";
            this.verifiPassText.Size = new System.Drawing.Size(235, 31);
            this.verifiPassText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(118, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verify Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "SIGN UP NEW ACCOUNT";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.verifiPassText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateBtn_Click);
            this.Controls.Add(this.closeBTN);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button CreateBtn_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox verifiPassText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}