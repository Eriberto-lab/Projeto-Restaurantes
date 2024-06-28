using Restaurantes.Domain.DomainValidation;

namespace Restaurantes.Domain.Entities
{
    public sealed class Usuario : BaseEntity
    {
        public string Nome { get; private set; }
        public string EnderecoDaEmpresa { get; private set; }

        public decimal PrecoMedioPorRefeicao { get; private set; }

        public int DiasPresenciais { get; private set; }

        public decimal ValorDoValeRefeicao { get; private set; }

        public Usuario()
        { }

        public Usuario(int id,string nome, string enderecoDaEmpresa, int diasPresenciais, decimal valorDoValeRefeicao)
        {
            if(id != 0)
            {
                Id = id;
            }

            SetNome(nome);
            SetEnderecoDaEmpresa(enderecoDaEmpresa);
            SetPrecoMedioPorRefeicao();
            SetDiasPresenciais(diasPresenciais);
            SetValorDoValeRefeicao(valorDoValeRefeicao);
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new DomainException("Nome não pode ser vazio.");
            }

            Nome = nome;
        }

        public void SetEnderecoDaEmpresa(string enderecoDaEmpresa)
        {
            if (string.IsNullOrWhiteSpace(enderecoDaEmpresa))
            {
                throw new DomainException("Endereço da empresa não pode ser vazio.");
            }

            EnderecoDaEmpresa = enderecoDaEmpresa;
        }

        public void SetPrecoMedioPorRefeicao()
        {

            PrecoMedioPorRefeicao = 5000000;
        }

        public void SetDiasPresenciais(int diasPresenciais)
        {
            if (diasPresenciais < 0 || diasPresenciais > 31)
            {
                throw new DomainException("Dias presenciais deve ser entre 0 e 31.");
            }

            DiasPresenciais = diasPresenciais;
        }

        public void SetValorDoValeRefeicao(decimal valorDoValeRefeicao)
        {
            if (valorDoValeRefeicao < 0)
            {
                throw new DomainException("Valor do vale refeição não pode ser negativo.");
            }

            ValorDoValeRefeicao = valorDoValeRefeicao;
        }
    }
}