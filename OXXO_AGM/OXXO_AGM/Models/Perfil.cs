using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Perfil
    {
        public Perfil()
        {
            RolControladors = new HashSet<RolControlador>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdPerfil { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool? Edicion { get; set; }
        public bool? Carga { get; set; }
        public bool? Aprobacion { get; set; }
        public bool? Categorizacion { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual ICollection<RolControlador> RolControladors { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
