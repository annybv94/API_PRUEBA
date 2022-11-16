using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_PRUEBA.Models.Request
{
    public class CargoRequest
    {
        public decimal Id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public bool activo { get; set; }
        public decimal idUsuarioCreacion { get; set; }
    }
}
