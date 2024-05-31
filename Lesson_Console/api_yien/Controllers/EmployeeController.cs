using api_yien.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace api_yien.Controllers
{
   
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp_data;USER=root;PASSWORD=;");

        public EmployeeController() { }
        [HttpGet]
        public IActionResult GetEmployee()
        {
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM `login` WHERE 1 ", conn);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            List<Models.Employee> list = new List<Models.Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Models.Employee emp = new Models.Employee();
                emp.id = int.Parse(row[0].ToString());
                emp.Gender = row[1].ToString();
                emp.Name = row[2].ToString();
                emp.Rank = row[3].ToString();
                emp.Salary = row[4].ToString();
                list.Add(emp);

            }
            return Ok(list);

        }
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
                emp.id = int.Parse(row[0].ToString());
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
            "('" + obj.id + "','" + obj.Name + "' , '" + obj.Gender + "' ,'" + obj.Rank + "','" + obj.Salary + "')", conn);
            MySqlDataAdapter data1 = new MySqlDataAdapter("SELECT * FROM `login`  WHERE 1", conn);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            List<Models.Employee> list = new List<Models.Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                Models.Employee emp = new Models.Employee();
                emp.id = int.Parse(row[0].ToString());
                emp.Gender = row[1].ToString();
                emp.Name = row[2].ToString();
                emp.Rank = row[3].ToString();
                emp.Salary = row[4].ToString();
                list.Add(emp);

            }
            return Ok(list);
        }

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
