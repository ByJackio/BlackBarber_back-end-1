using System;
using System.Collections.Generic;

namespace BlackBarberAPI.Models;

public partial class BarberoServicio
{
    public int Id { get; set; }

    public int? IdBarbero { get; set; }

    public int? IdServicio { get; set; }

    public virtual Barbero? IdBarberoNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }
}
