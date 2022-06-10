namespace terceirizados_novo.Models.Dto
{
    
    public class UsuarioDTO
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }



        public UsuarioDTO(string Nome, string Email, string Senha)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
        }

        public UsuarioDTO()
        {
        }

        public Usuario usuarioDtoToUsuario()
        {
            var usuario = new Usuario();
            usuario.Email = Email;
            usuario.Nome = Nome;

            return usuario;
        }
    }


}
