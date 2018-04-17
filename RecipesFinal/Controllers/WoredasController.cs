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
    [Route("api/Woredas")]
    public class WoredasController : Controller
    {
        private readonly RecipeDatacontext _context;

        public WoredasController(RecipeDatacontext context)
        {
            _context = context;
        }

        // GET: api/Woredas
        [HttpGet]
        public IEnumerable<Woreda> GetWoredas()
        {
            return _context.Woredas;
        }

        // GET: api/Woredas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWoreda([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var woreda = await _context.Woredas.SingleOrDefaultAsync(m => m.id == id);

            if (woreda == null)
            {
                return NotFound();
            }

            return Ok(woreda);
        }

        // PUT: api/Woredas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWoreda([FromRoute] int id, [FromBody] Woreda woreda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != woreda.id)
            {
                return BadRequest();
            }

            _context.Entry(woreda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WoredaExists(id))
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

        // POST: api/Woredas
        [HttpPost]
        public async Task<IActionResult> PostWoreda([FromBody] Woreda woreda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Woredas.Add(woreda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWoreda", new { id = woreda.id }, woreda);
        }

        // DELETE: api/Woredas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWoreda([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var woreda = await _context.Woredas.SingleOrDefaultAsync(m => m.id == id);
            if (woreda == null)
            {
                return NotFound();
            }

            _context.Woredas.Remove(woreda);
            await _context.SaveChangesAsync();

            return Ok(woreda);
        }

        private bool WoredaExists(int id)
        {
            return _context.Woredas.Any(e => e.id == id);
        }
    }
}