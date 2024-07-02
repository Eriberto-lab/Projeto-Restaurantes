using System.ComponentModel.DataAnnotations;

namespace Restaurantes.Application.DTOs
{
    public class RestauranteDTO
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(100)]
        [MinLength(3)]
        [Required]
        public string Nome { get; set; }

        [MaxLength(300)]
        public string EnderecoRestaurante { get; set; }

        public decimal PrecoMedio { get; set; }
        public double AvaliacaoMedia { get; set; }
    }
}