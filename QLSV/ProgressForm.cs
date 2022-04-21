using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Step = 10;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MainForm01 form = new MainForm01();
            progressBar1.PerformStep();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                label1.Text = "Completed";
                form.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
