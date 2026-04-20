using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class DetalleCitaService<T> : IDetalleCitaService<T> where T : DbContext
    {
        public Task<DetalleCitaDTO> CrearYObtener(DetalleCitaDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(DetalleCitaDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DetalleCitaDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DetalleCitaDTO>> ObtenerXPerteneciente(int idPerteneciente)
        {
            throw new NotImplementedException();
        }
    }
}
