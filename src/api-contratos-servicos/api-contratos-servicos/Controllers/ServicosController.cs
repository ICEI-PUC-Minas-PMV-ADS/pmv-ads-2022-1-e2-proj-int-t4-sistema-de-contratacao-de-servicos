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
    public class ServicosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ServicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Servicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servico>>> GetServico()
        {
          if (_context.Servico == null)
          {
              return NotFound();
          }
            return await _context.Servico.ToListAsync();
        }

        // GET: api/Servicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Servico>> GetServico(int id)
        {
          if (_context.Servico == null)
          {
              return NotFound();
          }
            var servico = await _context.Servico.FindAsync(id);

            if (servico == null)
            {
                return NotFound();
            }

            return servico;
        }

        // PUT: api/Servicos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServico(int id, Servico servico)
        {
            if (id != servico.Id)
            {
                return BadRequest();
            }

            _context.Entry(servico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServicoExists(id))
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

        // POST: api/Servicos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Servico>> PostServico(Servico servico)
        {
          if (_context.Servico == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Servico'  is null.");
          }
            _context.Servico.Add(servico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServico", new { id = servico.Id }, servico);
        }

        // DELETE: api/Servicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServico(int id)
        {
            if (_context.Servico == null)
            {
                return NotFound();
            }
            var servico = await _context.Servico.FindAsync(id);
            if (servico == null)
            {
                return NotFound();
            }

            _context.Servico.Remove(servico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ServicoExists(int id)
        {
            return (_context.Servico?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
