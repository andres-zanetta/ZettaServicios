using Zetta.BD.Data.Entity;
using Zetta.BD.Data;
using Microsoft.EntityFrameworkCore;


namespace Zetta.Server.Repositorio
{
    public class PresupuestoRepositorio: Repositorio<Presupuesto>, ITPresupuesto
    {
        private readonly Context context;

        public PresupuestoRepositorio(Context context) : base(context)
        {
            this.context = context;
        }
    }
}
