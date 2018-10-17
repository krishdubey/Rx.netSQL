using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SqlProgram
{
    class InsertThroughCommandClass1
    {
        static void Main(string[] args)
        {
            new InsertThroughCommandClass1().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {

                con = new SqlConnection("data source=DESKTOP-JF0O8FC; database=Student; integrated security=true");

                String id, name, age;               

                con.Open();
                do
                {
                    Console.WriteLine("please enter id");
                    id = Console.ReadLine();
                    Console.WriteLine("please enter name");
                    name = Console.ReadLine();
                    Console.WriteLine("please enter age");
                    age = Console.ReadLine();
                    //  sql = "INSERT INTO student10 VALUES(" + id + ",'" + name + "' , " + age + ")";
                    SqlCommand cm = new SqlCommand("INSERT INTO student10 VALUES(" + id + ",'" + name + "' , " + age + ")", con);
                    cm.ExecuteNonQuery();
                    Console.WriteLine("do you want to insert one more(yes/no)?");

                }
                while ("yes".Equals(Console.ReadLine()));
                
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
