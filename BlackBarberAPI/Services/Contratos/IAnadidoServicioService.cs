using BlackBarberAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services.Contratos
{
    public interface IAnadidoServicioService<T> where T: DbContext
    {
        Task<List<AnadidoServicioDTO>> ObtenerXPerteneciente(int idPerteneciente);
        Task<AnadidoServicioDTO> ObtenerXId(int id);
        Task<AnadidoServicioDTO> CrearYObtener(AnadidoServicioDTO objeto);
        Task<RespuestaDTO> Editar(AnadidoServicioDTO objeto);
        Task<RespuestaDTO> Eliminar(int id);
    }
}
