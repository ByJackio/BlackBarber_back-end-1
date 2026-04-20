using System;
using System.Collections.Generic;

namespace BlackBarberAPI.Models;

public partial class Servicio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? IdTipo { get; set; }

    public decimal PrecioBase { get; set; }

    public string? Base64 { get; set; }

    public int? Estatus { get; set; }

    public virtual ICollection<AnadidoServicio> AnadidoServicios { get; set; } = new List<AnadidoServicio>();

    public virtual ICollection<BarberoServicio> BarberoServicios { get; set; } = new List<BarberoServicio>();

    public virtual TipoServicio? IdTipoNavigation { get; set; }

    public virtual ICollection<ServicioCitum> ServicioCita { get; set; } = new List<ServicioCitum>();
}
