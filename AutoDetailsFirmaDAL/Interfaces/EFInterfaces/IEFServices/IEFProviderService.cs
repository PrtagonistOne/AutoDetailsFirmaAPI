using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFProviderService
    {
        Task AddProviders(Provider provider);

        Task UpdateProviders(Provider provider);

        Task DeleteProviders(Provider provider);
        Task <Provider> GetProviders(long Id);
        Task <IEnumerable<Provider>> GetProviders();
    }
}
