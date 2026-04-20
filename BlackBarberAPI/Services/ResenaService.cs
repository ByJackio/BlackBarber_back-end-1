using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class ResenaService<T> : IResenaService<T> where T : DbContext
    {
        public Task<ResenaDTO> CrearYObtener(ResenaDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(ResenaDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResenaDTO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public Task<ResenaDTO> ObtenerXId(int idPerteneciente)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResenaDTO>> ObtenerXPerteneciente(int idPerteneciente)
        {
            throw new NotImplementedException();
        }
    }
}
