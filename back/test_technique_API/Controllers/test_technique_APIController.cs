using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test_technique_API.Models;
using test_technique_API.Services;

namespace test_technique_API.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]
    public class test_technique_APIController : ControllerBase
    {
        private readonly test_technique_APIContext _context;

        public test_technique_APIController(test_technique_APIContext context)
        {
            _context = context;
        }
        

        // GET: api/test_technique_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<test_technique_APIItem>>> Gettest_technique_APIItem()
        {
            return await _context.test_technique_APIItem.ToListAsync();
        }

        // GET: api/test_technique_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<test_technique_APIItem>> Gettest_technique_APIItem(long id)
        {
            var test_technique_APIItem = await _context.test_technique_APIItem.FindAsync(id);

            if (test_technique_APIItem == null)
            {
                return NotFound();
            }

            return test_technique_APIItem;
        }

        // PUT: api/test_technique_API/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Puttest_technique_APIItem(long id, test_technique_APIItem test_technique_APIItem)
        {
            if (id != test_technique_APIItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(test_technique_APIItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!test_technique_APIItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/test_technique_API
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<test_technique_APIItem>> Posttest_technique_APIItem(test_technique_APIItem test_technique_APIItem)
        {
            _context.test_technique_APIItem.Add(test_technique_APIItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Gettest_technique_APIItem", new { id = test_technique_APIItem.Id }, test_technique_APIItem);
        }

        // DELETE: api/test_technique_API/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletetest_technique_APIItem(long id)
        {
            var test_technique_APIItem = await _context.test_technique_APIItem.FindAsync(id);
            if (test_technique_APIItem == null)
            {
                return NotFound();
            }

            _context.test_technique_APIItem.Remove(test_technique_APIItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool test_technique_APIItemExists(long id)
        {
            return _context.test_technique_APIItem.Any(e => e.Id == id);
        }
    }
    */
    [Route("api/[controller]")]
    [ApiController]
    public class test_technique_API_People_Controller : ControllerBase{
        private readonly IPeopleService _peopleService;
        public test_technique_API_People_Controller(IPeopleService peopleService){
            _peopleService = peopleService;
        }

        [HttpGet("all_people")]
        public async Task<ActionResult<List<test_technique_APIPeople>>> GetPeople(){
            return await _peopleService.GetPeople();
        }
    }
}
