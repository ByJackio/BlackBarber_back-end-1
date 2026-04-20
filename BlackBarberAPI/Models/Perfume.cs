using System;
using System.Collections.Generic;

namespace BlackBarberAPI.Models;

public partial class Perfume
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Base64 { get; set; }

    public bool? Disponible { get; set; }

    public virtual ICollection<PreferenciasCliente> PreferenciasClientes { get; set; } = new List<PreferenciasCliente>();
}
