using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
namespace api_01.Datas
{
    public class MySqlDbContext1 : DbContext
    {
        public MySqlDbContext1(DbContextOptions options) : base(options)
        {

           
        }
        public DbSet<Models.Employee> employees { get; set; }
    }
}
