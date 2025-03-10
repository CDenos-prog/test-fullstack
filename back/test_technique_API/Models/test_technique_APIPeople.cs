using System.ComponentModel.DataAnnotations;

namespace test_technique_API.Models
{
    public class test_technique_APIPeople
    {
        [Key]
        public int People_id { get; set; }
        public string? Name { get; set; }
        public string? First_Name { get; set; }
        public DateTime? Birthday { get; set; }
        public List<test_technique_APIJobs>? JobsList { get; set; }
    }
}