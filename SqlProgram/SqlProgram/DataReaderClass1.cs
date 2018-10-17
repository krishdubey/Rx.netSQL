using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlProgram
{
    class DataReaderClass1
    {
        static void Main(string[] args)
        {
            new DataReaderClass1().GetData();
        }
        public void GetData()
        {
            SqlConnection con = null;
            try
            {
                
                con = new SqlConnection("data source=DESKTOP-JF0O8FC; database=Student; integrated security=true");
                  
                SqlCommand cm = new SqlCommand("select * from student6", con);
                  
                con.Open();

                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["name"] + " " + sdr["email"]);
                }
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
