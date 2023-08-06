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

    public class Pagos : Controller
    {

        private ModelContext db;

        public Pagos(ModelContext database)
        {
            this.db = database;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PagosModel>> Get()
        {
            return Ok(db.pagosModel.ToList());
        }

        [HttpPost]
        public ActionResult Post([FromBody] PagosModel json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            db.pagosModel.Add(json);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] PagosModel json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            var dbjson = db.pagosModel.Where(a => a.id_pago == json.id_pago).FirstOrDefault();
            if (dbjson == null)
            {
                return BadRequest($"Pago con id json invalido");
            }
            db.Entry(dbjson).CurrentValues.SetValues(json);
            db.Update(dbjson);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id_pago}")]
        public ActionResult Delete(int? id)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            var dbjson = db.pagosModel.Where(a => a.id_pago == id).FirstOrDefault();
            if (dbjson == null)
                return BadRequest($"Pago con id no encontrado");
            db.Remove(dbjson);
            db.SaveChanges();
            return Ok();
        }

    }
}
