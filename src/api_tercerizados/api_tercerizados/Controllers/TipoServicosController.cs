using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using api_terceirizados.Context;
using api_terceirizados.Models;

namespace api_tercerizados.Controllers
{
    public class TipoServicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoServicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TipoServicos
        public async Task<IActionResult> Index()
        {
              return _context.TipoServicos != null ? 
                          View(await _context.TipoServicos.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TipoServicos'  is null.");
        }

        // GET: TipoServicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TipoServicos == null)
            {
                return NotFound();
            }

            var tipoServico = await _context.TipoServicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoServico == null)
            {
                return NotFound();
            }

            return View(tipoServico);
        }

        // GET: TipoServicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoServicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,descricaoServico")] TipoServico tipoServico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoServico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoServico);
        }

        // GET: TipoServicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TipoServicos == null)
            {
                return NotFound();
            }

            var tipoServico = await _context.TipoServicos.FindAsync(id);
            if (tipoServico == null)
            {
                return NotFound();
            }
            return View(tipoServico);
        }

        // POST: TipoServicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,descricaoServico")] TipoServico tipoServico)
        {
            if (id != tipoServico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoServico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoServicoExists(tipoServico.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tipoServico);
        }

        // GET: TipoServicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TipoServicos == null)
            {
                return NotFound();
            }

            var tipoServico = await _context.TipoServicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoServico == null)
            {
                return NotFound();
            }

            return View(tipoServico);
        }

        // POST: TipoServicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TipoServicos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TipoServicos'  is null.");
            }
            var tipoServico = await _context.TipoServicos.FindAsync(id);
            if (tipoServico != null)
            {
                _context.TipoServicos.Remove(tipoServico);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoServicoExists(int id)
        {
          return (_context.TipoServicos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
