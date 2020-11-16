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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../images/login.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn AND `password`= @pass", db.getConnection);

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxusername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxpassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
