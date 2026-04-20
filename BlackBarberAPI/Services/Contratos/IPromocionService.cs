using BlackBarberAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services.Contratos
{
    public interface IPromocionService<T> where T :  DbContext
    {
        Task<List<PromocionDTO>> ObtenerTodos();
        Task<PromocionDTO> ObtenerXId(int id);
        Task<PromocionDTO> CrearYObtener(PromocionDTO objeto);
        Task<RespuestaDTO> Editar(PromocionDTO objeto);
        Task<RespuestaDTO> Eliminar(int id);
    }
}
