using System.ComponentModel.DataAnnotations;

namespace conexaoemacao.Models
{
    public class Voluntario
    {
        public int Id { get; set; }

        // criando um campo nome
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        // criando campo idade 
        [Required]
        [MinLength(16)] // arrumar ainda 
        public int Age { get; set; }

        // criando um campo CPF
        [Required]
        [StringLength(14)]
        public int CPF { get; set; }

        // puxando a class endereço
        public Endereco Endereco { get; set; } = new();

        // criando campo telefone
        [Required]
        [StringLength(13)]
        public int Phone { get; set; }

        // criando campo e-mail
        [Required]
        [StringLength(80)]
        public string? Email { get; set; }

        


    }
}
