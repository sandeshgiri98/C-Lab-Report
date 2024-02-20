using System;
using System.Data.SqlClient;

namespace DatabaseConnection4
{
    internal class DisplayById
    {
        public void ShowDetailsById()
        {
            string cs = "Data Source=NEXUS\\SQLEXPRESS;Initial Catalog=dotnet_swsc;Integrated Security=true;";
            try
            {
                using (SqlConnection sc = new SqlConnection(cs))
                {
                    sc.Open();
                    Console.WriteLine("Enter the ID of a person whose record you want to display:");
                    string id = Console.ReadLine();

                    // Select Query...
                    string displayQuery = "SELECT * FROM tbl_reg WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(displayQuery, sc);
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader row = cmd.ExecuteReader();
                    while (row.Read())
                    {
                        Console.WriteLine("ID: " + row["id"]);
                        Console.WriteLine("Username: " + row["username"]);
                        Console.WriteLine("Password: " + row["password"]);
                        Console.WriteLine("Repassword: " + row["repassword"]);
                        Console.WriteLine("Gender: " + row["gender"]);
                        Console.WriteLine("Course: " + row["course"]);
                        Console.WriteLine("Country: " + row["country"]);
                        Console.WriteLine("------------------------------------");
                    }
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
