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
    public class OrcamentosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrcamentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Orcamentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orcamento>>> GetOrcamento()
        {
          if (_context.Orcamentos == null)
          {
              return NotFound();
          }
            return await _context.Orcamentos.ToListAsync();
        }

        // GET: api/Orcamentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Orcamento>> GetOrcamento(int id)
        {
          if (_context.Orcamentos == null)
          {
              return NotFound();
          }
            var orcamento = await _context.Orcamentos.FindAsync(id);

            if (orcamento == null)
            {
                return NotFound();
            }

            return orcamento;
        }

        // PUT: api/Orcamentos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrcamento(int id, Orcamento orcamento)
        {
            if (id != orcamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(orcamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrcamentoExists(id))
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

        // POST: api/Orcamentos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Orcamento>> PostOrcamento(Orcamento orcamento)
        {
          if (_context.Orcamentos == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Orcamentos'  is null.");
          }
            _context.Orcamentos.Add(orcamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrcamento", new { id = orcamento.Id }, orcamento);
        }

        // DELETE: api/Orcamentos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrcamento(int id)
        {
            if (_context.Orcamentos == null)
            {
                return NotFound();
            }
            var orcamento = await _context.Orcamentos.FindAsync(id);
            if (orcamento == null)
            {
                return NotFound();
            }

            _context.Orcamentos.Remove(orcamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrcamentoExists(int id)
        {
            return (_context.Orcamentos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
