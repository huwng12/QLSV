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
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        // dat mau neu muon
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            // get panels color
            panTotalColor = PanelTotal.BackColor;
            panMaleColor = PanelMale.BackColor;
            panFemaleColor = PanelFemale.BackColor;
            // display the values
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());
            // tinh %, các bạn xem lai phep toan 
            // (tong students X 100) / (total students)
            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentsPercentage = (totalFemale * (100 / total));
            LabelTotal.Text = ("Total Students: " + total.ToString());
            LabelMale.Text = ("Male : " + (maleStudentsPercentage.ToString("0.00") + "%"));
            LabelFemale.Text = ("Female :" + (femaleStudentsPercentage.ToString("0.00") + "%"));
        }
        // thu các event lam viec voi Mouse
        
        private void LabelMale_MouseEnter(object sender, EventArgs e)
        {
            LabelMale.ForeColor = panMaleColor; 
            PanelMale.BackColor = Color.Red;
        }
        private void LabelMale_MouseLeave(object sender, EventArgs e)
        {
            LabelMale.ForeColor = Color.Red;
            PanelMale.BackColor = panMaleColor;
        }
        private void LabelFemale_MouseEnter(object sender, EventArgs e)
        {
            LabelFemale.ForeColor = panFemaleColor;
            PanelFemale.BackColor = Color.White;
        }
        private void LabelFemale_MouseLeave(object sender, EventArgs e)
        {
            LabelFemale.ForeColor = Color.White;
            PanelFemale.BackColor = panFemaleColor;
        }


        private void LabelTotal_Click(object sender, EventArgs e)
        {

        }

        private void LabelTotal_MouseLeave_1(object sender, EventArgs e)
        {
            LabelTotal.ForeColor = Color.White;
            PanelTotal.BackColor = panTotalColor;
        }

        private void LabelTotal_MouseEnter_1(object sender, EventArgs e)
        {
            LabelTotal.ForeColor = panTotalColor;
            PanelTotal.BackColor = Color.White;
        }

        private void LabelFemale_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            StaticsForm d = new StaticsForm();
            this.Hide();
            d.ShowDialog();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
