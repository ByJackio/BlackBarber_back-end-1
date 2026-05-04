using System;
using System.Collections.Generic;

namespace BlackBarberAPI.Models;

public partial class Citum
{
    public int Id { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaTermino { get; set; }

    public int? IdCliente { get; set; }

    public int? Estatus { get; set; } //1: Creada   2: Finalizada   3: Cancelada

    public virtual Usuario? IdClienteNavigation { get; set; }

    public virtual ICollection<Resena> Resenas { get; set; } = new List<Resena>();

    public virtual ICollection<ServicioCitum> ServicioCita { get; set; } = new List<ServicioCitum>();
}
