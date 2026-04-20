using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class RolService<T> : IRolService<T> where T : DbContext
    {
        public Task<RolDTO> CrearYObtener(RolDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(RolDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RolDTO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public Task<RolDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
