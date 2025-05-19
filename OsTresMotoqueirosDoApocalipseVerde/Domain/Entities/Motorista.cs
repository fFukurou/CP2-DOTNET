using OsTresMotoqueirosDoApocalipseVerde.Domain.Enums;
using System.ComponentModel.DataAnnotations;

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
        public int? MotoId { get; set; }
        public virtual Moto Moto { get; set; }
    }

}
