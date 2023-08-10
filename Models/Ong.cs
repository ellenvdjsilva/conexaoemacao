using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conexaoemacao.Models
{
    [Table("Ongs")]
    public class Ong
    {
        public int Id { get; set; }

        // criando um campo nome
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        // criando um campo descrição
        [Required]
        public string? Descricao{ get; set; }

        // puxando a class endereço
        public Endereco Endereco { get; set; } = new();

        // criando campo telefone
        [Required]
        [StringLength(13)]
        public int Telefone { get; set;}

        // criando campo e-mail
        [Required]
        [StringLength(80)]
        public string? Email { get; set;}

        // criando campo site
        [Required]
        [StringLength(80)]
        public string? Site { get; set; }
    }

}
