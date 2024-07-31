using Zetta.BD.Data;
using Zetta.BD.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Zetta.Server.Repositorio
{
    public class ClienteRepositorio : Repositorio<Presupuesto>, ITPresupuestoRepositorio
    {
        private readonly Context _context;

        public ClienteRepositorio(Context _context) : base(_context)
        {
            this._context = _context;
        }
        public async Task<Presupuesto> SelectByCod(string cod);
        {}
            
    }
}
   





