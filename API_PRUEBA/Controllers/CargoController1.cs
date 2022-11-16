using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_PRUEBA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController1 : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.PRUEBAContext db = new Models.PRUEBAContext())
            {
                var lst = (from d in db.Cargos
                           select d).ToList();
                return Ok(lst);
            }
        }
    }
}
