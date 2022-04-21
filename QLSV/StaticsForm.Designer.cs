namespace QLSV
{
    partial class StaticsForm
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
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.PanelFemale = new System.Windows.Forms.Panel();
            this.LabelFemale = new System.Windows.Forms.Label();
            this.PanelMale = new System.Windows.Forms.Panel();
            this.LabelMale = new System.Windows.Forms.Label();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.PanelTotal.SuspendLayout();
            this.PanelFemale.SuspendLayout();
            this.PanelMale.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTotal
            // 
            this.PanelTotal.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.PanelTotal.Controls.Add(this.LabelTotal);
            this.PanelTotal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelTotal.Location = new System.Drawing.Point(0, 2);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Size = new System.Drawing.Size(796, 221);
            this.PanelTotal.TabIndex = 0;
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.Color.GreenYellow;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelTotal.Location = new System.Drawing.Point(0, 0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(796, 221);
            this.LabelTotal.TabIndex = 0;
            this.LabelTotal.Text = "Total Student: 100%";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTotal.Click += new System.EventHandler(this.LabelTotal_Click);
            this.LabelTotal.MouseEnter += new System.EventHandler(this.LabelTotal_MouseEnter_1);
            this.LabelTotal.MouseLeave += new System.EventHandler(this.LabelTotal_MouseLeave_1);
            // 
            // PanelFemale
            // 
            this.PanelFemale.BackColor = System.Drawing.Color.Pink;
            this.PanelFemale.Controls.Add(this.LabelFemale);
            this.PanelFemale.Location = new System.Drawing.Point(0, 229);
            this.PanelFemale.Name = "PanelFemale";
            this.PanelFemale.Size = new System.Drawing.Size(400, 221);
            this.PanelFemale.TabIndex = 1;
            // 
            // LabelFemale
            // 
            this.LabelFemale.BackColor = System.Drawing.Color.Indigo;
            this.LabelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelFemale.Location = new System.Drawing.Point(0, 0);
            this.LabelFemale.Name = "LabelFemale";
            this.LabelFemale.Size = new System.Drawing.Size(400, 221);
            this.LabelFemale.TabIndex = 0;
            this.LabelFemale.Text = "Male: 50%";
            this.LabelFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelFemale.Click += new System.EventHandler(this.LabelFemale_Click);
            this.LabelFemale.MouseEnter += new System.EventHandler(this.LabelFemale_MouseEnter);
            this.LabelFemale.MouseLeave += new System.EventHandler(this.LabelFemale_MouseLeave);
            // 
            // PanelMale
            // 
            this.PanelMale.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelMale.Controls.Add(this.LabelMale);
            this.PanelMale.Location = new System.Drawing.Point(406, 229);
            this.PanelMale.Name = "PanelMale";
            this.PanelMale.Size = new System.Drawing.Size(390, 221);
            this.PanelMale.TabIndex = 2;
            // 
            // LabelMale
            // 
            this.LabelMale.BackColor = System.Drawing.Color.Azure;
            this.LabelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelMale.Location = new System.Drawing.Point(0, 0);
            this.LabelMale.Name = "LabelMale";
            this.LabelMale.Size = new System.Drawing.Size(390, 221);
            this.LabelMale.TabIndex = 1;
            this.LabelMale.Text = "Male: 50%";
            this.LabelMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMale.MouseEnter += new System.EventHandler(this.LabelMale_MouseEnter);
            this.LabelMale.MouseLeave += new System.EventHandler(this.LabelMale_MouseLeave);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.ButtonRefresh.Location = new System.Drawing.Point(858, 64);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(112, 89);
            this.ButtonRefresh.TabIndex = 3;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.SystemColors.Info;
            this.ButtonExit.Location = new System.Drawing.Point(858, 283);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(112, 87);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.PanelMale);
            this.Controls.Add(this.PanelFemale);
            this.Controls.Add(this.PanelTotal);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "StaticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.PanelTotal.ResumeLayout(false);
            this.PanelFemale.ResumeLayout(false);
            this.PanelMale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.Panel PanelFemale;
        private System.Windows.Forms.Panel PanelMale;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelFemale;
        private System.Windows.Forms.Label LabelMale;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonExit;
    }
}