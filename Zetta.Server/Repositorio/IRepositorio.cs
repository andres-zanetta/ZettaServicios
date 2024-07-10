using Zetta.BD.Data;

namespace Zetta.Server.Repositorio
{
    public interface IRepositorio <Z> where Z : class, IEntityBase
    {
        Task<bool> Delete(int id);
        Task<bool> Existe(int id);
        Task<int> Insert(Z entidad);
        Task<List<Z>> Select();
        Task<Z> SelectById(int id);
        Task<bool> Update(int id, Z entity);

    }
    
    
}
