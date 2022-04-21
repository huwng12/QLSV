using System;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace QLSV
{
    public partial class PrintStudentsForm : Form
    {
        public PrintStudentsForm()
        {
            InitializeComponent();
        }

        private void MaleradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        STUDENT student = new STUDENT();
        private void PrintStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet2.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.myDBDataSet2.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            fillGrid(command);
            //dieu khien cac radiobutton chuyen trang thai
            if(radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false; 
            }    
        }

        //xac dinh trang thai
        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }


        //Copy lai

        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 80;

            dataGridView1.DataSource = student.getStudents(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];

            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String query;
            if(radioButtonYes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("MM-dd-yyyy");
                string date2 = dateTimePicker2.Value.ToString("MM-dd-yyyy");

                if(radioButtonMale.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male' AND bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female' AND bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }    
                else
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }    

                command = new SqlCommand(query);
                fillGrid(command);
            }
            else //neu khong can theo Date
            {
                if(radioButtonMale.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male'";
                }    
                else if(radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female'";
                }    
                else
                {
                    query = "SELECT * FROM std"; //choose ALL
                }    

                command = new SqlCommand(query);
                fillGrid(command);
            } 
                

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\students_list.txt";

            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                DateTime bdate;
                //sinh vien nhin vao file huong dan lam tieu de cho cac cot

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("MM-dd-yyyy") + "\t" + "|");
                        }
                        else if (j == dataGridView1.Columns.Count - 2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.WriteLine("");
                    writer.WriteLine("-----------------------------------------------------------------------------");

                }
            }
            MessageBox.Show("File saved", "Save to File", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
