using AutoMapper;
using Restaurantes.Application.DTOs;
using Restaurantes.Application.Interfaces;
using Restaurantes.Domain.Entities;
using Restaurantes.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes.Application.Services
{
    public class RestauranteService : IRestauranteService
    {
        private readonly IRestauranteRepository _repository;
        private readonly IMapper _mapper;

        public RestauranteService( IMapper mapper, IRestauranteRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task Add(RestauranteDTO restauranteDTO)
        {
           var entity = _mapper.Map<Restaurante>(restauranteDTO);

            await _repository.Create(entity);
        }

        public async Task Delete(int? id)
        {
            var restaurante = await _repository.Get(id);

            await _repository.Delete(restaurante);

        }

        public async Task<IEnumerable<RestauranteDTO>> GetAll()
        {
            var restaurante = await _repository.GetAll();

            return _mapper.Map<IEnumerable<RestauranteDTO>>(restaurante);
        }

        public async Task<RestauranteDTO> GetById(int id)
        {
            var restaurante = await _repository.Get(id);

            return _mapper.Map<RestauranteDTO>(restaurante);
        }

        public async Task Update(RestauranteDTO restauranteDTO)
        {
            var restaurante = _mapper.Map<Restaurante>(restauranteDTO);

            await _repository.Update(restaurante);
        }
    }
}
