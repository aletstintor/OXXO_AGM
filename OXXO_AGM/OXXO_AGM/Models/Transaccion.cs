using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Transaccion
    {
        public int IdTransaccion { get; set; }
        public string? Referencia { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Hora { get; set; }
        public decimal? Monto { get; set; }
        public string? Tienda { get; set; }
        public int? IdEstatusPago { get; set; }
        public int? IdEmisor { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdTipoOperacion { get; set; }
        public int? IdComercio { get; set; }
        public string? IdServicio { get; set; }
        public string? NombreCliente { get; set; }
        public string? ReferenciaMerchant { get; set; }
        public string? ReferenciaCliente { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual Comercio? IdComercioNavigation { get; set; }
        public virtual EstatusPago? IdEstatusPagoNavigation { get; set; }
        public virtual TipoOperacion? IdTipoOperacionNavigation { get; set; }
    }
}
