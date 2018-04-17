using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipesFinal.Data.Context;
using RecipesFinal.Data.Model;

namespace RecipesFinal.Controllers
{
    [Produces("application/json")]
    [Route("api/Zones")]
    public class ZonesController : Controller
    {
        private readonly RecipeDatacontext _context;

        public ZonesController(RecipeDatacontext context)
        {
            _context = context;
        }

        // GET: api/Zones
        [HttpGet]
        public IEnumerable<Zone> GetZones()
        {
            return _context.Zones;
        }

        // GET: api/Zones/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetZone([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var zone = await _context.Zones.SingleOrDefaultAsync(m => m.id == id);

            if (zone == null)
            {
                return NotFound();
            }

            return Ok(zone);
        }

        // PUT: api/Zones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZone([FromRoute] int id, [FromBody] Zone zone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zone.id)
            {
                return BadRequest();
            }

            _context.Entry(zone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZoneExists(id))
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

        // POST: api/Zones
        [HttpPost]
        public async Task<IActionResult> PostZone([FromBody] Zone zone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Zones.Add(zone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZone", new { id = zone.id }, zone);
        }

        // DELETE: api/Zones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZone([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var zone = await _context.Zones.SingleOrDefaultAsync(m => m.id == id);
            if (zone == null)
            {
                return NotFound();
            }

            _context.Zones.Remove(zone);
            await _context.SaveChangesAsync();

            return Ok(zone);
        }

        private bool ZoneExists(int id)
        {
            return _context.Zones.Any(e => e.id == id);
        }
    }
}