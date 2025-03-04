using test_technique_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using test_technique_API.Models.DTO;
using AutoMapper;

namespace test_technique_API.Services{
    public interface IPeopleService{
        Task<ActionResult<test_technique_APIWorked_at>> AddJob(test_technique_APIWorked_At_DTO jobsToAdd_DTO);
        Task<ActionResult<test_technique_APIPeople>> AddPeople(test_technique_APIPeople_DTO people_DTO);
        Task<List<test_technique_APIPeople>> GetPeople();
        Task<List<test_technique_APIPeople>> GetPeopleById(int Id);
    }

    public class PeopleService : IPeopleService{
        private readonly test_technique_APIContext _context;
        private readonly IMapper _mapper;

        public PeopleService(test_technique_APIContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;
        }

        public async Task<ActionResult<test_technique_APIWorked_at>> AddJob(test_technique_APIWorked_At_DTO jobsToAdd_DTO)
        {
            test_technique_APIWorked_at worked_At = new test_technique_APIWorked_at();
            worked_At.People_id = jobsToAdd_DTO.People_id;
            worked_At.Job_Id = jobsToAdd_DTO.Job_Id;
            worked_At.Entry_Date = jobsToAdd_DTO.Entry_Date;
            worked_At.Quitting_Date = jobsToAdd_DTO.Quitting_Date;
            worked_At.Active = jobsToAdd_DTO.Active;
            _context.people_job.Add(worked_At);
            await _context.SaveChangesAsync();
            return worked_At;
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

        public Task<List<test_technique_APIPeople>> GetPeopleById(int Id)
        {
            return _context.people.Where(p => p.People_id == Id).ToListAsync();
        }
    }
}