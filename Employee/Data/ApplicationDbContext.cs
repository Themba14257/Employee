
using Employee.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<emp> employees { get; set; }
        public virtual DbSet<JobTitle> employee { get; set; }
    }
}
