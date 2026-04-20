using System;
using System.Collections.Generic;

namespace BlackBarberAPI.Models;

public partial class PreferenciasCliente
{
    public int Id { get; set; }

    public decimal? NumeroNavaja { get; set; }

    public bool? SprayAntiIrritacion { get; set; }

    public int? IdPerfume { get; set; }

    public int? IdCliente { get; set; }

    public virtual Usuario? IdClienteNavigation { get; set; }

    public virtual Perfume? IdPerfumeNavigation { get; set; }
}
