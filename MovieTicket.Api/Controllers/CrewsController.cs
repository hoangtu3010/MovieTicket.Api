using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicket.Api.Models;

namespace MovieTicket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrewsController : ControllerBase
    {
        private readonly SystemDbContext _context;

        public CrewsController(SystemDbContext context)
        {
            _context = context;
        }

        // GET: api/Crews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crew>>> GetCrewers()
        {
            return await _context.Crewers.ToListAsync();
        }

        // GET: api/Crews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Crew>> GetCrew(int id)
        {
            var crew = await _context.Crewers.FindAsync(id);

            if (crew == null)
            {
                return NotFound();
            }

            return crew;
        }

        // PUT: api/Crews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCrew(int id, Crew crew)
        {
            if (id != crew.Id)
            {
                return BadRequest();
            }

            _context.Entry(crew).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CrewExists(id))
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

        // POST: api/Crews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Crew>> PostCrew(Crew crew)
        {
            _context.Crewers.Add(crew);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCrew", new { id = crew.Id }, crew);
        }

        // DELETE: api/Crews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCrew(int id)
        {
            var crew = await _context.Crewers.FindAsync(id);
            if (crew == null)
            {
                return NotFound();
            }

            _context.Crewers.Remove(crew);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CrewExists(int id)
        {
            return _context.Crewers.Any(e => e.Id == id);
        }
    }
}
