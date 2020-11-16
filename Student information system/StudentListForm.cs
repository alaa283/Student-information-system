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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        Student student = new Student();

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateStudentForm updateS = new UpdateStudentForm();
            updateS.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateS.textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateS.textBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateS.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                updateS.radioButton2.Checked = true;
            }

            updateS.textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateS.textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateS.pictureBoxUploadImage.Image = Image.FromStream(picture);
            updateS.Show();
        }
    }
}
