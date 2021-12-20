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
    public class UserRoleMappingsController : ControllerBase
    {
        private readonly SystemDbContext _context;

        public UserRoleMappingsController(SystemDbContext context)
        {
            _context = context;
        }

        // GET: api/UserRoleMappings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserRoleMapping>>> GetRoleMappings()
        {
            return await _context.RoleMappings.ToListAsync();
        }

        // GET: api/UserRoleMappings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserRoleMapping>> GetUserRoleMapping(int id)
        {
            var userRoleMapping = await _context.RoleMappings.FindAsync(id);

            if (userRoleMapping == null)
            {
                return NotFound();
            }

            return userRoleMapping;
        }

        // PUT: api/UserRoleMappings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserRoleMapping(int id, UserRoleMapping userRoleMapping)
        {
            if (id != userRoleMapping.Id)
            {
                return BadRequest();
            }

            _context.Entry(userRoleMapping).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserRoleMappingExists(id))
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

        // POST: api/UserRoleMappings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserRoleMapping>> PostUserRoleMapping(UserRoleMapping userRoleMapping)
        {
            _context.RoleMappings.Add(userRoleMapping);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserRoleMapping", new { id = userRoleMapping.Id }, userRoleMapping);
        }

        // DELETE: api/UserRoleMappings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRoleMapping(int id)
        {
            var userRoleMapping = await _context.RoleMappings.FindAsync(id);
            if (userRoleMapping == null)
            {
                return NotFound();
            }

            _context.RoleMappings.Remove(userRoleMapping);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserRoleMappingExists(int id)
        {
            return _context.RoleMappings.Any(e => e.Id == id);
        }
    }
}
