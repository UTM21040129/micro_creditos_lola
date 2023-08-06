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

    public class Clientes : Controller
    {

        private ModelContext db;

        public Clientes(ModelContext database)
        {
            this.db = database;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ClientesModel>> Get()
        {
            return Ok(db.clientesModel.ToList());
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClientesModel json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            db.clientesModel.Add(json);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClientesModel json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            var dbjson = db.clientesModel.Where(a => a.id_cliente == json.id_cliente).FirstOrDefault();
            if (dbjson == null)
            {
                return BadRequest($"Cliente con id json invalido");
            }
            db.Entry(dbjson).CurrentValues.SetValues(json);
            db.Update(dbjson);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id_cliente}")]
        public ActionResult Delete(int? id)
        {
            if (!ModelState.IsValid)
                return BadRequest("Informacion Invalida");
            var dbjson = db.clientesModel.Where(a => a.id_cliente == id).FirstOrDefault();
            if (dbjson == null)
                return BadRequest($"Cliente con id no encontrado");
            db.Remove(dbjson);
            db.SaveChanges();
            return Ok();
        }

    }
}
