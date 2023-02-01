using Microsoft.EntityFrameworkCore;

namespace TestXSIS.Data
{
    public class MysqlDBContext : DbContext
    {
        public MysqlDBContext(DbContextOptions<MysqlDBContext> options) : base(options) 
        {
        
        }
        public DbSet<Movie> movies { get; set; }
    }
}
