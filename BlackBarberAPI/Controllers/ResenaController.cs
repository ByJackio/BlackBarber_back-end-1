using BlackBarberAPI.Data;
using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace BlackBarberAPI.Controllers
{
    [Route("api/resena")]
    [ApiController]
    public class ResenaController : ControllerBase
    {
        private readonly IResenaService<BlackBarberContext> _resenaService;

        public ResenaController(IResenaService<BlackBarberContext> resenaService)
        {
            _resenaService = resenaService;
        }

        [HttpGet("ObtenerResenas")]
        public async Task<ActionResult<List<ResenaDTO>>> ObtenerTodas()
        {
            var lista = await _resenaService.ObtenerTodos();
            return lista;
        }

        [HttpGet("ObtenerXCita/{idCita:int}")]
        public async Task<ActionResult<List<ResenaDTO>>> ObtenerXIdCita(int idCita)
        {
            var lista = await _resenaService.ObtenerXPerteneciente(idCita);
            return lista;
        }

        [HttpPost("Crear")]
        public async Task<ActionResult<ResenaDTO>> CrearResena(ResenaDTO resena)
        {
            var respuesta = await _resenaService.CrearYObtener(resena);
            return respuesta;
        }

        [HttpPost("Editar")]
        public async Task<ActionResult<RespuestaDTO>> EditarResena(ResenaDTO resena)
        {
            var respuesta = await _resenaService.Editar(resena);
            return respuesta;
        }

        [HttpPost("Eliminar")]
        public async Task<ActionResult<RespuestaDTO>> Eliminar(int id)
        {
            var respuesta = await _resenaService.Eliminar(id);
            return respuesta;
        }
    }
}
