using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlProgram
{
    class LeftOuterJoinClass1
    {
        static void Main(string[] args)
        {
            new LeftOuterJoinClass1().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {

                con = new SqlConnection("data source=DESKTOP-JF0O8FC; database=Student; integrated security=true");

                SqlCommand cm = new SqlCommand("SELECT StudentCourse.COURSE_ID,StudentTable.NAME,StudentTable.Age,StudentTable.PHONE,StudentTable.ADDRESS, StudentTable.ROLL_NO FROM StudentTable LEFT JOIN StudentCourse ON StudentTable.ROLL_NO = StudentCourse.ROLL_NO", con);

                con.Open();

                SqlDataReader sdr = cm.ExecuteReader();

                while (sdr.Read())
                {
                    Console.WriteLine(sdr["ROLL_NO"] + " " + sdr["NAME"] + " " + sdr["Age"] + " " + sdr["PHONE"] + " " + sdr["ADDRESS"] + " " + sdr["COURSE_ID"]); // Displaying Record  
                }

                //Console.WriteLine("Recorded Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }

            finally
            {
                con.Close();
            }
        }
    }
}
