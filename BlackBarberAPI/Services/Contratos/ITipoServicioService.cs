using BlackBarberAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services.Contratos
{
    public interface ITipoServicioService<T> where T : DbContext
    {
        Task<List<TipoServicioDTO>> ObtenerTodos();
        Task<TipoServicioDTO> ObtenerXId(int id);
        Task<TipoServicioDTO> CrearYObtener(TipoServicioDTO objeto);
        Task<RespuestaDTO> Editar(TipoServicioDTO objeto);
        Task<RespuestaDTO> Eliminar(int id);
    }
}
