using Microsoft.EntityFrameworkCore;
using Zetta.BD.Data;

namespace Zetta.Server.Repositorio//comunico la BD
{
    public class Repositorio<Z> : IRepositorio<Z>
                where Z : class, IEntityBase

    {
        private readonly Context _context;

        public Repositorio(Context _context)
        {
            this._context = _context;

        }

        public async Task<bool> Existe(int id)
        {
            var existe = await _context.Set<Z>().AnyAsync(x=>x.Id ==id);
            return existe;

        }
    }
}
