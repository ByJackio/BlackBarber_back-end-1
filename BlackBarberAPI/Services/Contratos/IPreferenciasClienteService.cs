using BlackBarberAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services.Contratos
{
    public interface IPreferenciasClienteService<T> where T : DbContext
    {
        Task<PreferenciasClienteDTO> ObtenerXId(int id);
        Task<PreferenciasClienteDTO> ObtenerXIdUsuario(int idUsuario);
        Task<PreferenciasClienteDTO> CrearYObtener(PreferenciasClienteDTO objeto);
        Task<RespuestaDTO> Editar(PreferenciasClienteDTO objeto);
        Task<RespuestaDTO> Eliminar(int id);
    }
}
