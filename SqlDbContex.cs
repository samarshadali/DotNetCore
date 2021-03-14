using DotNetCoreCURD.Model;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreCURD
{
    public class SqlDbContex : DbContext
    {

        public SqlDbContex(DbContextOptions<SqlDbContex> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
