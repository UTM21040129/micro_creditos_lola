using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace micro_creditos_api.Models
{
    [Table("clientes")]
    public class ClientesModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id_cliente")]
        public int id_cliente { get; set; }

        [Column("nombre")]
        public string nombre { get; set; }

        [Column("apellido_paterno")]
        public string apellido_paterno { get; set; }

        [Column("apellido_materno")]
        public string apellido_materno { get; set; }

        [Column("id_contacto")]
        public int id_contacto { get; set; }
    }
}

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
