using BlackBarberAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services.Contratos
{
    public interface IRolService<T> where T :  DbContext
    {
        Task<List<RolDTO>> ObtenerTodos();
        Task<RolDTO> ObtenerXId(int id);
        Task<RolDTO> CrearYObtener(RolDTO objeto);
        Task<RespuestaDTO> Editar(RolDTO objeto);
        Task<RespuestaDTO> Eliminar(int id);
    }
}
