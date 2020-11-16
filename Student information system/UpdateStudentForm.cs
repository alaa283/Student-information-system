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
using System.IO;

namespace Student_information_system
{
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        Student student = new Student();

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //new student
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string gender = "Male";

            if (radioButton2.Checked)
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
                pictureBoxUploadImage.Image.Save(pic, pictureBoxUploadImage.Image.RawFormat);

                if (student.updateStudent(id, fname, lname, bdate, phone, gender, address, pic))
                {
                    MessageBox.Show(" Student information edit", "edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Filed", "edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        //function verfy data
        bool vreif()
        {
            if ((textBoxFname.Text.Trim() == "") ||
            (textBoxLname.Text.Trim() == "") ||
            (textBoxPhone.Text.Trim() == "") ||
            (textBoxAddress.Text.Trim() == "") ||
            (pictureBoxUploadImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            if (MessageBox.Show("Are you sure want delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (student.deleteStudent(id))
                {
                    MessageBox.Show(" Deleted Student", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxID.Text = "";
                    textBoxFname.Text = "";
                    textBoxLname.Text = "";
                    textBoxPhone.Text = "";
                    textBoxAddress.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    pictureBoxUploadImage.Image = null;
                }
                else
                {
                    MessageBox.Show("Student not deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MySqlCommand command = new MySqlCommand("SELECT `Id`, `first_name`, `last_name`, `birthdate`, `gender`, `phone`, `address`, `picture` FROM `student` WHERE `Id`=" + id);

                    DataTable table = student.getStudents(command);

                    if (table.Rows.Count > 0)
                    {
                        textBoxFname.Text = table.Rows[0]["firdt_nsme"].ToString();
                        textBoxLname.Text = table.Rows[0]["last_name"].ToString();
                        textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                        textBoxAddress.Text = table.Rows[0]["address"].ToString();

                        dateTimePicker1.Value = (DateTime)table.Rows[0]["birthdate"];

                        if (table.Rows[0]["gender"].ToString() == "Female")
                        {
                            radioButton2.Checked = true;
                        }
                        else
                        {
                            radioButton1.Checked = true;
                        }

                        byte[] pic;
                        pic = (byte[])table.Rows[0]["picture"];
                        MemoryStream picture = new MemoryStream(pic);
                        pictureBoxUploadImage.Image = Image.FromStream(picture);
                    }
                }
            }
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            //image
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif)";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUploadImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                MySqlCommand command = new MySqlCommand("SELECT `Id`, `first_name`, `last_name`, `birthdate`, `gender`, `phone`, `address`, `picture` FROM `student` WHERE `Id`=" + id);

                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    textBoxFname.Text = table.Rows[0]["first_name"].ToString();
                    textBoxLname.Text = table.Rows[0]["last_name"].ToString();
                    textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    textBoxAddress.Text = table.Rows[0]["address"].ToString();

                    dateTimePicker1.Value = (DateTime)table.Rows[0]["birthdate"];

                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton1.Checked = true;
                    }

                    byte[] pic;
                    pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxUploadImage.Image = Image.FromStream(picture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid student id", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}