using BlackBarberAPI.Data;
using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;

namespace BlackBarberAPI.Process
{
    public class PreferenciasClienteProceso
    {
        private readonly IPreferenciasClienteService<BlackBarberContext> _preferenciasClienteService;

        public PreferenciasClienteProceso(IPreferenciasClienteService<BlackBarberContext> preferenciasClienteService)
        {
            _preferenciasClienteService = preferenciasClienteService;
        }

        public async Task<RespuestaDTO> CrearEditarPreferencias(PreferenciasClienteDTO objeto)
        {
            RespuestaDTO respuesta = new RespuestaDTO();
            var existente = await _preferenciasClienteService.ObtenerXIdUsuario((int)objeto.IdCliente);
            if(existente.Id > 0)
            {
                existente.NumeroNavaja = objeto.NumeroNavaja;
                existente.SprayAntiIrritacion = objeto.SprayAntiIrritacion;
                existente.IdPerfume = objeto.IdPerfume;
                respuesta = await _preferenciasClienteService.Editar(existente);
                return respuesta;
            }
            else
            {
                var creado = await _preferenciasClienteService.CrearYObtener(objeto);
                respuesta.Estatus = creado.Id > 0;
                respuesta.Descripcion = respuesta.Estatus ? "Preferencias establecidas correctanente." : "Ocurrió un error al intentar establecer las preferencias.";
                return respuesta;
            }
        }

        public async Task<PreferenciasClienteDTO> ObtenerPreferenciaCliente(int idCliente)
        {
            var preferencia = await _preferenciasClienteService.ObtenerXIdUsuario(idCliente);
            return preferencia;
        }

        public async Task<RespuestaDTO> Eliminar(int id)
        {
            var respuesta = await _preferenciasClienteService.Eliminar(id);
            return respuesta;
        }
    }
}
