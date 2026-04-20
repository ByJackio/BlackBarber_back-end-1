using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class BarberoService<T> : IBarberoService<T> where T : DbContext
    {
        public Task<BarberoDTO> CrearYObtener(BarberoDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(BarberoDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BarberoDTO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public Task<BarberoDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
