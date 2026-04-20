using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class SercicioService<T> : IServicioService<T> where T : DbContext
    {
        public Task<ServicioDTO> CrearYObtener(ServicioDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(ServicioDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServicioDTO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public Task<ServicioDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
