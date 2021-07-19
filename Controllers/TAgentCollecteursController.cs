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
    public class TAgentCollecteursController : ControllerBase
    {
        private readonly BD_EC_Bouake_Form_OnlineContext _context;

        public TAgentCollecteursController(BD_EC_Bouake_Form_OnlineContext context)
        {
            _context = context;
        }

        // GET: api/TAgentCollecteurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TAgentCollecteur>>> GetTAgentCollecteur()
        {
            return await _context.TAgentCollecteur.ToListAsync();
        }

        // GET: api/TAgentCollecteurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TAgentCollecteur>> GetTAgentCollecteur(int id)
        {
            var tAgentCollecteur = await _context.TAgentCollecteur.FindAsync(id);

            if (tAgentCollecteur == null)
            {
                return NotFound();
            }

            return tAgentCollecteur;
        }

        // PUT: api/TAgentCollecteurs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTAgentCollecteur(int id, TAgentCollecteur tAgentCollecteur)
        {
            if (id != tAgentCollecteur.AcolId)
            {
                return BadRequest();
            }

            _context.Entry(tAgentCollecteur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TAgentCollecteurExists(id))
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

        // POST: api/TAgentCollecteurs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TAgentCollecteur>> PostTAgentCollecteur(TAgentCollecteur tAgentCollecteur)
        {
            _context.TAgentCollecteur.Add(tAgentCollecteur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTAgentCollecteur", new { id = tAgentCollecteur.AcolId }, tAgentCollecteur);
        }

        // DELETE: api/TAgentCollecteurs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TAgentCollecteur>> DeleteTAgentCollecteur(int id)
        {
            var tAgentCollecteur = await _context.TAgentCollecteur.FindAsync(id);
            if (tAgentCollecteur == null)
            {
                return NotFound();
            }

            _context.TAgentCollecteur.Remove(tAgentCollecteur);
            await _context.SaveChangesAsync();

            return tAgentCollecteur;
        }

        private bool TAgentCollecteurExists(int id)
        {
            return _context.TAgentCollecteur.Any(e => e.AcolId == id);
        }
    }
}
