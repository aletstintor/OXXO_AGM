using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class AccionControlador
    {
        public int IdAccion { get; set; }
        public string NombreAccion { get; set; } = null!;
        public string Encabezado { get; set; } = null!;
        public int Item { get; set; }
        public int? IdControlador { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual Controlador? IdControladorNavigation { get; set; }
    }
}
