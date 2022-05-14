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

namespace api_contratos_servicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("login")]
        [HttpPost]
        public async Task<ActionResult<UsuarioDTO>> Login([Bind("Email,Senha")]  UsuarioLogin usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }

            if (_context.Usuarios == null)
            {
                return NotFound();
            }

            var usuarioLogado = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == usuario.Email && u.Senha == usuario.Senha);

            if (usuarioLogado == null)
            {
                return NotFound();
            }

            return new UsuarioDTO(usuarioLogado.Id, usuarioLogado.Nome, usuarioLogado.Email);

        }


        [Route("cadastrar")]
        [HttpPost]
        public async Task<ActionResult<UsuarioDTO>> Cadastrar([Bind("Nome,Email")] UsuarioDTO usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }

            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Usuarios'  is null.");
            }

            var novoUsuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == usuario.Email);

            if (!(novoUsuario == null))
            {
                return CreatedAtAction("GetUsuario", new { id = novoUsuario.Id }, novoUsuario);
            }
            novoUsuario = new Usuario(usuario.Nome, usuario.Email, gerarSenha());
            _context.Usuarios.Add(novoUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = novoUsuario.Id }, novoUsuario);


        }

        private string gerarSenha()
        {
            string validar = "abcdefghijklmnozABCDEFGHIJKLMNOZ1234567890@#$%&*!";
            string _senha = "";
            try
            {
                int _tamanho_senha = 8;
                StringBuilder strbld = new StringBuilder(100);
                Random random = new Random();
                while (0 < _tamanho_senha--)
                {
                    strbld.Append(validar[random.Next(validar.Length)]);
                }
                _senha = strbld.ToString();
            }
            catch (Exception ex)
            {
                _senha = "error";
            }
            return _senha;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            if (_context.Usuarios == null)
            {
                return NotFound();
            }
            return await _context.Usuarios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            if (_context.Usuarios == null)
            {
                return NotFound();
            }
            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        /*

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
          if (_context.Usuarios == null)
          {
              return NotFound();
          }
            return await _context.Usuarios.ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
          if (_context.Usuarios == null)
          {
              return NotFound();
          }
            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
          if (_context.Usuarios == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Usuarios'  is null.");
          }
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = usuario.Id }, usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            if (_context.Usuarios == null)
            {
                return NotFound();
            }
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return (_context.Usuarios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        */
    }

     public class UsuarioLogin
    {
        public string Email { get; set; }

        public string Senha { get; set; }

        public Usuario usuarioDtoToUsuario()
        {
            var usuario = new Usuario();
            usuario.Email = Email;
            usuario.Senha = Senha;
            return usuario;
        }
    }
}
