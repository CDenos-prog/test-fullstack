using test_technique_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using test_technique_API.Models.DTO;
using AutoMapper;

namespace test_technique_API.Services{
    public interface IPeopleService{
        Task<ActionResult<test_technique_APIPeople>> AddPeople(test_technique_APIPeople_DTO people_DTO);
        Task<List<test_technique_APIPeople>> GetPeople();
    }

    public class PeopleService : IPeopleService{
        private readonly test_technique_APIContext _context;
        private readonly IMapper _mapper;

        public PeopleService(test_technique_APIContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;
        }

        public async Task<ActionResult<test_technique_APIPeople>> AddPeople(test_technique_APIPeople_DTO people_DTO)
        {
            test_technique_APIPeople peopleToAdd = new test_technique_APIPeople();
            peopleToAdd.Birthday = people_DTO.Birthday;
            peopleToAdd.Name = people_DTO.Name;
            peopleToAdd.First_Name = people_DTO.First_Name;
            _context.people.Add(peopleToAdd);
            await _context.SaveChangesAsync();
            return peopleToAdd;
        }

        public async Task<List<test_technique_APIPeople>> GetPeople(){
            return await _context.people.ToListAsync();
        }
    }
}