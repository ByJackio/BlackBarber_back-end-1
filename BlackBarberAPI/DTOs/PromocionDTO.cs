namespace BlackBarberAPI.DTOs
{
    public class PromocionDTO
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public DateOnly FechaInicio { get; set; }

        public DateOnly FechaFin { get; set; }
    }
}
