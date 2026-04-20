using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class BarberoServicioService<T> : IBarberoServicioService<T> where T : DbContext
    {
        public Task<BarberoServicioDTO> CrearYObtener(BarberoServicioDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(BarberoServicioDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<List<BarberoServicioDTO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public Task<BarberoServicioDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
