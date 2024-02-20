using System;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseConnection3
{
    internal class DisplayOperation
    {
        public void display()
        {
            try
            {
                string cs = "Data Source=NEXUS\\SQLEXPRESS;Initial Catalog=dotnet_swsc;Integrated Security=true;";
                SqlConnection sc = new SqlConnection(cs);

                if (sc.State == ConnectionState.Open)
                {
                    Console.WriteLine("Server connected");
                }

                sc.Open();

                string disQuery = "SELECT * FROM tbl_reg";
                SqlCommand cmd = new SqlCommand(disQuery, sc);

                SqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    Console.WriteLine("id is " + row["id"]);
                    Console.WriteLine("username is " + row["username"]);
                    Console.WriteLine("password is " + row["password"]);
                    Console.WriteLine("repassword is " + row["repassword"]);
                    Console.WriteLine("gender is " + row["gender"]);
                    Console.WriteLine("course is " + row["course"]);
                    Console.WriteLine("country is " + row["country"]);
                    Console.WriteLine("------------------------------------");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
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
