using BlackBarberAPI.Data;
using BlackBarberAPI.DTOs;
using BlackBarberAPI.Services.Contratos;

namespace BlackBarberAPI.Process
{
    public class ServicioProceso
    {
        private readonly IServicioService<BlackBarberContext> _servicioService;
        private readonly IAnadidoServicioService<BlackBarberContext> _anadidoServicioService;
        private readonly IServicioCitaService<BlackBarberContext> _servicioCitaService;
        private readonly IBarberoServicioService<BlackBarberContext> _barberoServicioService;
        private readonly BlackBarberContext _db;

        public ServicioProceso(IServicioService<BlackBarberContext> servicioService, IAnadidoServicioService<BlackBarberContext> anadidoServicioService, IServicioCitaService<BlackBarberContext> servicioCitaService, IBarberoServicioService<BlackBarberContext> barberoServicioService, BlackBarberContext db)
        {
            _servicioService = servicioService;
            _anadidoServicioService = anadidoServicioService;
            _servicioCitaService = servicioCitaService;
            _barberoServicioService = barberoServicioService;
            _db = db;
        }

        public async Task<List<ServicioDTO>> ObtenerTodosServicios()
        {
            var lista = await _servicioService.ObtenerTodos();
            return lista;
        }

        public async Task<RespuestaDTO> CrearServicio(ServicioConArchivoDTO objeto)
        {
            RespuestaDTO respuesta = new RespuestaDTO();
            ServicioDTO servicio = new ServicioDTO
            {
                Nombre = objeto.Nombre,
                Descripcion = objeto.Descripcion,
                IdTipo = objeto.IdTipo,
                PrecioBase = objeto.PrecioBase,
                Estatus = objeto.Estatus
            };
            if(objeto.Archivo != null)
            {
                servicio.Base64 = await GenerarBase64(objeto.Archivo);
            }
            var objetoCreado = await _servicioService.CrearYObtener(servicio);
            respuesta.Estatus = objetoCreado.Id > 0;
            respuesta.Descripcion = respuesta.Estatus ? "Servicio creado exitosamente" : "Error al crear el servicio";
            return respuesta;
        }

        public async Task<RespuestaDTO> EditarServicio(ServicioConArchivoDTO objeto)
        {
            RespuestaDTO respuesta = new RespuestaDTO();
            ServicioDTO servicio = new ServicioDTO
            {
                Id = objeto.Id,
                Nombre = objeto.Nombre,
                Descripcion = objeto.Descripcion,
                IdTipo = objeto.IdTipo,
                PrecioBase = objeto.PrecioBase,
                Horas = objeto.Horas,
                Estatus = objeto.Estatus
            };
            if (objeto.Archivo != null)
            {
                servicio.Base64 = await GenerarBase64(objeto.Archivo);
            }
            respuesta =  await _servicioService.Editar(servicio);
            return respuesta;
        }

        public async Task<RespuestaDTO> EliminarServicio(int id)
        {
            var relacionServicio = await _servicioCitaService.ObtenerXIdServicio(id);
            if(relacionServicio.Count() > 0)
            {
                return new RespuestaDTO
                {
                    Estatus = false,
                    Descripcion = "No se puede eliminar el servicio cuando ya hay citas que lo consumen"
                };
            }
            var anadidosServicio = await _anadidoServicioService.ObtenerXPerteneciente(id);
            var barberoServicio = await _barberoServicioService.ObtenerXIdServicio(id);
            await using var transaction = await _db.Database.BeginTransactionAsync();
            try
            {
                foreach (var relacion in barberoServicio)
                {
                    var relEl = await _barberoServicioService.Eliminar(relacion.Id);
                    if (!relEl.Estatus)
                    {
                        throw new Exception("Ocurrió un problema al intentar remover la asignación.");
                    }
                }
                foreach (var anadido in anadidosServicio)
                {
                    var anEl = await _anadidoServicioService.Eliminar(anadido.Id);
                    if (!anEl.Estatus)
                    {
                        throw new Exception("Ocurrió un problema al intentar eliminar los añadidos.");
                    }
                }
                var respuesta = await _servicioService.Eliminar(id);
                await transaction.CommitAsync();
                return respuesta;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                RespuestaDTO resp = new RespuestaDTO
                {
                    Estatus = false,
                    Descripcion = ex.Message
                };
                return resp;
            }
            
        }

        public async Task<List<AnadidoServicioDTO>> ObtenerAnadidosXPerteneciente(int idServicio)
        {
            var lista = await _anadidoServicioService.ObtenerXPerteneciente(idServicio);
            return lista;
        }

        public async Task<RespuestaDTO> CrearAnadidoServicio(AnadidoServicioDTO objeto)
        {
            RespuestaDTO respuesta = new RespuestaDTO();
            var objetoCreado = await _anadidoServicioService.CrearYObtener(objeto);
            respuesta.Estatus = objetoCreado.Id > 0;
            respuesta.Descripcion = respuesta.Estatus ? "Añadido creado exitosamente" : "Error al crear el añadido";
            return respuesta;
        }

        public async Task<RespuestaDTO> EditarAnadidoServicio(AnadidoServicioDTO objeto)
        {
            RespuestaDTO respuesta = new RespuestaDTO();
            respuesta = await _anadidoServicioService.Editar(objeto);
            return respuesta;
        }

        public async Task<RespuestaDTO> EliminarAnadidoServicio(int id)
        {
            return await _anadidoServicioService.Eliminar(id);
        }

        public async Task<string> GenerarBase64(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                byte[] imageBytes = memoryStream.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                string fullBase64ForFront = $"data:{file.ContentType};base64,{base64String}";
                return fullBase64ForFront;
            }
        }

        public Task<ServicioDTO> ObtenerXId(int id)
        {
            return _servicioService.ObtenerXId(id);
        }
    }
}
