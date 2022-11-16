using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_PRUEBA.Models
{
    public partial class Cargos
    {
        public Cargos()
        {
            Users = new HashSet<Users>();
        }

        public decimal Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public decimal IdUsuarioCreacion { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
