using System.ComponentModel.DataAnnotations;

namespace OsTresMotoqueirosDoApocalipseVerde.Domain.Entities
{
    public class Moto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]{3}[0-9][A-Z0-9][0-9]{2}$",
        ErrorMessage = "Placa inválida. Deve seguir o padrão Mercosul, ex: BRA2E19")]
        public string Placa { get; set; }

        [Required]
        public string Chassi { get; set; }

        public virtual Motorista Motorista { get; set; }

    }
}
