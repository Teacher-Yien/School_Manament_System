using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Api.Datas
{
    public class MysqlContext1 : DbContext
    {
        public MysqlContext1(DbContextOptions options) : base(options) {
        }

        public DbSet<Models.Employee> employees { get; set; }
    }
}
