using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajyerWebAPI.Models;

namespace StajyerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StajyersController : ControllerBase
    {
        private readonly StajyerDBContext _context;

        public StajyersController(StajyerDBContext context)
        {
            _context = context;
        }

        // GET: api/Stajyers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stajyer>>> GetStajyers()
        {
            return await _context.Stajyers.ToListAsync();
        }

        // GET: api/Stajyers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stajyer>> GetStajyer(int id)
        {
            var stajyer = await _context.Stajyers.FindAsync(id);

            if (stajyer == null)
            {
                return NotFound();
            }

            return stajyer;
        }

        // PUT: api/Stajyers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutStajyer(int id, Stajyer stajyer)
        {
            if (id != stajyer.StajyerID)
            {
                return BadRequest();
            }

            _context.Entry(stajyer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StajyerExists(id))
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

        // POST: api/Stajyers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost()]
        public async Task<ActionResult<Stajyer>> PostStajyer(Stajyer stajyer)
        {
            _context.Stajyers.Add(stajyer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStajyer", new { id = stajyer.StajyerID }, stajyer);
        }
        [HttpPost("AddStajyer")]
        public async Task<ActionResult<Stajyer>> AddStajyer(Stajyer stajyer)
        {
            _context.Stajyers.Add(stajyer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStajyer", new { id = stajyer.StajyerID }, stajyer);
        }
        // DELETE: api/Stajyers/5
        // [HttpDelete("{id}")]
        [HttpPost("Delete/{id}")]
        public async Task<ActionResult<Stajyer>> DeleteStajyer(int id)
        {
            var stajyer = await _context.Stajyers.FindAsync(id);
            if (stajyer == null)
            {
                return NotFound();
            }

            _context.Stajyers.Remove(stajyer);
            await _context.SaveChangesAsync();

            return stajyer;
        }

        private bool StajyerExists(int id)
        {
            return _context.Stajyers.Any(e => e.StajyerID == id);
        }
    }
}
