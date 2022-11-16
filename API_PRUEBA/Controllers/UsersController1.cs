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
    public class UsersController1 : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.PRUEBAContext db = new Models.PRUEBAContext())
            {
                var lst = (from d in db.Users
                           select d).ToList();
                return Ok(lst);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.UsersRequest model)
        {
            using (Models.PRUEBAContext db = new Models.PRUEBAContext())
            {
                Models.Users usu = new Models.Users();
                usu.Usuario = model.Usuario;
                usu.PrimerNombre = model.PrimerNombre;
                usu.SegundoNombre = model.SegundoNombre;
                usu.PrimerApellido = model.PrimerApellido;
                usu.SegundoApellido = model.SegundoApellido;
                usu.IdDepartamento = model.IdDepartamento;
                usu.IdCargo = model.IdCargo;
                db.Users.Add(usu);
                db.SaveChanges();
            }
            return Ok();
        }

        [HttpPut]
        public ActionResult Post([FromBody] Models.Request.UserEditRequest model)
        {
            using (Models.PRUEBAContext db = new Models.PRUEBAContext())
            {
                Models.Users usu = db.Users.Find(model.Usuario);
                usu.PrimerNombre = model.PrimerNombre;
                usu.SegundoNombre = model.SegundoNombre;
                usu.PrimerApellido = model.PrimerApellido;
                usu.SegundoApellido = model.SegundoApellido;
                usu.IdDepartamento = model.IdDepartamento;
                usu.IdCargo = model.IdCargo;
                db.Entry(usu).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Models.Request.UsersRequest model)
        {
            using (Models.PRUEBAContext db = new Models.PRUEBAContext())
            {
                Models.Users usu = db.Users.Find(model.Usuario);
                db.Users.Remove(usu);
                db.SaveChanges();
            }
            return Ok();
        }
    }
}
