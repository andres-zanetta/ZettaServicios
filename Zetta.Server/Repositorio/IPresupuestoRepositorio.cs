using Zetta.BD.Data.Entity;

namespace Zetta.Server.Repositorio
{
    public interface IPresupuestoRepositorio : IRepositorio<Presupuesto>
    {
        Task<Presupuesto> SelectByCod(string cod);
    }
}
