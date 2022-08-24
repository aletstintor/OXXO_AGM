using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Controlador
    {
        public Controlador()
        {
            AccionControladors = new HashSet<AccionControlador>();
            RolControladors = new HashSet<RolControlador>();
        }

        public int IdControlador { get; set; }
        public string? NombreControlador { get; set; }
        public string? Texto { get; set; }
        public int? IdMenuPadre { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual Menu? IdMenuPadreNavigation { get; set; }
        public virtual ICollection<AccionControlador> AccionControladors { get; set; }
        public virtual ICollection<RolControlador> RolControladors { get; set; }
    }
}
