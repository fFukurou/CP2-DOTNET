using OsTresMotoqueirosDoApocalipseVerde.Domain.Entities;
using OsTresMotoqueirosDoApocalipseVerde.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OsTresMotoqueirosDoApocalipseVerde.Application.DTOs
{
    public class CreateMotoristaDto
    {
        [Required]
        [EnumDataType(typeof(Plano))]
        public Plano Plano { get; set; }

        // Foreign key
        public int? MotoId { get; set; }
    }
}
