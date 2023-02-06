using Microsoft.EntityFrameworkCore;

namespace ReactASPCRUD.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Student { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=G1-1MS2MQ3-L;Initial Catalog=empentry; TrustServerCertificate=True; Integrated Security=True");

        }
    }
}
