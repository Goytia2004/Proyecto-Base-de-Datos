using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using baseproyecto.Server.Data;
using baseproyecto.Shared.Modelos;

namespace baseproyecto.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlimentosController : ControllerBase
    {
        private readonly Base_datos _context;

        public AlimentosController(Base_datos context)
        {
            _context = context;
        }

        // GET: api/Alimentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alimentos>>> Getalimentos()
        {
          if (_context.alimentos == null)
          {
              return NotFound();
          }
            return await _context.alimentos.ToListAsync();
        }

        // GET: api/Alimentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alimentos>> GetAlimentos(int id)
        {
          if (_context.alimentos == null)
          {
              return NotFound();
          }
            var alimentos = await _context.alimentos.FindAsync(id);

            if (alimentos == null)
            {
                return NotFound();
            }

            return alimentos;
        }

        // PUT: api/Alimentos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlimentos(int id, Alimentos alimentos)
        {
            if (id != alimentos.Id)
            {
                return BadRequest();
            }

            _context.Entry(alimentos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlimentosExists(id))
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

        // POST: api/Alimentos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Alimentos>> PostAlimentos(Alimentos alimentos)
        {
          if (_context.alimentos == null)
          {
              return Problem("Entity set 'Base_datos.alimentos'  is null.");
          }
            _context.alimentos.Add(alimentos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlimentos", new { id = alimentos.Id }, alimentos);
        }

        // DELETE: api/Alimentos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlimentos(int id)
        {
            if (_context.alimentos == null)
            {
                return NotFound();
            }
            var alimentos = await _context.alimentos.FindAsync(id);
            if (alimentos == null)
            {
                return NotFound();
            }

            _context.alimentos.Remove(alimentos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlimentosExists(int id1)
        {
            return (_context.alimentos?.Any(e => e.Id == id1)).GetValueOrDefault();
        }
    }
}
