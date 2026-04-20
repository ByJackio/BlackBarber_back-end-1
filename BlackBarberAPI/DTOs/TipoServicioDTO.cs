namespace BlackBarberAPI.DTOs
{
    public class TipoServicioDTO
    {
        public int Id { get; set; }

        public string NombreCompleto { get; set; } = null!;

        public string? Descripcion { get; set; }
    }
}
