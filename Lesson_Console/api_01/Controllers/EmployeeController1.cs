using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;
using api_01.Datas;
namespace api_01.Controllers
{
    [ApiController]
    [Route("/api/[[Employee]]")]
    public class EmployeeController1 : Controller
    {

       // MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp_data;USER=root;PASSWORD=;");
        private MySqlDbContext1 dbContext1;
        public EmployeeController1(MySqlDbContext1 db) {
        dbContext1= db;
         }
        [HttpGet]
        public IActionResult GetEmployee()
        {
            return View(dbContext1.employees.ToList());
          /*  
           *  MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM `login` WHERE 1 ", conn);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            List<Models.Employee> list = new List<Models.Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Models.Employee emp = new Models.Employee();
                emp.Id = int.Parse(row[0].ToString());
                emp.Gender = row[1].ToString();
                emp.Name = row[2].ToString();
                emp.Rank = row[3].ToString();
                emp.Salary = row[4].ToString();
                list.Add(emp);

            }
            return Ok(list);*/

        }
        /*
        [HttpGet("/{id}")]
        public IActionResult GetEmployee(int id)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM `login` WHERE id='" + id + "'", conn);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            List<Models.Employee> list = new List<Models.Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Models.Employee emp = new Models.Employee();
                emp.Id = int.Parse(row[0].ToString());
                emp.Gender = row[1].ToString();
                emp.Name = row[2].ToString();
                emp.Rank = row[3].ToString();
                emp.Salary = row[4].ToString();
                list.Add(emp);

            }
            return Ok(list);

        }



        [HttpPost]
        public IActionResult PostEmployee(Models.Employee obj)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("INSERT INTO `login`(`id`, `name`, `gender`, `rank`, `salary`) VALUES " +
            "('" + obj + "','" + obj.Name + "' , '" + obj.Gender + "' ,'" + obj.Rank + "','" + obj.Salary + "')", conn);
            MySqlDataAdapter data1 = new MySqlDataAdapter("SELECT * FROM `login`  WHERE 1", conn);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            List<Models.Employee> list = new List<Models.Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Models.Employee emp = new Models.Employee();
                emp.Id = int.Parse(row[0].ToString());
                emp.Gender = row[1].ToString();
                emp.Name = row[2].ToString();
                emp.Rank = row[3].ToString();
                emp.Salary = row[4].ToString();
                list.Add(emp);

            }
            return Ok(list);
        }
        [HttpDelete("/{id}")]
        public IActionResult DeletedEmployee(int id)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("DELETE * FROM `login` WHERE id='" + id + "'", conn);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            List<Models.Employee> list = new List<Models.Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Models.Employee emp = new Models.Employee();
                emp.Id = int.Parse(row[0].ToString());
                emp.Gender = row[1].ToString();
                emp.Name = row[2].ToString();
                emp.Rank = row[3].ToString();
                emp.Salary = row[4].ToString();
                list.Add(emp);

            }
            return Ok(list);

        }


        [HttpPut]
        public IActionResult Update(Models.Employee obj)
        {
            MySqlDataAdapter data = new MySqlDataAdapter("UPDATE INTO `login`(`id`, `name`, `gender`, `rank`, `salary`) VALUES " +
            "('" + obj.Id + "','" + obj.Name + "' , '" + obj.Gender + "' ,'" + obj.Rank + "','" + obj.Salary + "')", conn);
            MySqlDataAdapter data1 = new MySqlDataAdapter("SELECT * FROM `login`  WHERE 1", conn);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            List<Models.Employee> list = new List<Models.Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Models.Employee emp = new Models.Employee();
                emp.Id = int.Parse(row[0].ToString());
                emp.Gender = row[1].ToString();
                emp.Name = row[2].ToString();
                emp.Rank = row[3].ToString();
                emp.Salary = row[4].ToString();
                list.Add(emp);

            }
            return Ok(list);
        }*/
    }
}
