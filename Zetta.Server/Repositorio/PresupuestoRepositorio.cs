﻿using Zetta.BD.Data.Entity;
using Zetta.BD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


namespace Zetta.Server.Repositorio
{
    public class PresupuestoRepositorio: Repositorio<Presupuesto>, IPresupuestoRepositorio
    {
        private readonly Context context;

        public PresupuestoRepositorio(Context context) : base(context)
        {
            this.context = context;
        }

        public async Task<Presupuesto> SelectByCod(string codigo)
        {
            Presupuesto? z = await context.Presupuestos
                            .FirstOrDefaultAsync(x => x.Codigo == codigo);
            return z;
        }
    }
}
