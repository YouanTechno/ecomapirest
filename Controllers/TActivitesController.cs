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
    public class TActivitesController : ControllerBase
    {
        private readonly BD_EC_Bouake_Form_OnlineContext _context;

        public TActivitesController(BD_EC_Bouake_Form_OnlineContext context)
        {
            _context = context;
        }

        // GET: api/TActivites
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TActivite>>> GetTActivite()
        {
            return await _context.TActivite.ToListAsync();
        }

        // GET: api/TActivites/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TActivite>> GetTActivite(int id)
        {
            var tActivite = await _context.TActivite.FindAsync(id);

            if (tActivite == null)
            {
                return NotFound();
            }

            return tActivite;
        }

        // PUT: api/TActivites/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTActivite(int id, TActivite tActivite)
        {
            if (id != tActivite.ActId)
            {
                return BadRequest();
            }

            _context.Entry(tActivite).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TActiviteExists(id))
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

        // POST: api/TActivites
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TActivite>> PostTActivite(TActivite tActivite)
        {
            _context.TActivite.Add(tActivite);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTActivite", new { id = tActivite.ActId }, tActivite);
        }

        // DELETE: api/TActivites/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TActivite>> DeleteTActivite(int id)
        {
            var tActivite = await _context.TActivite.FindAsync(id);
            if (tActivite == null)
            {
                return NotFound();
            }

            _context.TActivite.Remove(tActivite);
            await _context.SaveChangesAsync();

            return tActivite;
        }

        private bool TActiviteExists(int id)
        {
            return _context.TActivite.Any(e => e.ActId == id);
        }
    }
}
