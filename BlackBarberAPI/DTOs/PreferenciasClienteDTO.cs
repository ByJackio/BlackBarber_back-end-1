namespace BlackBarberAPI.DTOs
{
    public class PreferenciasClienteDTO
    {
        public int Id { get; set; }

        public decimal? NumeroNavaja { get; set; }

        public bool? SprayAntiIrritacion { get; set; }

        public int? IdPerfume { get; set; }

        public int? IdCliente { get; set; }
    }
}
