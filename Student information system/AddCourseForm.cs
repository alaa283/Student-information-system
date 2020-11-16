using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_information_system
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCoursename_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownHours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            string courseLabel = textBoxCoursename.Text;
            int hours = (int)numericUpDownHours.Value;
            string description = textBoxDescription.Text;

            if (course.insertCourse(courseLabel, hours, description))
            {
                MessageBox.Show("New course inserted", "AAdd course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("course Not inserted", "AAdd course", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
