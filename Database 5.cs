using System;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseConnection5
{
    internal class UpdateOperation
    {
        public void update()
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

                Console.WriteLine("Enter the id to update the details: ");
                string uplid = Console.ReadLine();
                Console.WriteLine("Enter the username: ");
                string upusername = Console.ReadLine();
                Console.WriteLine("Enter the Course: ");
                string upcourse = Console.ReadLine();

                string upQuery = "UPDATE tbl_reg SET username = @upusername, course = @upcourse WHERE id = @uplid";
                SqlCommand cmd = new SqlCommand(upQuery, sc);

                cmd.Parameters.AddWithValue("@upusername", upusername);
                cmd.Parameters.AddWithValue("@upcourse", upcourse);
                cmd.Parameters.AddWithValue("@uplid", uplid);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Data updated");
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
