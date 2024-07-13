using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Zetta.BD.Data.Entity
{
    public class Transacciones

    {
        public int TransaccionId { get; set; }
        public DateTime Fecha { get; set; }
        public int Tipo { get; set; }
        public decimal Monto { get; set; }
        public int PresupuestoId { get; set; }
        public Presupuesto Presupuesto { get; set; }
    }

   // public enum TipoTransaccion
 //   {
    //    Ganancia,
    //    Gasto
  //  }
}





    

