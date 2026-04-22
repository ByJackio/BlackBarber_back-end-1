using BlackBarberAPI.Data;
using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;

namespace BlackBarberAPI.Process
{
    public class UsuarioProceso
    {
        private readonly IUsuarioService<BlackBarberContext> _usuarioService;

        public UsuarioProceso(IUsuarioService<BlackBarberContext> usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public async Task<RespuestaDTO> CrearUsuario()
        {
            RespuestaDTO respuesta = new RespuestaDTO();
            return respuesta;
        }
    }
}
