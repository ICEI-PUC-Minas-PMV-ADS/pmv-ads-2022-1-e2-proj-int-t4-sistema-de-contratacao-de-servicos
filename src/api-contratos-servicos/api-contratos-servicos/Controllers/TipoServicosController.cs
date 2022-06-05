using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_contratos_servicos.Context;
using api_contratos_servicos.Models;

namespace api_contratos_servicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoServicosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TipoServicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoServicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoServico>>> GetTipoServico()
        {
          if (_context.TipoServico == null)
          {
              return NotFound();
          }
            return await _context.TipoServico.ToListAsync();
        }

        // GET: api/TipoServicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoServico>> GetTipoServico(int id)
        {
          if (_context.TipoServico == null)
          {
              return NotFound();
          }
            var tipoServico = await _context.TipoServico.FindAsync(id);

            if (tipoServico == null)
            {
                return NotFound();
            }

            return tipoServico;
        }

        // PUT: api/TipoServicos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoServico(int id, TipoServico tipoServico)
        {
            if (id != tipoServico.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoServico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoServicoExists(id))
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

        // POST: api/TipoServicos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoServico>> PostTipoServico(TipoServico tipoServico)
        {
          if (_context.TipoServico == null)
          {
              return Problem("Entity set 'ApplicationDbContext.TipoServico'  is null.");
          }
            _context.TipoServico.Add(tipoServico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoServico", new { id = tipoServico.Id }, tipoServico);
        }

        // DELETE: api/TipoServicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoServico(int id)
        {
            if (_context.TipoServico == null)
            {
                return NotFound();
            }
            var tipoServico = await _context.TipoServico.FindAsync(id);
            if (tipoServico == null)
            {
                return NotFound();
            }

            _context.TipoServico.Remove(tipoServico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoServicoExists(int id)
        {
            return (_context.TipoServico?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
