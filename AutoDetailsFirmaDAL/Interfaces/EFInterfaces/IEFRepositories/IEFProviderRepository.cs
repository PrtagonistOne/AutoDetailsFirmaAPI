using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFProviderRepository : IGenericRepository<Provider, int>
    {
        IEnumerable<Detail> GetAllProviders();
        Detail GetAllProvidersById(int Id);
        long AddProviders(Detail entity);
        void UpdateProviders(Detail entity);
        void DeleteProviders(Detail entity);
    }
}
