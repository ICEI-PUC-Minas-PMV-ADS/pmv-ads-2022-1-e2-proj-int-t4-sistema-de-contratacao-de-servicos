namespace api_contratos_servicos.Models.Dto
{
    public class UsuarioRespostaDTO
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public string Tipo { get; set; }

        public UsuarioRespostaDTO(int id, string nome, string email, string token, string tipo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Token = token;
            this.Tipo = tipo;
        }

        public UsuarioRespostaDTO()
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
