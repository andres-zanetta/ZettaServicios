using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Zetta.BD.Data.Entity.Acciones
{
    [Index(nameof())]
    public class Presupuesto : EntityBase
    {
        bool Rechazo { get; set; }


    }
}
