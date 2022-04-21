using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("You want exit ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User AND password = @Pass", db.getConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = txtUserName.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                //MessageBox.Show("Ok, next time will be go to Main Menu of App");
                //this.DialogResult = DialogResult.OK;
                ProgressForm progress = new ProgressForm();
                progress.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.Show();
        }

        private void lbForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword form = new ForgetPassword();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dua hinh tu folder
            pictureBox1.Image = Image.FromFile(@"C:\Users\hvo05\source\repos\WindowProgramming\login.png");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
