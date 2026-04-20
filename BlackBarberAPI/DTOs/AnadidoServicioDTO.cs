namespace BlackBarberAPI.DTOs
{
    public class AnadidoServicioDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        public int? IdPerteneciente { get; set; }

        public decimal Precio { get; set; }
    }
}
