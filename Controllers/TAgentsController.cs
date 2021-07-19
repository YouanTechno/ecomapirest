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
    public class TAgentsController : ControllerBase
    {
        private readonly BD_EC_Bouake_Form_OnlineContext _context;

        public TAgentsController(BD_EC_Bouake_Form_OnlineContext context)
        {
            _context = context;
        }

        // GET: api/TAgents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TAgent>>> GetTAgent()
        {
            return await _context.TAgent.ToListAsync();
        }

        // GET: api/TAgents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TAgent>> GetTAgent(int id)
        {
            var tAgent = await _context.TAgent.FindAsync(id);

            if (tAgent == null)
            {
                return NotFound();
            }

            return tAgent;
        }

        // PUT: api/TAgents/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTAgent(int id, TAgent tAgent)
        {
            if (id != tAgent.AgId)
            {
                return BadRequest();
            }

            _context.Entry(tAgent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TAgentExists(id))
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

        // POST: api/TAgents
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TAgent>> PostTAgent(TAgent tAgent)
        {
            _context.TAgent.Add(tAgent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTAgent", new { id = tAgent.AgId }, tAgent);
        }

        // DELETE: api/TAgents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TAgent>> DeleteTAgent(int id)
        {
            var tAgent = await _context.TAgent.FindAsync(id);
            if (tAgent == null)
            {
                return NotFound();
            }

            _context.TAgent.Remove(tAgent);
            await _context.SaveChangesAsync();

            return tAgent;
        }

        private bool TAgentExists(int id)
        {
            return _context.TAgent.Any(e => e.AgId == id);
        }
    }
}
