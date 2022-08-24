using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Documento
    {
        public int IdArchivo { get; set; }
        public string? Nombre { get; set; }
        public byte[]? Archivo { get; set; }
        public string? Extension { get; set; }
        public int IdTipoDocumento { get; set; }
        public int? IdComercio { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual Comercio? IdComercioNavigation { get; set; }
        public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
    }
}
