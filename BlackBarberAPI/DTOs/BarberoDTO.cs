namespace BlackBarberAPI.DTOs
{
    public class BarberoDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public int? IdUsuario { get; set; }

        public int? Estatus { get; set; }
    }
}
