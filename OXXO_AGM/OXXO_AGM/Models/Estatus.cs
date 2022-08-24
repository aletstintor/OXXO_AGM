using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Estatus
    {
        public Estatus()
        {
            Comercios = new HashSet<Comercio>();
        }

        public int IdEstatus { get; set; }
        public string? Estatus1 { get; set; }
        public string? Color { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual ICollection<Comercio> Comercios { get; set; }
    }
}
