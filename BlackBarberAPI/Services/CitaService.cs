using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class CitaService<T> : ICitaService<T> where T : DbContext
    {
        public Task<CitaDTO> CrearYObtener(CitaDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(CitaDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CitaDTO>> ObtenerTodas()
        {
            throw new NotImplementedException();
        }

        public Task<CitaDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
