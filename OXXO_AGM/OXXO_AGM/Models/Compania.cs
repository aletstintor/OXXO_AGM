using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Compania
    {
        public Compania()
        {
            Comercios = new HashSet<Comercio>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdCompania { get; set; }
        public string? Compania1 { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual ICollection<Comercio> Comercios { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
