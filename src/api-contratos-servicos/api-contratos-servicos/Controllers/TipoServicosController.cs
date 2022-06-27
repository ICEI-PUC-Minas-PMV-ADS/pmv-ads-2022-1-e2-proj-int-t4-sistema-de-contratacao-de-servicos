using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_contratos_servicos.Context;
using api_contratos_servicos.Models;
using api_contratos_servicos.Models.Dto;
using System.Text;
using Microsoft.AspNetCore.Authorization;

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
        public async Task<ActionResult<IEnumerable<TipoServico>>> GetTipoServicos()
        {
            if (_context.TipoServicos == null)
            {
                return NotFound();
            }
            return await _context.TipoServicos.ToListAsync();
        }
    }

     
}
