using System.ComponentModel.DataAnnotations;

namespace conexaoemacao.Models
{
    public class Voluntario
    {
        public int Id { get; set; }

        // criando um campo nome
        [Required]
        [StringLength(50)]
        public string? Nome { get; set; }

        // criando campo idade 
        [Required]
        [Range(16,120)] // arrumar ainda 
        public int Idade { get; set; }

        // criando um campo CPF
        [Required]
        public int CPF { get; set; }

        // puxando a class endereço
        public Endereco Endereco { get; set; } = new();

        // criando campo telefone
        [Required]
        public int Telefone { get; set; }

        // criando campo e-mail
        [Required]
        [StringLength(80)]
        public string? Email { get; set; }

        public string? MensagemdeDescr { get; set; }


    }
}
