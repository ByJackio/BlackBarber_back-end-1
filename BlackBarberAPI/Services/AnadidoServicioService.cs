using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class AnadidoServicioService<T> : IAnadidoServicioService<T> where T : DbContext
    {
        public Task<AnadidoServicioDTO> CrearYObtener(AnadidoServicioDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(AnadidoServicioDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AnadidoServicioDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AnadidoServicioDTO>> ObtenerXPerteneciente(int idPerteneciente)
        {
            throw new NotImplementedException();
        }
    }
}
