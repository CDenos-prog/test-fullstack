using Microsoft.EntityFrameworkCore;

namespace test_technique_API.Models
{
    public class test_technique_APIContext : DbContext
    {
        public test_technique_APIContext(DbContextOptions<test_technique_APIContext> options)
            : base(options)
        {
        }

        public DbSet<test_technique_APIPeople> people { get; set; }
        public DbSet<test_technique_APIJobs> job { get; set; }
        public DbSet<test_technique_APIWorked_at> people_job { get; set; }
    }
}