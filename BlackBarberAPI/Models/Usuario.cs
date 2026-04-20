using System;
using System.Collections.Generic;

namespace BlackBarberAPI.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string? PasswordHash { get; set; }

    public byte[] HoraCreacion { get; set; } = null!;

    public int? Estatus { get; set; }

    public int? IdRol { get; set; }

    public virtual ICollection<Barbero> Barberos { get; set; } = new List<Barbero>();

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual Rol? IdRolNavigation { get; set; }

    public virtual ICollection<PreferenciasCliente> PreferenciasClientes { get; set; } = new List<PreferenciasCliente>();

    public virtual ICollection<Resena> Resenas { get; set; } = new List<Resena>();
}
