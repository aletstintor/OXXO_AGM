using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class BitacoraComercio
    {
        public int IdBitacoraComercio { get; set; }
        public int? IdComercio { get; set; }
        public string? IdEmisor { get; set; }
        public string? Comentarios { get; set; }
        public int? Estatus { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual Comercio? IdComercioNavigation { get; set; }
    }
}
