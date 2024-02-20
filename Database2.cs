using System;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseConnection2
{
    internal class InsertOperation
    {
        public void insert()
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

                Console.WriteLine("Enter your id:");
                string id = Console.ReadLine();

                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();

                Console.WriteLine("Enter your repassword:");
                string repassword = Console.ReadLine();

                Console.WriteLine("Enter your gender:");
                string gender = Console.ReadLine();

                Console.WriteLine("Enter your course:");
                string course = Console.ReadLine();

                Console.WriteLine("Enter your country:");
                string country = Console.ReadLine();

                // Query 
                string insQuery = "INSERT INTO tbl_reg VALUES (@id, @username, @password, @repassword, @gender, @course, @country)";
                SqlCommand cmd = new SqlCommand(insQuery, sc);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@username", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@repassword", repassword);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@country", country);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Data inserted");
                }
                sc.Close();
            }
            catch (SqlException s)
            {
                Console.WriteLine(s);
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
