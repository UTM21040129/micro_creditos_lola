using micro_creditos_api.Models;
using Microsoft.EntityFrameworkCore;
namespace micro_creditos_api.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options) { }

        public DbSet<ClientesModel> clientesModel { get; set; } 

        public DbSet<ContactosModel> contactosModel { get; set; }

        public DbSet<PrestamosModel> prestamosModel { get; set; }

        public DbSet<PagosModel> pagosModel { get; set; }
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
