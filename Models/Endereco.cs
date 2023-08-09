using System.ComponentModel.DataAnnotations.Schema;

namespace conexaoemacao.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        public int Id { get; set; }

        // criando um campo nome/rua
        public string? Road { get; set; }

        // criando um campo numero
        public int Nombre { get; set; }
        // criando um campo complemento/endereço
        public string? AddressLine { get; set; }

        // criando um campo bairro
        public string? Neighborhood { get; set; }

        // criando um campo cidade
        public string? City { get; set; }

        // criando um campo estado
        public string? State { get; set; }

        // criando um campo codigo postal
        public int ZipCode { get; set; }

    }
}
