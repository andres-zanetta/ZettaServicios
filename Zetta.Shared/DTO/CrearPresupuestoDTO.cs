using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Zetta.Shared.DTO
{
    public class CrearPresupuestoDTO
    {
        public string PresupuestoID { get; set; }

        public string Insumos { get; set; }
    }
}
