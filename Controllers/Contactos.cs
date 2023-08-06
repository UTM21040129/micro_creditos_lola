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

    public class Contactos : Controller
    {

        private ModelContext db;

        public Contactos(ModelContext database)
        {
            this.db = database;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ContactosModel>> Get()
        {
            return Ok(db.contactosModel.ToList());
        }

        [HttpPost]
        public ActionResult Post([FromBody] ContactosModel json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            db.contactosModel.Add(json);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] ContactosModel json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            var dbjson = db.contactosModel.Where(a => a.id_contacto == json.id_contacto).FirstOrDefault();
            if (dbjson == null)
            {
                return BadRequest($"Contacto con id json invalido");
            }
            db.Entry(dbjson).CurrentValues.SetValues(json);
            db.Update(dbjson);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id_contacto}")]
        public ActionResult Delete(int? id)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            var dbjson = db.contactosModel.Where(a => a.id_contacto == id).FirstOrDefault();
            if (dbjson == null)
                return BadRequest($"Contacto con id no encontrado");
            db.Remove(dbjson);
            db.SaveChanges();
            return Ok();
        }

    }
}
