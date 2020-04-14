using AutoDetailsFirmaDAL.Interfaces.EntityInterfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces
{
    public interface IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        Task <IEnumerable<TEntity>> GetAll();

        Task <TEntity> Get(TId Id);

        Task Add(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(TId id);
    }
}
