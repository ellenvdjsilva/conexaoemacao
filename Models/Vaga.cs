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
        public string? Titulo { get; set; }

        // criação campo sobre a vaga 
        [Required]
        public string? Sobre { get; set; }

        // puxando o campo endereço
        [Required]
        public Endereco? Endereco { get; set; }

        // criação do campo imagem 
        [Required]
        public string? Imagem { get; set; }

        // criação do campo cargo/ocupação 
        [Required]
        public string? Cargo { get; set; }

        // criação do campo quantidade vaga 

        [Required]
        public int? Quantidade_vaga { get; set; }










    }
}
