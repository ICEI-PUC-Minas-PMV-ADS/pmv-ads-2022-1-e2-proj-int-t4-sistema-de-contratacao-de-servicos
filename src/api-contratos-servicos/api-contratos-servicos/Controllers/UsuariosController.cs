using api_contratos_servicos.Context;
using api_contratos_servicos.Models;
using api_contratos_servicos.Models.Dto;
using api_contratos_servicos.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace api_contratos_servicos.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
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
        public async Task<ActionResult<UsuarioRespostaDTO>> Login([Bind("Email,Senha")]  UsuarioLogin usuario)
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

            var token = TokenService.GenerateToken(usuarioLogado);

            return new UsuarioRespostaDTO(usuarioLogado.Id, usuarioLogado.Nome, usuarioLogado.Email, token, usuarioLogado.Role);

        }


        [Route("cadastrar")]
        [HttpPost]
        public async Task<ActionResult<UsuarioRespostaDTO>> Cadastrar([Bind("Nome,Email,Senha,Tipo,Cpf,Cep,Telefone,Logradouro,Numero,Bairro,Cidade,UF")] UsuarioDTO usuarioDTO
            )
        {
            if (usuarioDTO == null)
            {
                return BadRequest();
            }

            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Usuarios'  is null.");
            }

            //ValidaUsuario
            var usuarioCadastro = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == usuarioDTO.Email);

            if (!(usuarioCadastro == null))
            {
                return new UsuarioRespostaDTO(usuarioCadastro.Id, usuarioCadastro.Nome, usuarioCadastro.Email,usuarioCadastro.Role, null);
            }
            usuarioCadastro = new Usuario(usuarioDTO.Nome, usuarioDTO.Email, usuarioDTO.Senha, usuarioDTO.Tipo);
            _context.Usuarios.Add(usuarioCadastro);
            await _context.SaveChangesAsync();

            //salvar cliente ou Fornecedor
            if (usuarioDTO.Tipo == "cliente") {
                var cliente = usuarioDTO.usuarioCliente();
                cliente.UsuarioId = usuarioCadastro.Id;
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
            } else if(usuarioDTO.Tipo == "fornecedor") {
                var fornecedor = usuarioDTO.usuarioFornecedor();
                fornecedor.UsuarioId = usuarioCadastro.Id;
                _context.Fornecedores.Add(fornecedor);
                await _context.SaveChangesAsync();
            }


            return new UsuarioRespostaDTO(usuarioCadastro.Id, usuarioCadastro.Nome, usuarioCadastro.Email, usuarioCadastro.Role, null);


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
