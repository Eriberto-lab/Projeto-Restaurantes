using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurantes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes.Infrastructure.EntitiesConfiguration
{
    internal class RestauranteConfiguration : IEntityTypeConfiguration<Restaurante>
    {
        public void Configure(EntityTypeBuilder<Restaurante> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p  => p.EnderecoRestaurante).IsRequired();
            builder.Property(p => p.Nome).IsRequired();

        }
    }
}
