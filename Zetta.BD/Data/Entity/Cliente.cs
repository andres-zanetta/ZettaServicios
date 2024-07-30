using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Zetta.BD.Data.Entity
{
    [Index(nameof(TDocumentoId), nameof(NumDoc), Name = "Persona_UQ", IsUnique = true)]//esto me genera la clave unica compuesta
    [Index(nameof(Apellido), nameof(Nombre), Name = "Persona_Apellido_Nombre", IsUnique = false)]
    public class Cliente : EntityBase
    {
        public string Nombre {get; set;}

        public string Direccion { get; set;}

    }
}
