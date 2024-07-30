using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zetta.BD.Data.Entity;


namespace Zetta.BD.Data
{
    public class Context : DbContext
    {
        public DbSet<Presupuesto> Presupuestos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //defino una variable, que va a ser una lista de todas las entidades que tengan FK y se borrren en cascada
            var cascadeFKs = modelBuilder.Model.G­etEntityTypes()
                                          .SelectMany(a => a.GetForeignKeys())//seleccione alguna CF
                                          .Where(fk => !fk.IsOwnership
                                                       && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;//restringe todas las claves foraneas para evitar el borrado de las mismas cuando borre en cascada//
            }

            base.OnModelCreating(modelBuilder);//esta linea ejecuta toda la creacion de toda la bd segun la clase de la cual hereda "db context" 
        }

    }
}
