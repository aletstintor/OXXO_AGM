using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdTipoDocumento { get; set; }
        public string? NombreDocumento { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoArchivo { get; set; }
        public int? PersonaFisica { get; set; }
        public int? PersonaMoral { get; set; }
        public int? Obligatorio { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
