namespace Restaurantes.Domain.DomainValidation
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
