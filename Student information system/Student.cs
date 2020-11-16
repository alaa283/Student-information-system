using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_information_system
{
    class Student
    {
        MY_DB db = new MY_DB();

        //create function to add a new student
        public bool insertStudent(string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`( `first_name`, `last_name`, `birthdate`, `gender`, `phone`, `address`, `picture`) VALUES (@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic)", db.getConnection);

            //@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = bdate;

            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;

            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        // display student
        public DataTable getStudents(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adpter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adpter.Fill(table);

            return table;
        }

        //create function to update a new student
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `first_name`=@fn,`last_name`=@ln,`birthdate`=@bdt,`gender`=@gdr,`phone`=@phn,`address`=@adrs,`picture`=@pic WHERE Id=@id", db.getConnection);

            //@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic,@id

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = bdate;

            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;

            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        //function delete
        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE Id=@idStudent", db.getConnection);

            //@idStudent

            command.Parameters.Add("@idStudent", MySqlDbType.Int32).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
