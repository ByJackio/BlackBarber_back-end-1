using System;
using System.Collections.Generic;

namespace BlackBarberAPI.Models;

public partial class TipoServicio
{
    public int Id { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();
}
