using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlProgram
{
    class CreateClass7
    {
        static void Main(string[] args)
        {
            new CreateClass7().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {

                con = new SqlConnection("Data Source=DESKTOP-JF0O8FC;Initial Catalog=Student;Integrated Security=True");

                SqlCommand cm = new SqlCommand("create table student10(id int not null,name varchar(100), age int)", con);

                con.Open();

                cm.ExecuteNonQuery();

                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }

            finally
            {
                con.Close();
            }
            Console.ReadKey();
        }
    }
}
