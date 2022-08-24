using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Referencium
    {
        public int IdReferencia { get; set; }
        public int? IdComercio { get; set; }
        public string? IdServicio { get; set; }
        public string? NombreCliente { get; set; }
        public string? ReferenciaMerchant { get; set; }
        public string? ReferenciaCliente { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual Comercio? IdComercioNavigation { get; set; }
    }
}
