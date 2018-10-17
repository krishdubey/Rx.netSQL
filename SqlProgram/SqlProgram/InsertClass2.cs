using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SqlProgram
{
    class InsertClass2
    {
        static void Main(string[] args)
        {
            new InsertClass2().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                
                con = new SqlConnection("data source=DESKTOP-JF0O8FC; database=Student; integrated security=true");
                 
                SqlCommand cm = new SqlCommand("insert into student6(id, name, email, join_date)values('102', 'Krishna', 'krishdubey95@gmail.com', '1/12/2017')", con);
                SqlCommand cm1 = new SqlCommand("insert into student6(id, name, email, join_date)values('103', 'Ankur', 'ankur@gmail.com', '1/12/2017')", con);
                SqlCommand cm2 = new SqlCommand("insert into student6(id, name, email, join_date)values('104', 'Jay', 'jay@example.com', '1/12/2017')", con);
                SqlCommand cm3 = new SqlCommand("insert into student6(id, name, email, join_date)values('105', 'Surendar', 'sd@example.com', '1/12/2017')", con);
                SqlCommand cm4 = new SqlCommand("insert into student6(id, name, email, join_date)values('106', 'Atul', 'ron@example.com', '1/12/2017')", con);
                SqlCommand cm5 = new SqlCommand("insert into student6(id, name, email, join_date)values('107', 'Vinay', 'nld@example.com', '1/12/2017')", con);
                SqlCommand cm6 = new SqlCommand("insert into student6(id, name, email, join_date)values('108', 'Raju', 'ro@example.com', '1/12/2017')", con);

                con.Open();
               
                cm.ExecuteNonQuery();
                cm1.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();
                cm5.ExecuteNonQuery();
                cm6.ExecuteNonQuery();

                Console.WriteLine("Record Inserted Successfully");
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
