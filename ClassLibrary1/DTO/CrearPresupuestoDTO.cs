using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zetta.Shared.DTO
{
    public class CrearPresupuestoDTO
    {
        [Required(ErrorMessage = "El nombre del presupuesto es obligatorio.")]
        [MaxLength(100, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Nombre {  get; set; }

        public int PresupuestoID { get; set; }
    }
}
