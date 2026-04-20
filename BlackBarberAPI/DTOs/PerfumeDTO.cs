namespace BlackBarberAPI.DTOs
{
    public class PerfumeDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        public string? Base64 { get; set; }

        public bool? Disponible { get; set; }
    }
}
