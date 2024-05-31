using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EnrollLibrary
{
    public static class Helper
    {
        public static string ConnectionStringKey { get; set; } = "ConnectionString";
        public static IConfiguration? Configuration { get; set; } = null;
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
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to connect to the server > {ex.Message}");
            }
        }

        #region events
        public static event EventHandler<EntityEventArgs>? Added;
        public static event EventHandler<EntityEventArgs>? Updated;
        public static event EventHandler<EntityEventArgs>? Deleted;
        #endregion

        #region crud(students)
        private const string STU_TBL_NAME = "students";
        private const string STU_ID_FIELD = "id";
        private const string STU_FNAME_FIELD = "firstname";
        private const string STU_LNAME_FIELD = "lastname";
        private const string STU_GENDER_FIELD = "gender";
        private const string STU_AGE_FIELD = "age";
        private const string STU_READ_SCRIPT = $"select {STU_ID_FIELD},{STU_FNAME_FIELD},{STU_LNAME_FIELD},{STU_GENDER_FIELD},{STU_AGE_FIELD} from {STU_TBL_NAME}";
        private static string STU_READ_BY_ID_SCRIPT = $"select top 1 {STU_ID_FIELD},{STU_FNAME_FIELD},{STU_LNAME_FIELD},{STU_GENDER_FIELD},{STU_AGE_FIELD} from {STU_TBL_NAME} where {STU_ID_FIELD}={{0}}";
        private static string STU_CREATE_SCRIPT = $"insert into {STU_TBL_NAME} values({{0}}, {{1}}, {{2}}, {{3}}, {{4}})";
        private static string STU_UPDATE_SCRIPT = $"update {STU_TBL_NAME} set {STU_FNAME_FIELD}={{1}}, {STU_LNAME_FIELD}={{2}}, {STU_GENDER_FIELD}={{3}}, {STU_AGE_FIELD}={{4}} where {STU_ID_FIELD}={{0}}";
        private static string STU_DELETE_ONE_SCRIPT = $"delete {STU_TBL_NAME} where {STU_ID_FIELD}={{0}}";
        private static string STU_DELETE_MANY_SCRIPT = $"delete {STU_TBL_NAME} where {STU_ID_FIELD} in ({{0}})";
        //Read all students
        public static IEnumerable<Student> GetAllStudents(SqlConnection conn)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = STU_READ_SCRIPT;
            cmd.CommandType = CommandType.Text;

            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all students > {ex.Message}");
            }
            
            if (reader != null && reader.HasRows == true)
            {
                while (reader.Read())
                {
                    var id = reader.GetString(STU_ID_FIELD);
                    string? firstname = null;
                    if (!reader.IsDBNull(STU_FNAME_FIELD)) firstname = reader.GetString(STU_FNAME_FIELD);
                    string? lastname = null;
                    if (!reader.IsDBNull(STU_LNAME_FIELD)) lastname = reader.GetString(STU_LNAME_FIELD);
                    Genders? gender = null;
                    if (!reader.IsDBNull(STU_GENDER_FIELD)) gender = (Genders?)reader.GetInt32(STU_GENDER_FIELD);
                    byte? age = null;
                    if (!reader.IsDBNull(STU_AGE_FIELD)) age = reader.GetByte(STU_AGE_FIELD);
                    yield return new Student()
                    {
                        Id = id,
                        FirstName = firstname,
                        LastName = lastname,
                        Gender = gender,
                        Age = age
                    };
                }
            }
            reader?.Close();
        }
        
        //Read a specified student
        public static Student? GetStudentById(SqlConnection conn, string id)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format(STU_READ_BY_ID_SCRIPT, $"'{id}'");
            cmd.CommandType = CommandType.Text;

            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting student with id, {id} > {ex.Message}");
            }
            Student? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    string? firstname = null;
                    if (!reader.IsDBNull(STU_FNAME_FIELD)) firstname = reader.GetString(STU_FNAME_FIELD);
                    string? lastname = null;
                    if (!reader.IsDBNull(STU_LNAME_FIELD)) lastname = reader.GetString(STU_LNAME_FIELD);
                    Genders? gender = null;
                    if (!reader.IsDBNull(STU_GENDER_FIELD)) gender = (Genders?)reader.GetInt32(STU_GENDER_FIELD);
                    byte? age = null;
                    if (!reader.IsDBNull(STU_AGE_FIELD)) age = reader.GetByte(STU_AGE_FIELD);
                    result = new Student()
                    {
                        Id = id,
                        FirstName = firstname,
                        LastName = lastname,
                        Gender = gender,
                        Age = age
                    };
                }
            }
            reader?.Close();
            return result;
        }
        
        //Create a new student
        public static string? AddStudent(SqlConnection conn, Student student)
        {
            dynamic id = $"'{student.Id}'";
            dynamic fname = (student.FirstName == null) ? "NULL" : $"'{student.FirstName}'";
            dynamic lname = (student.LastName == null) ? "NULL" : $"'{student.LastName}'";
            dynamic gender = (student.Gender == null) ? "NULL" : (int)student.Gender;
            dynamic age = (student.Age==null)? "NULL" : student.Age;
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format(STU_CREATE_SCRIPT, id, fname, lname, gender, age);
            cmd.CommandType = CommandType.Text;
            try
            {
                int effected = cmd.ExecuteNonQuery();
                if (effected > 0) 
                    Added?.Invoke(null, new EntityEventArgs() { Id = student.Id , Entity = EntityTypes.Students });
                return (effected > 0) ? student.Id : null; 
            }
            catch(Exception ex)
            {
                throw new Exception($"Failed in adding new student > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }

        //Update an existing student
        public static bool UpdateStudent(SqlConnection conn, Student student)
        {
            dynamic id = $"'{student.Id}'";
            dynamic fname = (student.FirstName == null) ? "NULL" : $"'{student.FirstName}'";
            dynamic lname = (student.LastName == null) ? "NULL" : $"'{student.LastName}'";
            dynamic gender = (student.Gender == null) ? "NULL" : (int)student.Gender;
            dynamic age = (student.Age == null) ? "NULL" : student.Age;

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format(STU_UPDATE_SCRIPT, id, fname, lname, gender, age);
            cmd.CommandType = CommandType.Text;
            try
            {
                int effected = cmd.ExecuteNonQuery();
                if (effected > 0) 
                    Updated?.Invoke(null, new EntityEventArgs() { Id =student.Id, Entity = EntityTypes.Students });
                return (effected > 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating existing student with the id {student.Id} > {ex.Message}");
            }
        }

        //Delete an existing student
        public static bool DeleteStudent(SqlConnection conn, string id)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format(STU_DELETE_ONE_SCRIPT, $"'{id}'");
            cmd.CommandType = CommandType.Text;
            try
            {
                int effected = cmd.ExecuteNonQuery();
                if (effected > 0) 
                    Deleted?.Invoke(null, new EntityEventArgs() { Id = id, Entity = EntityTypes.Students });
                return (effected > 0); 
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting a student with id {id} > {ex.Message}");
            }
        }

        //Delete several existing students
        public static int DeleteStudents(SqlConnection conn, IEnumerable<string> ids)
        {
            if (ids.Count() == 0) return 0;
            var idSet = ids.Distinct().Select(x=>$"'{x}'").ToList().Aggregate((a, b) => a + ", " + b);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format(STU_DELETE_MANY_SCRIPT, idSet);
            cmd.CommandType = CommandType.Text;
            try
            {
                int effected = cmd.ExecuteNonQuery();
                if (effected > 0) 
                    Deleted?.Invoke(null, new EntityEventArgs() { Id = idSet, Entity = EntityTypes.Students });
                return effected;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in deleting existing students > {ex.Message}");
            }
        }
        #endregion
    }

}