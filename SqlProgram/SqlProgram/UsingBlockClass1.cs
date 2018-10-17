using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlProgram
{
    class UsingBlockClass1
    {
        static void Main(string[] args)
        {
            new UsingBlockClass1().Connecting();
        }
        public void Connecting()
        {
            using (
                     // Creating Connection  
                     SqlConnection con = new SqlConnection("data source=DESKTOP-JF0O8FC; database=Student; integrated security=true")
                 )
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
        }
    }
}
