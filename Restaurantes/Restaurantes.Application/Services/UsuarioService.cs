using AutoMapper;
using Restaurantes.Application.DTOs;
using Restaurantes.Application.Interfaces;
using Restaurantes.Domain.Entities;
using Restaurantes.Domain.Interfaces;

namespace Restaurantes.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IMapper mapper, IUsuarioRepository usuarioRepository)
        {
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;
            
        }
        public async Task Add(UsuarioDTO usuarioDTO)
        {
            var categoryEntity = _mapper.Map<Usuario>(usuarioDTO);

            await _usuarioRepository.Create(categoryEntity);
        }

        public async Task Delete(int? id)
        {
            var usuario = _usuarioRepository.Get(id).Result;

            await _usuarioRepository.Delete(usuario);
        }

        public async Task<IEnumerable<UsuarioDTO>> GetAll()
        {
            var usuarios = await _usuarioRepository.GetAll();

            return _mapper.Map<IEnumerable<UsuarioDTO>>(usuarios);
        }

        public async Task<UsuarioDTO> GetById(int id)
        {
            var usuario = await _usuarioRepository.Get(id);

            return _mapper.Map<UsuarioDTO>(usuario);
        }

      

        public async Task Update(UsuarioDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);

            await _usuarioRepository.Update(usuario);
        }
    }
}