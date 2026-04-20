using System;
using System.Collections.Generic;

namespace BlackBarberAPI.Models;

public partial class Promocion
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }
}
