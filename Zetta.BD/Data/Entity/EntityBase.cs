﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zetta.BD.Data
{
    public class EntityBase: IEntityBase
    {
        public int Id { get; set; }

        public bool Activo { get; set; }

    }
}
