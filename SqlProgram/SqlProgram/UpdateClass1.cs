using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlProgram
{
    class UpdateClass1
    {
        static void Main(string[] args)
        {
            new UpdateClass1().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                  
                con = new SqlConnection("data source=DESKTOP-JF0O8FC; database=Student; integrated security=true");
                 
                SqlCommand cm = new SqlCommand("UPDATE student6 SET name = 'MANOHAR' WHERE id = '102'", con);
                
                con.Open();
                  
                cm.ExecuteNonQuery();
                  
                Console.WriteLine("Record Update Successfully");
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
