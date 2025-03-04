using test_technique_API.Models;
using Microsoft.EntityFrameworkCore;

namespace test_technique_API.Services{
    public interface IPeopleService{
        Task<List<test_technique_APIPeople>> GetPeople();
    }

    public class PeopleService : IPeopleService{
        private readonly test_technique_APIContext _context;

        public PeopleService(test_technique_APIContext context){
            _context = context;
        }

        public async Task<List<test_technique_APIPeople>> GetPeople(){
            return await _context.test_Technique_APIPeoples.ToListAsync();
        }
    }
}