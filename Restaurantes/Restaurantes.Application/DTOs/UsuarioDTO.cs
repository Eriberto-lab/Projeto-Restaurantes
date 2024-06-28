using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes.Application.DTOs
{
    public class UsuarioDTO
    {
        [Required]
        
        public int Id {  get; set; }

        [MaxLength(100)]
        [MinLength(3)]
        
        public string? Nome { get;  set; }

        [MaxLength(300)]
       
        public string? EnderecoDaEmpresa { get;  set; }

        public decimal PrecoMedioPorRefeicao { get;  set; }

        public int DiasPresenciais { get;  set; }

        public decimal ValorDoValeRefeicao { get; set; }
    }
}
