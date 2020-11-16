using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_information_system
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddstudentForm addstdf = new AddstudentForm();
            addstdf.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm stdlistf = new StudentListForm();
            stdlistf.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm stcf = new StaticsForm();
            stcf.Show();

        }

        private void manageStudentsFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudentForm usf = new UpdateStudentForm();
            usf.Show(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ManageStudentform_Click(object sender, EventArgs e)
        {
            ManageStudentsForm mngstdf = new ManageStudentsForm();
            mngstdf.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintStudentsForm Pstdf = new PrintStudentsForm();
            Pstdf.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCf = new AddCourseForm();
            addCf.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCrsF = new EditCourseForm();
            editCrsF.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm rmvCrF = new RemoveCourseForm();
            rmvCrF.Show(this);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addScrF = new AddScoreForm();
            addScrF.Show(this);

        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm rmvScrF = new RemoveScoreForm();
            rmvScrF.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm mngscrF = new ManageScoreForm();
            mngscrF.Show(this);
        }
    }
}
