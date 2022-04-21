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
    public partial class studentsListForm : Form
    {
        public studentsListForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        private void studentsListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.myDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            //xử lí hình ảnh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            //xử lí hình ảnh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm UpdateDeleteform = new UpdateDeleteStudentForm();
            UpdateDeleteform.TextBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            UpdateDeleteform.TextBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            UpdateDeleteform.TextBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            UpdateDeleteform.DateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
            {
                UpdateDeleteform.RadioButtonMale.Checked = true;
            }
            else
            {
                UpdateDeleteform.RadioButtonFemale.Checked = true;
            }

            UpdateDeleteform.TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            UpdateDeleteform.TextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //code hinh anh
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            UpdateDeleteform.PictureBoxStudentImage.Image = Image.FromStream(picture);
            this.Show();
            UpdateDeleteform.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
