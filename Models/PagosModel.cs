using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace micro_creditos_api.Models
{
    [Table("pagos")]
    public class PagosModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id_pago")]
        public int id_pago { get; set; }

        [Column("id_prestamo")]
        public int id_prestamo { get; set; }

        [Column("numero_pago")]
        public int numero_pago { get; set; }

        [Column("fecha_pago")]
        public DateTime fecha_pago { get; set; }

        [Column("monto")]
        public decimal monto { get; set; }
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
