using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Cluster
    {
        public Cluster()
        {
            Comercios = new HashSet<Comercio>();
        }

        public int IdCluster { get; set; }
        public string? NombreCluster { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual ICollection<Comercio> Comercios { get; set; }
    }
}
