﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_Demo
{
    class Handl_Student3
    {
        static SqlConnection con;
        
        public static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection("data source=.; database=My_Database; integrated security=SSPI");
                con.Open();
                lable1:
                Console.WriteLine("----------Welcome to Student management---------- ");
                Console.WriteLine("1. Enter 1 for show table items ");
                Console.WriteLine("2. Enter 2 for Insert data ");
                Console.WriteLine("3. Enter 3 for delete data  ");
                Console.WriteLine("4. Enter 4 Exit ");
                int no = 0;
                int acc_var;
                while (no == 0)
                {
                    
                    acc_var = Int32.Parse(Console.ReadLine());
                    switch (acc_var)
                    {
                        case 1:
                            select_data();
                            goto lable1;
                          //  break;
                        case 2:
                            Insert_data();
                            goto lable1;
                          //  break;
                        case 3:
                            delete_data();
                            goto lable1;
                        //break;
                        case 4:
                            no = 1;
                            break;

                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Bye");
                con.Close();

                Console.ReadLine();

            }


        }
        public static void select_data()
        {
            SqlCommand cm = new SqlCommand("Select * from student3", con);
            // Opening Connection  
        
            // Executing the SQL query  
            SqlDataReader sdr = cm.ExecuteReader();
            // Iterating Data  
            while (sdr.Read())
            {

                Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]); // Displaying Record  
            }
            Console.ReadLine();
            Console.Clear();
            

        }
        public static void Insert_data()
        {
            DateTime d = new DateTime();
            char ch = 'y';
            while (ch.Equals('y'))
            {
                Console.WriteLine("Enter ID");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name ");
                string name = Console.ReadLine();
                Console.WriteLine("email");
                string email = Console.ReadLine();
                Console.WriteLine("Enter join date");
                d = DateTime.Parse(Console.ReadLine());
                SqlCommand cm = new SqlCommand("insert into student3(id, name, email, join_date)values('" + id + "', '" + name + "', '" + email + "', '" + d + "')", con);
                // Opening Connection  

                // Executing the SQL query  
                cm.ExecuteNonQuery();
                Console.WriteLine("Enter more value to y  or not for n  <y/n>");
                ch = char.Parse(Console.ReadLine());
            }
            // Displaying a message  
            Console.WriteLine("All Record Inserted Successfully");
            Console.ReadLine();
            Console.Clear();

        }
        public static void delete_data()
        {
            Console.WriteLine("Enter Id to remove ");
            string id = Console.ReadLine();
            SqlCommand cm = new SqlCommand("delete from student3 where id = '"+id+"'", con);
            // Opening Connection  
            
            // Executing the SQL query  
            cm.ExecuteNonQuery();
            Console.WriteLine("Record Deleted Successfully");
            Console.ReadLine();
            Console.Clear();

        }

    }
}
