using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NCT_Fashion.Data;
using NCT_Fashion.Models.Entities;

namespace NCT_Fashion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class deliversController : ControllerBase
    {
        private readonly NCT_FashionContext _context;

        public deliversController(NCT_FashionContext context)
        {
            _context = context;
        }

        // GET: api/Delivers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deliver>>> GetDeliver()
        {
            return await _context.Deliver.ToListAsync();
        }

        // GET: api/Delivers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Deliver>> GetDeliver(int id)
        {
            var deliver = await _context.Deliver.FindAsync(id);

            if (deliver == null)
            {
                return NotFound();
            }

            return deliver;
        }

        // PUT: api/Delivers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeliver(int id, Deliver deliver)
        {
            if (id != deliver.ID)
            {
                return BadRequest();
            }

            _context.Entry(deliver).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliverExists(id))
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

        // POST: api/Delivers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Deliver>> PostDeliver(Deliver deliver)
        {
            _context.Deliver.Add(deliver);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeliver", new { id = deliver.ID }, deliver);
        }

        // DELETE: api/Delivers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeliver(int id)
        {
            var deliver = await _context.Deliver.FindAsync(id);
            if (deliver == null)
            {
                return NotFound();
            }

            _context.Deliver.Remove(deliver);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeliverExists(int id)
        {
            return _context.Deliver.Any(e => e.ID == id);
        }
    }
}
