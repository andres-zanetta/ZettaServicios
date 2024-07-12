using Zetta.BD.Data.Entity;

namespace Zetta.Server.Repositorio
{
    public interface ITPresupuestoRepositorio : IRepositorio<Presupuesto>
    {
        Task<Presupuesto> SelectByCod(string cod);
    }
}
