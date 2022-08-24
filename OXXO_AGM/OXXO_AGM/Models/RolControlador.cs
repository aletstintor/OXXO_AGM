using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class RolControlador
    {
        public int IdRol { get; set; }
        public int? IdPerfil { get; set; }
        public int IdControlador { get; set; }
        public int IdAccion { get; set; }
        public int Leer { get; set; }
        public int Crear { get; set; }
        public int Editar { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual Controlador IdControladorNavigation { get; set; } = null!;
        public virtual Perfil? IdPerfilNavigation { get; set; }
    }
}
