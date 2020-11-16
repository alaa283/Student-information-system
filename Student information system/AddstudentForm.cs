using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_information_system
{
    public partial class AddstudentForm : Form
    {
        public AddstudentForm()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            //new student
            Student student = new Student();
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string gender = "Male";

            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            // year month day
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("Student Age Must be Bettween 10 and 100 years", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (vreif())
            {
                pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);

                if (student.insertStudent(fname, lname, bdate, phone, gender, address, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Filed", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            //function verfy data
            bool vreif()
            {
                if ((textBoxFname.Text.Trim() == "") ||
                (textBoxLname.Text.Trim() == "") ||
                (textBoxPhone.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "") ||
                (pictureBoxStudentImage.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            //image
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif)";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
