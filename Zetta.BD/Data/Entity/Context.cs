using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zetta.BD.Data.Entity;

namespace Zetta.BD.Data.Entity
{
    public class Context : DbContext
    {
        public DbSet<Presupuesto> Presupuestos { get; set; }

    }
}
