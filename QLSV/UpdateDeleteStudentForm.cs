using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime bdate = DateTimePicker1.Value;
            string phone = TextBoxPhone.Text;
            string adrs = TextBoxAddress.Text;
            string gender = "Male";
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream PIC = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student age must be between 1- and 100 - Try again!", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try 
                {
                    id = Convert.ToInt32(TextBoxID.Text);
                    PictureBoxStudentImage.Image.Save(PIC, PictureBoxStudentImage.Image.RawFormat);
                    if (student.EditStudent(id, fname, lname, bdate, gender, phone, adrs, PIC))
                    {
                        MessageBox.Show("Student Infor Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Chức năng kiểm tra dữ liệu input
        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                || (TextBoxLname.Text.Trim() == "")
                || (TextBoxAddress.Text.Trim() == "")
                || (TextBoxAddress.Text.Trim() == "")
                || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    RadioButtonMale.Checked = true;
                }
                else
                {
                    RadioButtonFemale.Checked = true;
                }

                TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                TextBoxAddress.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);


            }
            else
            {
                MessageBox.Show("not found", "Find student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {   
            //delete student
            try
            {
                int studentId = Convert.ToInt32(TextBoxID.Text);
                // display a confirmation message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    if(student.DeleteStudent(studentId))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields after delete
                        TextBoxID.Text = "";
                        TextBoxFname.Text = "";
                        TextBoxLname.Text = "";
                        TextBoxAddress.Text = "";
                        TextBoxPhone.Text = "";
                        DateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
                    }    
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //check information
        public bool checkInfor()
        {
            if (TextBoxID.Text == "")
            {
                MessageBox.Show("Input the id ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxID.Focus();
                return false;
            }
            if (TextBoxFname.Text == "")
            {
                MessageBox.Show("Input the first name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxFname.Focus();
                return false;
            }
            if (TextBoxLname.Text == "")
            {
                MessageBox.Show("Input the last name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxLname.Focus();
                return false;
            }
            if (TextBoxPhone.Text == "")
            {
                MessageBox.Show("Input the phone", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxPhone.Focus();
                return false;
            }
            if (TextBoxAddress.Text == "")
            {
                MessageBox.Show("Input the address", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxAddress.Focus();
                return false;
            }
            return true;
        }

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void uploadImage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Imge(*.jng;*.png;*.gif)| *.jng;*.png;*gif ";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
