using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApiEcom.Models;

namespace RestApiEcom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TCContribuablesController : ControllerBase
    {
        private readonly BD_EC_Bouake_Form_OnlineContext _context;

        public TCContribuablesController(BD_EC_Bouake_Form_OnlineContext context)
        {
            _context = context;
        }

        // GET: api/TCContribuables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TCContribuable>>> GetTCContribuable()
        {
            return await _context.TCContribuable.ToListAsync();
        }

        // GET: api/TCContribuables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TCContribuable>> GetTCContribuable(int id)
        {
            var tCContribuable = await _context.TCContribuable.FindAsync(id);

            if (tCContribuable == null)
            {
                return NotFound();
            }

            return tCContribuable;
        }

        // PUT: api/TCContribuables/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTCContribuable(int id, TCContribuable tCContribuable)
        {
            if (id != tCContribuable.ContId)
            {
                return BadRequest();
            }

            _context.Entry(tCContribuable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TCContribuableExists(id))
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

        // POST: api/TCContribuables
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TCContribuable>> PostTCContribuable(TCContribuable tCContribuable)
        {
            _context.TCContribuable.Add(tCContribuable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTCContribuable", new { id = tCContribuable.ContId }, tCContribuable);
        }

        // DELETE: api/TCContribuables/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TCContribuable>> DeleteTCContribuable(int id)
        {
            var tCContribuable = await _context.TCContribuable.FindAsync(id);
            if (tCContribuable == null)
            {
                return NotFound();
            }

            _context.TCContribuable.Remove(tCContribuable);
            await _context.SaveChangesAsync();

            return tCContribuable;
        }

        private bool TCContribuableExists(int id)
        {
            return _context.TCContribuable.Any(e => e.ContId == id);
        }
    }
}
