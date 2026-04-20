using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.EntityFrameworkCore;

namespace BlackBarberAPI.Services
{
    public class PromocionService<T> : IPromocionService<T> where T : DbContext
    {
        public Task<PromocionDTO> CrearYObtener(PromocionDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Editar(PromocionDTO objeto)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaDTO> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PromocionDTO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public Task<PromocionDTO> ObtenerXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
