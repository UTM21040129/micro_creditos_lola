using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace micro_creditos_api.Models
{
    [Table("prestamos")]
    public class PrestamosModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id_prestamo")]
        public int id_prestamo { get; set; }

        [Column("id_cliente")]
        public int id_cliente { get; set; }

        [Column("fecha_prestamo")]
        public DateTime fecha_prestamo { get; set; }

        [Column("cantidad_prestada")]
        public decimal cantidad_prestada { get; set; }

        [Column("meses_prestamo")]
        public int meses_prestamo { get; set; }

        [Column("interes")]
        public Int16 interes { get; set; }

        [Column("estado")]
        public bool estado { get; set; }

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
