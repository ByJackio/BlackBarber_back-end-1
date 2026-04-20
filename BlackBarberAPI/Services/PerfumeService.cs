using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class PerfumeService<T> : IPerfumeService<T> where T : DbContext
    {
        public Task<PerfumeDTO> CrearYObtener(PerfumeDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(PerfumeDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PerfumeDTO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public Task<PerfumeDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
