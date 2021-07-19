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
    public class TResPaiementsController : ControllerBase
    {
        private readonly BD_EC_Bouake_Form_OnlineContext _context;

        public TResPaiementsController(BD_EC_Bouake_Form_OnlineContext context)
        {
            _context = context;
        }

        // GET: api/TResPaiements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TResPaiement>>> GetTResPaiement()
        {
            return await _context.TResPaiement.ToListAsync();
        }

        // GET: api/TResPaiements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TResPaiement>> GetTResPaiement(int id)
        {
            var tResPaiement = await _context.TResPaiement.FindAsync(id);

            if (tResPaiement == null)
            {
                return NotFound();
            }

            return tResPaiement;
        }

        // PUT: api/TResPaiements/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTResPaiement(int id, TResPaiement tResPaiement)
        {
            if (id != tResPaiement.PaieId)
            {
                return BadRequest();
            }

            _context.Entry(tResPaiement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TResPaiementExists(id))
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

        // POST: api/TResPaiements
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TResPaiement>> PostTResPaiement(TResPaiement tResPaiement)
        {
            _context.TResPaiement.Add(tResPaiement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTResPaiement", new { id = tResPaiement.PaieId }, tResPaiement);
        }

        // DELETE: api/TResPaiements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TResPaiement>> DeleteTResPaiement(int id)
        {
            var tResPaiement = await _context.TResPaiement.FindAsync(id);
            if (tResPaiement == null)
            {
                return NotFound();
            }

            _context.TResPaiement.Remove(tResPaiement);
            await _context.SaveChangesAsync();

            return tResPaiement;
        }

        private bool TResPaiementExists(int id)
        {
            return _context.TResPaiement.Any(e => e.PaieId == id);
        }
    }
}
