using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conexaoemacao.Models
{
    [Table("Candidaturas")]
    public record Candidatura
    {   
        public int Id { get; set; }
       
        public string Mensagem { get; set; } = string.Empty;
        
        public string Status { get; set; } = string.Empty;

        public Voluntario Candidato { get; set; } = new();
        public Vaga Vaga { get; set; } = new();

    }
}
