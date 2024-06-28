using Restaurantes.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioDTO>> GetAll();

        Task<UsuarioDTO> GetById(int id);
        Task Add(UsuarioDTO usuarioDTO);

        Task Update(UsuarioDTO usuarioDTO);
        Task Delete(int? id);
    }
}
