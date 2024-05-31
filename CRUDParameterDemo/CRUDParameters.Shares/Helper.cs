using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EnrollLibrary
{
    public static class Helper
    {
        public static string ConnectionStringKey { get; set; } = "ConnectionString";
        public static IConfiguration? Configuration { get; set; } = null;

        public static SqlConnection? Connection { get; private set; } = null;
        public static void LoadConfiguration(string jsonFile)
        {
            var builder = new ConfigurationBuilder()
              .AddJsonFile(jsonFile, optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }
        public static SqlConnection OpenConnection()
        {
            try
            {
                string connStr = Configuration.GetRequiredSection(ConnectionStringKey).Value;
                var conn = new SqlConnection(connStr);
                conn.Open();
                Connection = conn;
                return conn;
            }
            catch (Exception ex)
            {
                Connection = null;
                throw new Exception($"Failed to connect to the server > {ex.Message}");
            }
        }
        private static StoredProcedureSetting GetStoredProcedureSetting()
        {
            var procSettingSection = Configuration.GetRequiredSection("StoredProcedureSettings");
            var procSetting = procSettingSection.Get<StoredProcedureSetting>();
            return procSetting;
        } 
        public static int CreateProcedures()
        {
            var procAction = GetStoredProcedureSetting().StudentStoredProcedureAction;
            var cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.Text;
           
            int result = 0;
            if (procAction != null)
            {
                
                foreach (var script in new string[] {
                    string.Format(procAction.ReadAll.Script, procAction.ReadAll.Name),
                    string.Format(procAction.ReadById.Script, procAction.ReadById.Name),
                    string.Format(procAction.Insert.Script, procAction.Insert.Name),
                    string.Format(procAction.Delete.Script, procAction.Delete.Name),
                    string.Format(procAction.Update.Script, procAction.Update.Name)
                    })
                {
                    cmd.CommandText = script;
                    try
                    {
                        result += cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return Math.Abs(result);
        }

        private static Dictionary<string, SqlCommand> commands = new();
        public static void GenerateRequiredCommands()
        {
            var stuProcAction = GetStoredProcedureSetting().StudentStoredProcedureAction;
            SqlCommand cmd = default!;

            #region [Command for Stored Procedure to get all students]
            cmd =new SqlCommand(stuProcAction.ReadAll.Name, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            commands.Add(nameof(GetAllStudents), cmd);
            #endregion

            #region [Command for  Stored Procedure to get student by given id]
            cmd = new SqlCommand(stuProcAction.ReadById.Name, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar, 36)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            commands.Add(nameof(GetStudentById), cmd);
            #endregion

            #region [Command for Stored Procedure to insert a new student]
            cmd = new SqlCommand(stuProcAction.Insert.Name, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar, 36)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@firstname", SqlDbType.VarChar, 30)
            {
                Direction = ParameterDirection.Input,
                IsNullable = true
            });
            cmd.Parameters.Add(new SqlParameter("@lastname", SqlDbType.VarChar, 30)
            {
                Direction = ParameterDirection.Input,
                IsNullable = true
            });
            cmd.Parameters.Add(new SqlParameter("@gender", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = true
            });
            cmd.Parameters.Add(new SqlParameter("@age", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = true
            });
            commands.Add(nameof(AddStudent), cmd);
            #endregion

            #region [Command for Stored Producedure to update an existing student]
            cmd = new SqlCommand(stuProcAction.Update.Name, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar, 36)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            cmd.Parameters.Add(new SqlParameter("@firstname", SqlDbType.VarChar, 30)
            {
                Direction = ParameterDirection.Input,
                IsNullable = true
            });
            cmd.Parameters.Add(new SqlParameter("@lastname", SqlDbType.VarChar, 30)
            {
                Direction = ParameterDirection.Input,
                IsNullable = true
            });
            cmd.Parameters.Add(new SqlParameter("@gender", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = true
            });
            cmd.Parameters.Add(new SqlParameter("@age", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = true
            });
            commands.Add(nameof(UpdateStudent), cmd);
            #endregion

            #region [Command for Stored Procedure to delete an existing student]
            cmd = new SqlCommand(stuProcAction.Delete.Name, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar, 36)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false
            });
            commands.Add(nameof(DeleteStudent), cmd);
            #endregion

            #region [Command for script to delete some existing students]
            cmd = new SqlCommand("delete students where id in ({0})", Connection);
            cmd.CommandType = CommandType.Text;
            commands.Add(nameof(DeleteStudents), cmd);
            #endregion
        }

        #region events
        public static event EventHandler<EntityEventArgs>? Added;
        public static event EventHandler<EntityEventArgs>? Updated;
        public static event EventHandler<EntityEventArgs>? Deleted;
        #endregion

        #region crud(students)
        public static IEnumerable<Student> GetAllStudents(SqlConnection conn)
        {
            SqlCommand cmd = commands[nameof(GetAllStudents)];
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all students > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }

            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToStudent();//ToStudent() is a custom extension method of the class IDataRecordExtension
                }
            }
            reader?.Close();
        }

        public static Student? GetStudentById(SqlConnection conn, string id)
        {
            SqlCommand cmd = commands[nameof(GetStudentById)];
            cmd.Parameters["@id"].Value = id;

            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting student with id, {id} > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
            Student? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = (reader as IDataRecord).ToStudent();
                }
            }
            reader?.Close();
            return result;
        }
        public static string? AddStudent(SqlConnection conn, Student student)
        {
            SqlCommand cmd = commands[nameof(AddStudent)];
            cmd.Parameters["@id"].Value = student.Id;
            cmd.Parameters["@firstname"].Value = student.FirstName;
            cmd.Parameters["@lastname"].Value = student.LastName;
            cmd.Parameters["@gender"].Value = student.Gender;
            cmd.Parameters["@age"].Value = student.Age;
            try
            {
                int effected = cmd.ExecuteNonQuery();
                if (effected > 0) Added?.Invoke(null, new EntityEventArgs() { Id = student.Id, Entity = EntityTypes.Students });
                return (effected > 0) ? student.Id : null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new student > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }

        public static bool UpdateStudent(SqlConnection conn, Student student)
        {
            SqlCommand cmd = commands[nameof(UpdateStudent)];
            cmd.Parameters["@id"].Value = student.Id;
            cmd.Parameters["@firstname"].Value = student.FirstName;
            cmd.Parameters["@lastname"].Value = student.LastName;
            cmd.Parameters["@gender"].Value = student.Gender;
            cmd.Parameters["@age"].Value = student.Age;
            try
            {
                int effected = cmd.ExecuteNonQuery();
                if (effected > 0) Updated?.Invoke(null, new EntityEventArgs() { Id = student.Id, Entity = EntityTypes.Students });
                return (effected > 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating existing student > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }

        public static bool DeleteStudent(SqlConnection conn, string id)
        {
            SqlCommand cmd = commands[nameof(DeleteStudent)];
            cmd.Parameters["@id"].Value = id;
            try
            {
                int effected = cmd.ExecuteNonQuery();
                if (effected > 0) Deleted?.Invoke(null, new EntityEventArgs() { Id = id, Entity = EntityTypes.Students });
                return (effected > 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting existing student with id {id}> {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }

        public static int DeleteStudents(SqlConnection conn, IEnumerable<string> ids)
        {
            if (ids.Count() == 0) return 0;
            var idSet = ids.Distinct().Select(x => $"'{x}'").ToList().Aggregate((a, b) => a + ", " + b);
            SqlCommand cmd = commands[nameof(DeleteStudents)];
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format(cmd.CommandText, idSet);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                if (effected > 0) Deleted?.Invoke(null, new EntityEventArgs() { Id = null, Entity = EntityTypes.Students });
                return effected;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting existing studentស > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }
        #endregion
    }

}