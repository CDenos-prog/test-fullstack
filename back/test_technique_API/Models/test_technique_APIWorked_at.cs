using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace test_technique_API.Models
{
    [PrimaryKey(nameof(People_id), nameof(Job_Id))]
    public class test_technique_APIWorked_at
    {
        public int People_id { get; set; }
        public int Job_Id { get; set; }
        public bool? Active { get; set; }
        public DateTime? Entry_Date { get; set; }
        public DateTime? Quitting_Date { get; set; }
    }
}