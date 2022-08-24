using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class GiroComercio
    {
        public GiroComercio()
        {
            Comercios = new HashSet<Comercio>();
        }

        public int IdGiroComercio { get; set; }
        public string? GiroComercial { get; set; }
        public decimal? Tasa { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual ICollection<Comercio> Comercios { get; set; }
    }
}
