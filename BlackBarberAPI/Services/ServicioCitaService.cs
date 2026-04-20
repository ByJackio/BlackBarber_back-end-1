using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class ServicioCitaService<T> : IServicioCitaService<T> where T : DbContext
    {
        public Task<ServicioCitaDTO> CrearYObtener(ServicioCitaDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(ServicioCitaDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServicioCitaDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServicioCitaDTO>> ObtenerXPerteneciente(int idPerteneciente)
        {
            throw new NotImplementedException();
        }
    }
}
