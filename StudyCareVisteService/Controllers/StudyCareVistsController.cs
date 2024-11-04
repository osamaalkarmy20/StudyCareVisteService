using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyCareVisteService.Data;
using StudyCareVisteService.Model;

namespace StudyCareVisteService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyCareVistsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudyCareVistsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/StudyCareVists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudyCareVist>>> GetStudyCareVists()
        {
            return await _context.StudyCareVists.ToListAsync();
        }

        // GET: api/StudyCareVists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudyCareVist>> GetStudyCareVist(Guid id)
        {
            var studyCareVist = await _context.StudyCareVists.FindAsync(id);

            if (studyCareVist == null)
            {
                return NotFound();
            }

            return studyCareVist;
        }

        // PUT: api/StudyCareVists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudyCareVist(Guid id, StudyCareVist studyCareVist)
        {
            if (id != studyCareVist.Id)
            {
                return BadRequest();
            }

            _context.Entry(studyCareVist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudyCareVistExists(id))
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

        // POST: api/StudyCareVists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudyCareVist>> PostStudyCareVist(StudyCareVist studyCareVist)
        {
            _context.StudyCareVists.Add(studyCareVist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudyCareVist", new { id = studyCareVist.Id }, studyCareVist);
        }

        // DELETE: api/StudyCareVists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudyCareVist(Guid id)
        {
            var studyCareVist = await _context.StudyCareVists.FindAsync(id);
            if (studyCareVist == null)
            {
                return NotFound();
            }

            _context.StudyCareVists.Remove(studyCareVist);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudyCareVistExists(Guid id)
        {
            return _context.StudyCareVists.Any(e => e.Id == id);
        }
    }
}
