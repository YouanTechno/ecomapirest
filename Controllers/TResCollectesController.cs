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
    public class TResCollectesController : ControllerBase
    {
        private readonly BD_EC_Bouake_Form_OnlineContext _context;

        public TResCollectesController(BD_EC_Bouake_Form_OnlineContext context)
        {
            _context = context;
        }

        // GET: api/TResCollectes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TResCollecte>>> GetTResCollecte()
        {
            return await _context.TResCollecte.ToListAsync();
        }

        // GET: api/TResCollectes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TResCollecte>> GetTResCollecte(int id)
        {
            var tResCollecte = await _context.TResCollecte.FindAsync(id);

            if (tResCollecte == null)
            {
                return NotFound();
            }

            return tResCollecte;
        }

        // PUT: api/TResCollectes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTResCollecte(int id, TResCollecte tResCollecte)
        {
            if (id != tResCollecte.ColId)
            {
                return BadRequest();
            }

            _context.Entry(tResCollecte).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TResCollecteExists(id))
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

        // POST: api/TResCollectes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TResCollecte>> PostTResCollecte(TResCollecte tResCollecte)
        {
            _context.TResCollecte.Add(tResCollecte);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTResCollecte", new { id = tResCollecte.ColId }, tResCollecte);
        }

        // DELETE: api/TResCollectes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TResCollecte>> DeleteTResCollecte(int id)
        {
            var tResCollecte = await _context.TResCollecte.FindAsync(id);
            if (tResCollecte == null)
            {
                return NotFound();
            }

            _context.TResCollecte.Remove(tResCollecte);
            await _context.SaveChangesAsync();

            return tResCollecte;
        }

        private bool TResCollecteExists(int id)
        {
            return _context.TResCollecte.Any(e => e.ColId == id);
        }
    }
}
