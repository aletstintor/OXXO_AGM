using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? UserName { get; set; }
        public string? Contrasena { get; set; }
        public string? Correo { get; set; }
        public string? Puesto { get; set; }
        public DateTime? Vigencia { get; set; }
        public int? IdPerfil { get; set; }
        public int? IdCompania { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual Compania? IdCompaniaNavigation { get; set; }
        public virtual Perfil? IdPerfilNavigation { get; set; }
    }
}
