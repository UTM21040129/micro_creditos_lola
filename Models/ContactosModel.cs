using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace micro_creditos_api.Models
{
    [Table("contactos")]

    public class ContactosModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id_contacto")]
        public int id_contacto { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("telefono")]
        public string telefono { get; set; }

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
