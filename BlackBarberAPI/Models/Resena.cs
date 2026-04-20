using System;
using System.Collections.Generic;

namespace BlackBarberAPI.Models;

public partial class Resena
{
    public int Id { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdCita { get; set; }

    public int? Calificacion { get; set; }

    public string? Comentario { get; set; }

    public virtual Citum? IdCitaNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
