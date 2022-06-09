namespace api_terceirizados.Models.Dto
{
    public class UsuarioRespostaDTO
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public UsuarioRespostaDTO(int Id, string Nome, string Email)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Email = Email;
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
