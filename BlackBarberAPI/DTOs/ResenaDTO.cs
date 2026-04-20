namespace BlackBarberAPI.DTOs
{
    public class ResenaDTO
    {
        public int Id { get; set; }

        public int? IdUsuario { get; set; }

        public int? IdCita { get; set; }

        public int? Calificacion { get; set; }

        public string? Comentario { get; set; }
    }
}
