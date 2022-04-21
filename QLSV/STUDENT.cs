using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace QLSV
{
    internal class STUDENT
    {
        MY_DB mydb = new MY_DB();

        //function to insert a new student
        public bool insertStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" +
                "VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic) ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }

        public bool DeleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id =  @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }

        public bool EditStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname=@fn,lname=@ln,bdate=@bdt,gender=@gdr,phone=@phn," +
                "address=@adrs,picture=@pic WHERE id=@ID", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        //public bool UpdateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        //{
        //    SqlCommand command = new SqlCommand("UPDATE Student SET Id=@id,fname=@fn,lname=@ln,bdate=@bdt,gender=@gdr,phone=@phn,address=@adrs,picture=@pic WHERE Id=@TextBoxID", mydb.getConnection);
        //    command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
        //    command.Parameters.Add("@TextBoxID", SqlDbType.Int).Value = Id;
        //    command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
        //    command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
        //    command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
        //    command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
        //    command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
        //    command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
        //    command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
        //    mydb.openConnection();
        //    if ((command.ExecuteNonQuery() == 1))
        //    {
        //        mydb.closeConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        mydb.closeConnection();
        //        return false;
        //    }
        //}

        //function to get all the students form databases
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        string execCount(string query)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }

        public string totalStudent()
        {
            string d= execCount("SELECT COUNT(*) FROM STD");
            mydb.closeConnection();
            return d;
        }
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender='Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender='Female'");
        }
    }
}
