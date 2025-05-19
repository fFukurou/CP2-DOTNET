using OsTresMotoqueirosDoApocalipseVerde.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OsTresMotoqueirosDoApocalipseVerde.Domain.Entities
{
    public class Motorista
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [EnumDataType(typeof(Plano))]
        public Plano Plano { get; set; }

        // Foreign key
        [ForeignKey("Moto")]
        public int? MotoId { get; set; }
        public virtual Moto Moto { get; set; }
    }

}
