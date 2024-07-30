using Zetta.BD.Data.Entity;

namespace Zetta.Server.Repositorio
{
    public class ClientesRepositorio : IRepositorio<Presupuesto>
    {
        Task<Presupuesto> SelectByCod(string cod);
    }
}
