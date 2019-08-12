using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CTVoicer.Negocio.Context;
using CTVoicer.Entidades;
using Microsoft.AspNetCore.Http.Extensions;

namespace CTVoicer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrotaController : ControllerBase
    {
        private readonly CTVoicerContext _context;
        
        public FrotaController(CTVoicerContext context)
        {
            _context = context;
        }

        // GET: api/Frota
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Frota>>> GetFrotas()
        {
            return await _context.Frotas.ToListAsync();
        }

        // GET: api/Frota/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Frota>> GetFrota(int id)
        {
            var frota = await _context.Frotas.FindAsync(id);

            if (frota == null)
            {
                return NotFound();
            }

            return frota;
        }

        // PUT: api/Frota/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFrota(int id, Frota frota)
        {
            if (id != frota.IdFrota)
            {
                return BadRequest();
            }

            _context.Entry(frota).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FrotaExists(id))
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

        // POST: api/Frota
        [HttpPost]
        public async Task<ActionResult<Frota>> PostFrota(Frota frota)
        {
            _context.Frotas.Add(frota);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFrota", new { id = frota.IdFrota }, frota);
        }

        // DELETE: api/Frota/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Frota>> DeleteFrota(int id)
        {
            var frota = await _context.Frotas.FindAsync(id);
            if (frota == null)
            {
                return NotFound();
            }

            _context.Frotas.Remove(frota);
            await _context.SaveChangesAsync();

            return frota;
        }

        private bool FrotaExists(int id)
        {
            return _context.Frotas.Any(e => e.IdFrota == id);
        }

        private bool FrotaExists(string nome)
        {
            return _context.Frotas.Any(e => e.Nome == nome);
        }
    }
}
