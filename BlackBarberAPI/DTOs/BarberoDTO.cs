namespace BlackBarberAPI.DTOs
{
    public class BarberoDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public int? IdUsuario { get; set; }

        public int? Estatus { get; set; }
    }

    public class BarberoListadoDTO : BarberoDTO
    {
        public string NombreUsuario { get; set; } = "";
        public string DescripcionEstatus { get; set; } = "";
    }

    public class AsignacionBarberoDTO
    {
        public int IdUsuario { get; set; }
        public int IdBarbero { get; set; }
    }
}
