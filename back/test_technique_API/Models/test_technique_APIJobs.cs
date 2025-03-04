using System.ComponentModel.DataAnnotations;

namespace test_technique_API.Models
{
    public class test_technique_APIJobs
    {
        [Key]
        public int Job_Id { get; set; }
        public string? Company_Name { get; set; }
        public string? Job_Name { get; set; }
    }
}