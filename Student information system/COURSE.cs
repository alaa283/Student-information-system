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
    class COURSE
    {
        MY_DB db = new MY_DB();


        //INSERT FUNCTION
        public bool insertCourse(string courseName, int hoursNumber, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`label`, `hours_number`, `description`) VALUES (@name,@hrs,@dscr)", db.getConnection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", MySqlDbType.Int32).Value = hoursNumber;
            command.Parameters.Add("@dscr", MySqlDbType.Text).Value = description;

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
