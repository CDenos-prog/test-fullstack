namespace test_technique_API.Models
{
    public class test_technique_APIPeople
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public DateOnly? BirthDate { get; set; }
        public List<test_technique_APIJobs>? JobsList { get; set; }
    }
}