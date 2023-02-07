using Microsoft.EntityFrameworkCore;

namespace ReactASPCRUD.Models

{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=G1-1MS2MQ3-L;Initial Catalog=empentry; TrustServerCertificate=True; Integrated Security=True");
        }

    }
}
