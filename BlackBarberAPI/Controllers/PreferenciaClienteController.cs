using BlackBarberAPI.DTOs;
using BlackBarberAPI.Process;
using Microsoft.AspNetCore.Mvc;

namespace BlackBarberAPI.Controllers
{
    [Route("api/preferenciasCliente")]
    [ApiController]
    public class PreferenciaClienteController : ControllerBase
    {
        private readonly PreferenciasClienteProceso _proceso;

        public PreferenciaClienteController(PreferenciasClienteProceso proceso)
        {
            _proceso = proceso;
        }

        [HttpPost("crearEditar")]
        public async Task<ActionResult<RespuestaDTO>> CrearEditar(PreferenciasClienteDTO objeto)
        {
            var respuesta = await _proceso.CrearEditarPreferencias(objeto);
            return respuesta;
        }

        [HttpGet("obtenerXUsuario")]
        public async Task<ActionResult<PreferenciasClienteDTO>> ObtenerXUsuario(int id)
        {
            var respuesta = await _proceso.ObtenerPreferenciaCliente(id);
            return respuesta;
        }

        [HttpPost("eliminar")]
        public async Task<ActionResult<RespuestaDTO>> Eliminar(int id)
        {
            var respuesta = await _proceso.Eliminar(id);
            return respuesta;
        }
    }
}
