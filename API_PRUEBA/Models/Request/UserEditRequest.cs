using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_PRUEBA.Models.Request
{
    public class UserEditRequest
    {
        public string Usuario { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public decimal IdDepartamento { get; set; }
        public decimal IdCargo { get; set; }
    }
}
