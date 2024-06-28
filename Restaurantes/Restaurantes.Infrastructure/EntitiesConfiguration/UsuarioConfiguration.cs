using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurantes.Domain.Entities;

namespace Restaurantes.Infrastructure.EntitiesConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(t => t.Id);
         
            builder.Property(p => p.DiasPresenciais).IsRequired();
            builder.Property(p => p.EnderecoDaEmpresa).IsRequired();
            builder.Property(p => p.ValorDoValeRefeicao).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.PrecoMedioPorRefeicao).IsRequired().HasColumnType("decimal(18,2)");

            builder.HasData(

                new Usuario(1,"Eriberto Lima", "Rua Jorge Beretta", 10, 2.000m),
                new Usuario(2,"Jhon Dee", "Street 10", 20, 1.000m),
                new Usuario(3,"Fulano de tal", "Rua beltrano azevedo", 10, 500)

                );
        }
    }
}