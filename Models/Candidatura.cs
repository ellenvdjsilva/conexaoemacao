using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conexaoemacao.Models
{
    [Table("Candidaturas")]
    public class Candidatura
    {
        public int VagaId { get; set; }
        public int CandidatoId { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        [StringLength(100)]
        public string Status { get; set; } = string.Empty;
        [StringLength(50)]


    }
}
