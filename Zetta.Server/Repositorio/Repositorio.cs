using Microsoft.EntityFrameworkCore;
using Zetta.BD.Data;
using Zetta.BD.Data.Entity;

namespace Zetta.Server.Repositorio//comunico la BD
{
    public class Repositorio<Z> : IRepositorio<Z>
        where Z : class,IEntityBase

    {
       private readonly Context _context;
    }
}
