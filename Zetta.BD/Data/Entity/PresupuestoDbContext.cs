using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zetta.BD.Data.Entity
{
    class PresupuestoDbContext:DbContext
    {
        public PresupuestoDbContext(DbContextOptions<PresupuestoDbContext> options) : base(options)
        {
        }

        // DbSet para cada entidad
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
    }
}
    

