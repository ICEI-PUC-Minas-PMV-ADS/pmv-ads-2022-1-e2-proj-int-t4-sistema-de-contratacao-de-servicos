namespace api_contratos_servicos.Models.Dto
{
    
    public class UsuarioDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }


        public UsuarioDTO(string Nome, string Email, string Senha, string tipo,
                          string Cpf, string Cep, string Telefone, string Logradouro, 
                          string Numero, string Bairro, string Cidade, string UF)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
            this.Tipo = tipo;
            this.Cpf = Cpf;
            this.Cep = Cep;
            this.Telefone = Telefone;
            this.Logradouro = Logradouro;
            this.Numero = Numero;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.UF = UF;
        }

        public UsuarioDTO(string Nome, string Email, string Senha, string tipo)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
            this.Tipo = tipo;
        }

        public UsuarioDTO()
        {
        }

        public Usuario usuarioDtoToUsuario()
        {
            var usuario = new Usuario();
            usuario.Email = Email;
            usuario.Nome = Nome;
            usuario.Role = Tipo;

            return usuario;
        }

        public Cliente usuarioCliente()
        {
            var cliente = new Cliente();
            cliente.cpf = Cpf;
            cliente.Telefone = Telefone;
            cliente.Logradouro = Logradouro;
            cliente.Bairro = Bairro;
            cliente.Numero = Numero;
            cliente.Cidade = Cidade;
            cliente.UF = UF;
            cliente.CEP = Cep;

            return cliente;
        }

        public Fornecedor usuarioFornecedor()
        {
            var fornecedor = new Fornecedor();
            fornecedor.cpf = Cpf;
            fornecedor.Telefone = Telefone;
            fornecedor.Logradouro = Logradouro;
            fornecedor.Bairro = Bairro;
            fornecedor.Numero = Numero;
            fornecedor.Cidade = Cidade;
            fornecedor.UF = UF;
            fornecedor.CEP = Cep;

            return fornecedor;
        }
    }


}
