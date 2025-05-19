using OsTresMotoqueirosDoApocalipseVerde.Domain.Entities;
using OsTresMotoqueirosDoApocalipseVerde.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OsTresMotoqueirosDoApocalipseVerde.Application.DTOs
{
    public class ReadMotoristaDto
    {
        public int Id { get; set; }
        public Plano Plano { get; set; }

        public ReadMotoDto Moto { get; set; }
    }
}
