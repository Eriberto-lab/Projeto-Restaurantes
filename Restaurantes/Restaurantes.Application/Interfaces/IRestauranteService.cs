using Restaurantes.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes.Application.Interfaces
{
    public interface IRestauranteService
    {
        Task<IEnumerable<RestauranteDTO>> GetAll();

        Task<RestauranteDTO> GetById(int id);
        Task Add(RestauranteDTO restauranteDTO);

        Task Update(RestauranteDTO restauranteDTO);
        Task Delete(int? id);
    }
}
