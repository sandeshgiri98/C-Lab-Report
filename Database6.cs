using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
namespace DatabaseConnection6
{
    internal class DeleteById
    {
        public void Delete()
        {
            try
            {
                string cs = "Data Source =NEXUS\\SQLEXPRESS;Initial Catalog = dotnet_swsc; Integrated Security = true; "; 
                SqlConnection sc = new SqlConnection(cs);

                if (sc.State == ConnectionState.Open)
                {
                    Console.WriteLine("server connected");
                }
                sc.Open();
                Console.WriteLine("enter id to delete record..");
                string delid = Console.ReadLine();

                string deleteQuery = "delete from tbl_reg where id =@id"; SqlCommand cmd = new SqlCommand(deleteQuery, sc); cmd.Parameters.AddWithValue("@id", delid); int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Deleted Successfully");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }
    class program
    {
        public static void Main(String[] args)
        {
        }
    }
}
