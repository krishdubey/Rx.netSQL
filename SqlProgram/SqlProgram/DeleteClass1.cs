using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlProgram
{
    class DeleteClass1
    {
        static void Main(string[] args)
        {
            new DeleteClass1().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                  
                con = new SqlConnection("data source=DESKTOP-JF0O8FC; database=Student; integrated security=true");
                
                SqlCommand cm = new SqlCommand("delete from student6 where id = '106'", con);
                SqlCommand cm1 = new SqlCommand("Select * from student6", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully");
                SqlDataReader sdr = cm1.ExecuteReader();
                
               
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]); // Displaying Record  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
           
            finally
            {
                con.Close();
            }
        }
    }
}
