using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Menu
    {
        public Menu()
        {
            Controladors = new HashSet<Controlador>();
        }

        public int IdMenu { get; set; }
        public string NombreMenu { get; set; } = null!;
        public int Orden { get; set; }
        public int Predeterminado { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual ICollection<Controlador> Controladors { get; set; }
    }
}
