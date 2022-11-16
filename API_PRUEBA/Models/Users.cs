using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_PRUEBA.Models
{
    public partial class Users
    {
        public string Usuario { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public decimal IdDepartamento { get; set; }
        public decimal IdCargo { get; set; }

        public virtual Cargos IdCargoNavigation { get; set; }
        public virtual Departamentos IdDepartamentoNavigation { get; set; }
    }
}
