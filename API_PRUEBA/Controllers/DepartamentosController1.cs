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
    public class DepartamentosController1 : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.PRUEBAContext db = new Models.PRUEBAContext())
            {
                var lst = (from d in db.Departamentos
                           select d).ToList();
                return Ok(lst);
            }
        }

    }

    
   
}
