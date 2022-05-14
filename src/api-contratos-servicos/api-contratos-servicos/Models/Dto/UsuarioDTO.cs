namespace api_contratos_servicos.Models.Dto
{
    
    public class UsuarioDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public UsuarioDTO(int Id, string Nome, string Email)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Email = Email;
        }

        public UsuarioDTO()
        {
        }

        public Usuario usuarioDtoToUsuario()
        {
            var usuario = new Usuario();
            usuario.Email = Email;
            usuario.Nome = Nome;
            usuario.Id = Id;

            return usuario;
        }
    }


}
