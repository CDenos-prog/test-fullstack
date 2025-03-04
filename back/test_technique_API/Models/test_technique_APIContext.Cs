using Microsoft.EntityFrameworkCore;

namespace test_technique_API.Models
{
    public class test_technique_APIContext : DbContext
    {
        public test_technique_APIContext(DbContextOptions<test_technique_APIContext> options)
            : base(options)
        {
        }

        public DbSet<test_technique_APIPeople> test_Technique_APIPeoples { get; set; }
        public DbSet<test_technique_APIJobs> test_Technique_APIJobs { get; set; }
    }
}