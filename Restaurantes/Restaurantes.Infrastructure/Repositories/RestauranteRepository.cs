using Restaurantes.Domain.Entities;
using Restaurantes.Domain.Interfaces;
using Restaurantes.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes.Infrastructure.Repositories
{
    public class RestauranteRepository : BaseRepository<Restaurante>, IRestauranteRepository
    {
        public RestauranteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
