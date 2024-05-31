using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace api_yien.Controllers
{
    [ApiController]
    [Route("/api/[[Employee]]")]
    public class WeatherConstroller :Controller
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=csharp_data;USER=root;PASSWORD=;");

        public WeatherConstroller() { }
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
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM `login` WHERE id='"+id+"'",conn);
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
            "('" + obj.id + "','" + obj.Name + "' , '"+ obj.Gender+"' ,'" + obj.Rank + "','" + obj.Salary + "')", conn);
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
                emp.id = int.Parse(row[0].ToString());
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



    }
}
