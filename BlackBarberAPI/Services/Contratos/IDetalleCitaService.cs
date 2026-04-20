using BlackBarberAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services.Contratos
{
    public interface IDetalleCitaService<T> where T :  DbContext
    {
        Task<List<DetalleCitaDTO>> ObtenerXPerteneciente(int idPerteneciente);
        Task<DetalleCitaDTO> ObtenerXId(int id);
        Task<DetalleCitaDTO> CrearYObtener(DetalleCitaDTO objeto);
        Task<RespuestaDTO> Editar(DetalleCitaDTO objeto);
        Task<RespuestaDTO> Eliminar(int id);
    }
}
