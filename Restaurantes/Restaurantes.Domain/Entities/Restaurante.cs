using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes.Domain.Entities
{
    public sealed class Restaurante : BaseEntity
    {
        public string Nome { get; private set; }
        public string EnderecoRestaurante { get; private set; }
        public decimal PrecoMedio { get; private set; }
        public bool IsBlocked { get;  private set; }
        public IEnumerable<Avaliacao> Avaliacaos { get; private set; }

        public Restaurante(string nome, string endereco, decimal precoMedio)
        {
            Nome = nome;
            EnderecoRestaurante = endereco;
            PrecoMedio = precoMedio;

        }

        public void BlockRestaurant()
        {
            IsBlocked = true;
        }

        public void UnblockRestaurant()
        {
            IsBlocked = false;
        }

    }
}
