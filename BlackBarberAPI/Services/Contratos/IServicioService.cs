using BlackBarberAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services.Contratos
{
    public interface IServicioService<T> where T :  DbContext
    {
        Task<List<ServicioDTO>> ObtenerTodos();
        Task<ServicioDTO> ObtenerXId(int id);
        Task<ServicioDTO> CrearYObtener(ServicioDTO objeto);
        Task<RespuestaDTO> Editar(ServicioDTO objeto);
        Task<RespuestaDTO> Eliminar(int id);
    }
}
