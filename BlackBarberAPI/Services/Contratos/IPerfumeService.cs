using BlackBarberAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services.Contratos
{
    public interface IPerfumeService<T> where T : DbContext
    {
        Task<List<PerfumeDTO>> ObtenerTodos();
        Task<PerfumeDTO> ObtenerXId(int id);
        Task<PerfumeDTO> CrearYObtener(PerfumeDTO objeto);
        Task<RespuestaDTO> Editar(PerfumeDTO objeto);
        Task<RespuestaDTO> Eliminar(int id);
    }
}
