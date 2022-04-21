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
    public partial class MainForm01 : Form
    {
        public MainForm01()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.Show();
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsListForm form = new studentsListForm();
            form.Show();
        }

        private void MainForm01_Load(object sender, EventArgs e)
        {

        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm StdSF = new StaticsForm();
            StdSF.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm MNStd = new ManageStudentsForm();
            MNStd.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentsForm printStudentsForm = new PrintStudentsForm();
            printStudentsForm.Show();
        }

        private void aDDCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
