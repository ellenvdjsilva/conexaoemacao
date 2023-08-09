using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace conexaoemacao.Models
{
    public class Vaga
    {
        [Required]
        public int OngId { get; set; }

        // criação do campo Titulo
        [Required]
        [StringLength(50)]
        public string? Title { get; set; }

        // criação campo sobre a vaga 
        [Required]
        public string? About { get; set; }

        // puxando o campo endereço
        [Required]
        public Endereco? Endereco { get; set; }

        // criação do campo imagem 
        [Required]
        public string? Image { get; set; }

        // criação do campo cargo/ocupação 
        [Required]
        public string? Position { get; set; }

        // criação do campo quantidade vaga 

        [Required]
        public int? Quantity { get; set; }










    }
}
