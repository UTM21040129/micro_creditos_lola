using micro_creditos_api.Models;
using Microsoft.AspNetCore.Mvc;
namespace micro_creditos_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    /*
 
    JJSHdz
                           _.-~~-.._
                         ,~         ~-.
             _..._.--.  <              `.
           ,~         \ ,                \
          /            \|   ,            |
         /        ,.   |\   ,\  \_       '
        /         )|   / \  ||``|~`-    '
       |        _| '",/   `.',   `</|  |
        |      /\   )|,    | .   ~~ () |  _.
        \     /\''  ,\      \   _  / .-','_ \
         \_  (\,   ~ /       ~-~__.\_~`~_/ ~'
           `. ~\   -~      .-\/~   `--~~
             ~~~|  | ,~\  '           `
              '~\`-..\\ ~|''           \
             /  `\    )\ |
           .~.   |`--~           
            \\   \                      
             |~
 
     */

    public class Prestamos : Controller
    {

        private ModelContext db;

        public Prestamos(ModelContext database)
        {
            this.db = database;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PrestamosModel>> Get()
        {
            return Ok(db.prestamosModel.ToList());
        }

        [HttpPost]
        public ActionResult Post([FromBody] PrestamosModel json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            db.prestamosModel.Add(json);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] PrestamosModel json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            var dbjson = db.prestamosModel.Where(a => a.id_prestamo == json.id_prestamo).FirstOrDefault();
            if (dbjson == null)
            {
                return BadRequest($"Prestamo con id json invalido");
            }
            db.Entry(dbjson).CurrentValues.SetValues(json);
            db.Update(dbjson);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id_prestamo}")]
        public ActionResult Delete(int? id)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            var dbjson = db.prestamosModel.Where(a => a.id_prestamo == id).FirstOrDefault();
            if (dbjson == null)
                return BadRequest($"Prestamo con id no encontrado");
            db.Remove(dbjson);
            db.SaveChanges();
            return Ok();
        }

    }
}
