using System.ComponentModel.DataAnnotations;
using test_technique_API.Models;

namespace test_technique_API.Models.DTO
{
    public class test_technique_APIPeople_DTO
    {
        public int People_id { get; set; }
        public string? Name { get; set; }
        public string? First_Name { get; set; }
        public DateTime? Birthday { get; set; }
        public List<test_technique_APIJobs_DTO>? JobsList { get; set; }
    }
}