using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class TipoOperacion
    {
        public TipoOperacion()
        {
            Transaccions = new HashSet<Transaccion>();
        }

        public int IdTipoOperacion { get; set; }
        public string? NombreOperacion { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
