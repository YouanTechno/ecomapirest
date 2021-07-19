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
    public class TResFacturesController : ControllerBase
    {
        private readonly BD_EC_Bouake_Form_OnlineContext _context;

        public TResFacturesController(BD_EC_Bouake_Form_OnlineContext context)
        {
            _context = context;
        }

        // GET: api/TResFactures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TResFacture>>> GetTResFacture()
        {
            return await _context.TResFacture.ToListAsync();
        }

        // GET: api/TResFactures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TResFacture>> GetTResFacture(int id)
        {
            var tResFacture = await _context.TResFacture.FindAsync(id);

            if (tResFacture == null)
            {
                return NotFound();
            }

            return tResFacture;
        }

        // PUT: api/TResFactures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTResFacture(int id, TResFacture tResFacture)
        {
            if (id != tResFacture.FactId)
            {
                return BadRequest();
            }

            _context.Entry(tResFacture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TResFactureExists(id))
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

        // POST: api/TResFactures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TResFacture>> PostTResFacture(TResFacture tResFacture)
        {
            _context.TResFacture.Add(tResFacture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTResFacture", new { id = tResFacture.FactId }, tResFacture);
        }

        // DELETE: api/TResFactures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TResFacture>> DeleteTResFacture(int id)
        {
            var tResFacture = await _context.TResFacture.FindAsync(id);
            if (tResFacture == null)
            {
                return NotFound();
            }

            _context.TResFacture.Remove(tResFacture);
            await _context.SaveChangesAsync();

            return tResFacture;
        }

        private bool TResFactureExists(int id)
        {
            return _context.TResFacture.Any(e => e.FactId == id);
        }
    }
}
