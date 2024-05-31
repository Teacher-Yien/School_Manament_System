
using System.Data.Entity;

namespace api_yien.Datas
{
    public class MysqlData:DbContext
    {
        public MysqlData(DbContextOptions option) : base(option)
        {
        }

    }
}