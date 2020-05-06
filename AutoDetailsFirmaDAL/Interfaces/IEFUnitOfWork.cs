using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Interfaces
{
    public interface IEFUnitOfWork
    {
        IEFDetailRepository EFDetailRepository { get; }
        IEFGroupOfDetailRepository EFGroupOfDetailRepository { get; }
        IEFProvideRepository EFProvideRepository { get; }
        IEFProviderRepository EFProviderRepository { get; }
        IEFShopRepository EFShopRepository { get; }
        UserManager<User> UserManager { get; }
        RoleManager<Role> RoleManager { get; }
        SignInManager<User> SignInManager { get; }
        void Complete();
    }
}
