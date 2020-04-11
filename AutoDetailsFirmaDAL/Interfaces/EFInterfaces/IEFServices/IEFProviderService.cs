using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFProviderService
    {
        long AddProviders(Provider provider);

        void UpdateProviders(Provider provider);

        void DeleteProviders(Provider provider);
        Provider GetProviders(long Id);
        IEnumerable<Provider> GetProviders();
    }
}
