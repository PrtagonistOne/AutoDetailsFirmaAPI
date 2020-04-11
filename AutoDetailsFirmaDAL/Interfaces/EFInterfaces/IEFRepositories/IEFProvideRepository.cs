using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFProvideRepository : IGenericRepository<Provide, int>
    {
        IEnumerable<Provide> GetAllProvides();
        Provide GetAllProvidesById(int Id);
        long AddProvides(Provide entity);
        void UpdateProvides(Provide entity);
        void DeleteProvides(Provide entity);
    }
}
