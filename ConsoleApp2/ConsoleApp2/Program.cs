//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;


internal class Program
{
    private static void Main(string[] args)
    {
        //var stringCon = "Data Source=.;Initial Catalog=EMPLOYEE;Integrated Security=True;Encrypt=False;Context Connection=True";
        // var cnn = new SqlConnection();
        //  cnn.ConnectionString = stringCon;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T1JML11;Initial Catalog=Sa;Integrated Security=True;Encrypt=False");
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "InsertStudent";
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.VarChar, 36)
        {
            Direction = System.Data.ParameterDirection.Input,
            IsNullable = false
        });

        cmd.Parameters.Add(new SqlParameter("@firstname", System.Data.SqlDbType.NVarChar, 30)
        {
            Direction = System.Data.ParameterDirection.Input,
            IsNullable = true
        });
        cmd.Parameters.Add(new SqlParameter("@lastname", System.Data.SqlDbType.NVarChar, 30)
        {
            Direction = System.Data.ParameterDirection.Input,
            IsNullable = true
        });
        cmd.Parameters.Add(new SqlParameter("@gender", System.Data.SqlDbType.Int)
        {
            Direction = System.Data.ParameterDirection.Input,
            IsNullable = true
        });
        cmd.Parameters.Add(new SqlParameter("@age", System.Data.SqlDbType.TinyInt)
        {
            Direction = System.Data.ParameterDirection.Input,
            IsNullable = true
        });

        //Input students
        while (true)
        {
            Console.WriteLine("Student Data(id/firstname/lastname/gender/age)");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            var arr = input.Split('/');
            if (arr.Length >= 1)
            {
                var id = arr[0].Trim();
                string? fn = null; if (arr.Length >= 2) fn = arr[1].Trim();
                string? ln = null; if (arr.Length >= 3) ln = arr[2].Trim();
                int? gender = null;
                if (arr.Length >= 4)
                    if (int.TryParse(arr[3], out var tg) == true) gender = tg; ;
                byte? age = null;
                if (arr.Length >= 5)
                    if (byte.TryParse(arr[4], out byte ta) == true) age = ta;

                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@firstname"].Value = fn;
                cmd.Parameters["@lastname"].Value = ln;
                cmd.Parameters["@gender"].Value = gender;
                cmd.Parameters["@age"].Value = age;
                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Successfully");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error > " + ex.Message);
                }
            }
        }
    }
}