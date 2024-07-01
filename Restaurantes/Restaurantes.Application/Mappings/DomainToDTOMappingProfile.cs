using AutoMapper;
using Restaurantes.Application.DTOs;
using Restaurantes.Domain.Entities;

namespace Restaurantes.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        { 
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<Restaurante, RestauranteDTO>().ReverseMap();
        }
    }
}
