using EnrollLibrary;
using Microsoft.Data.SqlClient;

namespace ConsoleCRUD
{
    internal class Program
    {
        static SqlConnection conn = null!;
        static Student? effectedStu = null;
        static void Main(string[] args)
        {
            Initialize();
            
            Console.WriteLine();
            ViewStudents();
            Pause();

            Console.WriteLine();
            Helper.Added += OnStudentAdded;
            InsertStudent();
            Pause();

            Console.WriteLine();
            ViewStudents();
            Pause();

            Console.WriteLine();
            Helper.Updated += OnStudentUpdated;
            UpdateStudent();
            Pause();

            Console.WriteLine();
            ViewStudents();
            Pause();

            Console.WriteLine();
            Helper.Deleted += OnStudentDeleted;
            DeleteStudent();
            Pause();

            Console.WriteLine();
            ViewStudents();
            Pause();
        }

        private static void OnStudentDeleted(object? sender, EntityEventArgs e)
        {
            if (e.Entity == EntityTypes.Students && e.Id != null)
            {
                try
                {
                    var result = Helper.GetStudentById(conn, e.Id);
                    if (result==null)
                    {
                        Console.WriteLine($"There is no longer existed the student with the id {e.Id}");
                    }
                }
                catch (Exception) { }
            }
        }

        private static void OnStudentUpdated(object? sender, EntityEventArgs e)
        {
            if (e.Entity == EntityTypes.Students && e.Id != null)
            {
                try
                {
                    effectedStu = Helper.GetStudentById(conn, e.Id);
                    if (effectedStu != null)
                    {
                        Console.WriteLine($"Updated student> name:{effectedStu.FirstName + " " + effectedStu.LastName}, gender={effectedStu.Gender}, age:{effectedStu.Age}");
                    }
                }
                catch (Exception) { }
            }
        }

        private static void OnStudentAdded(object? sender, EntityEventArgs e)
        {
            if (e.Entity == EntityTypes.Students && e.Id != null)
            {
                try
                {
                    effectedStu = Helper.GetStudentById(conn, e.Id);
                    if (effectedStu != null)
                    {
                        Console.WriteLine($"Added student named  {effectedStu.FirstName + " " + effectedStu.LastName}");
                    }
                }
                catch (Exception) { }
            }
        }

        static void DeleteStudent()
        {
            if (effectedStu == null) return;
            Console.WriteLine("Deleting a student...");

            try
            {
                var result = Helper.DeleteStudent(conn, effectedStu.Id);
                if (result == true)
                    Console.WriteLine($"Successfully deleted an existing student with the id {effectedStu.Id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to delete an existing student > {ex.Message}");
            }
        }
        static void UpdateStudent()
        {
            if (effectedStu == null) return;
            Console.WriteLine("Updating a student's data...");
            effectedStu.Gender = Genders.Female;
            effectedStu.Age = 39;
           
            try
            {
                var result = Helper.UpdateStudent(conn, effectedStu);
                if (result==true)
                    Console.WriteLine($"Successfully updated an existing student with the id {effectedStu.Id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to update an existing student > {ex.Message}");
            }
        }
        static void InsertStudent()
        {
            Console.WriteLine("Adding new student...");
            var newStu = new Student()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName= "SokChantha",
                LastName ="Keo",
                Gender =null,
                Age=null 
            };
            try
            {
                var id = Helper.AddStudent(conn, newStu);
                if (id!=null) 
                    Console.WriteLine($"Successfully added a new student with the id {id}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Failed to add a new student > {ex.Message}");
            }
        }
        static void ViewStudents()
        {
            try
            {
                var result = Helper.GetAllStudents(conn);
                Console.WriteLine($"{"[Id]",-36} {"[First Name]",-30} {"[Last Name]",-30} {"Gender",-7} {"Age",-3}");
                Console.WriteLine(new string('=', 36 + 1 + 30 + 1 + 30 + 1 + 7 + 1 + 3));
                foreach(var stu in result)
                {
                    Console.WriteLine($"{stu.Id,-30} {stu.FirstName,-30} {stu.LastName,-30} {stu.Gender,-7} {stu.Age,3}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to get all student to view > {ex.Message}");
            }
        }
        static void Initialize()
        {
            Helper.ConnectionStringKey = "ConnectionString";
            try
            {
                Helper.LoadConfiguration("appsettings.json");
                conn = Helper.OpenConnection();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }

        static void Pause()
        {
            Console.Write("Press any to continue...");
            Console.ReadKey(false);
            Console.WriteLine();
        }
    }
}