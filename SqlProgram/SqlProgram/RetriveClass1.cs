using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlProgram
{
    class RetriveClass1
    {
        static void Main(string[] args)
        {
            new RetriveClass1().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
               
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                
                SqlCommand cm = new SqlCommand("Select * from student6", con);
                
                con.Open();
                 
                SqlDataReader sdr = cm.ExecuteReader();

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
