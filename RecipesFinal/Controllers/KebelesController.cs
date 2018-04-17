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
    [Route("api/Kebeles")]
    public class KebelesController : Controller
    {
        private readonly RecipeDatacontext _context;

        public KebelesController(RecipeDatacontext context)
        {
            _context = context;
        }

        // GET: api/Kebeles
        [HttpGet]
        public IEnumerable<Kebele> Getkebeles()
        {
            return _context.kebeles;
        }

        // GET: api/Kebeles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetKebele([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var kebele = await _context.kebeles.SingleOrDefaultAsync(m => m.id == id);

            if (kebele == null)
            {
                return NotFound();
            }

            return Ok(kebele);
        }

        // PUT: api/Kebeles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKebele([FromRoute] int id, [FromBody] Kebele kebele)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kebele.id)
            {
                return BadRequest();
            }

            _context.Entry(kebele).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KebeleExists(id))
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

        // POST: api/Kebeles
        [HttpPost]
        public async Task<IActionResult> PostKebele([FromBody] Kebele kebele)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.kebeles.Add(kebele);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKebele", new { id = kebele.id }, kebele);
        }

        // DELETE: api/Kebeles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKebele([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var kebele = await _context.kebeles.SingleOrDefaultAsync(m => m.id == id);
            if (kebele == null)
            {
                return NotFound();
            }

            _context.kebeles.Remove(kebele);
            await _context.SaveChangesAsync();

            return Ok(kebele);
        }

        private bool KebeleExists(int id)
        {
            return _context.kebeles.Any(e => e.id == id);
        }
    }
}