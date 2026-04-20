using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class PreferenciasClienteService<T> : IPreferenciasClienteService<T> where T : DbContext
    {
        public Task<PreferenciasClienteDTO> CrearYEditar(PreferenciasClienteDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(PreferenciasClienteDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PreferenciasClienteDTO>> ObtenerXCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public Task<PreferenciasClienteDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
