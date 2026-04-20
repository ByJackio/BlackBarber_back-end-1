using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class UsuarioService<T> : IUsuarioService<T> where T : DbContext
    {
        public Task<UsuarioDTO> CrearYObtener(UsuarioDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(UsuarioDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioDTO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
