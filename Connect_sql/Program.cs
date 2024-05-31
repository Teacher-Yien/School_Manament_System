using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=DESKTOP-T1JML11\\SQLEXPRESS;Initial Catalog=Etec;Integrated Security=True";


        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Perform database operations here

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}