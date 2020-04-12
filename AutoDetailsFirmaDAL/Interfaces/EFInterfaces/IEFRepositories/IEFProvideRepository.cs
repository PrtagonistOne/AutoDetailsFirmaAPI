using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFProvideRepository : IGenericRepository<Provide, int>
    {
        Task<IEnumerable<Provide>> GetAllProvides();
        Task<Provide> GetAllProvidesById(int Id);
        Task AddProvides(Provide entity);
        Task UpdateProvides(Provide entity);
        Task DeleteProvides(int id);
    }
}
