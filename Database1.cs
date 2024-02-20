using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    internal class CreateTable
    {
        public void TableCreate()
        {
            string cs = "Data Source=NEXUS\\SQLEXPRESS;Initial Catalog=dotnet_swsc;Integrated Security=true;";
            try
            {
                SqlConnection sc = new SqlConnection(cs);

                if (sc.State == ConnectionState.Open)
                {
                    Console.WriteLine("Server connected");
                }
                sc.Open();
                string tblquery = "CREATE TABLE tbl_reg(id INT PRIMARY KEY, " +
                                  "username VARCHAR(50), " +
                                  "password VARCHAR(50), " +
                                  "repassword VARCHAR(50), " +
                                  "gender VARCHAR(50), " +
                                  "course VARCHAR(50), " +
                                  "country VARCHAR(50))";
                SqlCommand cmd = new SqlCommand(tblquery, sc);

                int res = cmd.ExecuteNonQuery();
                if (res == -1)
                {
                    Console.WriteLine("Table created");
                }
                else
                {
                    Console.WriteLine("Table creation failed");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
           
        }
    }
}
