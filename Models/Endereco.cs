using System.ComponentModel.DataAnnotations.Schema;

namespace conexaoemacao.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        public int Id { get; set; }

        // criando um campo nome/rua
        public string? Nome_rua { get; set; }

        // criando um campo numero
        public int Numero { get; set; }
        // criando um campo complemento/endereço
        public string? Complemento { get; set; }

        // criando um campo bairro
        public string? Bairro { get; set; }

        // criando um campo cidade
        public string? Cidade { get; set; }

        // criando um campo estado
        public string? Status { get; set; }

        // criando um campo codigo postal
        public int CEP { get; set; }

    }
}
