using BlackBarberAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services.Contratos
{
    public interface IPreferenciasClienteService<T> where T : DbContext
    {
        Task<PreferenciasClienteDTO> ObtenerXId(int id);
        Task<List<PreferenciasClienteDTO>> ObtenerXCliente(int idCliente);
        Task<PreferenciasClienteDTO> CrearYEditar(PreferenciasClienteDTO objeto);
        Task<RespuestaDTO> Editar(PreferenciasClienteDTO objeto);
        Task<RespuestaDTO> Eliminar(int id);
    }
}
