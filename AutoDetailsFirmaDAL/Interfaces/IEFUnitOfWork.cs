using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Interfaces
{
    public interface IEFUnitOfWork
    {
        IEFUnitOfWork EFDetailRepository { get; }
        IEFGroupOfDetailRepository EFGroupOfDetail { get; }
        IEFProvideRepository EFProvideRepository { get; }
        IEFProviderRepository EFProviderRepository { get; }
        IEFShopRepository EFShopRepository { get; }
        void Complete();
    }
}
