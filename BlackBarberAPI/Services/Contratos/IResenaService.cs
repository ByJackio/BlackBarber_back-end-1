using BlackBarberAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services.Contratos
{
    public interface IResenaService<T> where T : DbContext
    {
        Task<List<ResenaDTO>> ObtenerTodos();
        Task<List<ResenaDTO>> ObtenerXPerteneciente(int idPerteneciente);
        Task<ResenaDTO> ObtenerXId(int idPerteneciente);
        Task<ResenaDTO> CrearYObtener(ResenaDTO objeto);
        Task<RespuestaDTO> Editar(ResenaDTO objeto);
        Task<RespuestaDTO> Eliminar(int id);
    }
}
