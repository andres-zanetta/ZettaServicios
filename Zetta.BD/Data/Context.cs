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

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Insumo> Insumos { get; set; }

        public DbSet<Transaccion> Transacciones { get;set; }  


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            var cascadeFKs = modelBuilder.Model.G­etEntityTypes()
                                          .SelectMany(a => a.GetForeignKeys())
                                          .Where(fk => !fk.IsOwnership
                                                       && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            base.OnModelCreating(modelBuilder);
        }

    }
}
