using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System;
using Microsoft.AspNetCore.Identity;
using AutoDetailsFirmaDAL.Entities;

namespace AutoDetailsFirmaDAL.UnitOfWork
{
    public class EFUnitOfWork : IEFUnitOfWork
    {

        private readonly IEFDetailRepository _eFDetailRepository;
        private readonly IEFGroupOfDetailRepository _eFGroupOfDetail;
        private readonly IEFProvideRepository _eFProvideRepository;
        private readonly IEFProviderRepository _eFProviderRepository;
        private readonly IEFShopRepository _eFShopRepository;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public readonly RoleManager<Role> _roleManager;
        public EFUnitOfWork(IEFDetailRepository eFDetailRepository,
           IEFGroupOfDetailRepository eFGroupOfDetail,
           IEFProvideRepository eFProvideRepository,
           IEFProviderRepository eFProviderRepository,
           IEFShopRepository eFShopRepository,
           UserManager<User> userManager,
           SignInManager<User> singInManeger,
           RoleManager<Role> roleManager)
           
        {
            _eFDetailRepository = eFDetailRepository;
            _eFGroupOfDetail = eFGroupOfDetail;
            _eFProvideRepository = eFProvideRepository;
            _eFProviderRepository = eFProviderRepository;
            _eFShopRepository = eFShopRepository;
            _userManager = userManager;
            _signInManager = singInManeger;
            _roleManager = roleManager;
        }
        public IEFDetailRepository EFDetailRepository
        {
            get
            {
                return _eFDetailRepository;
            }
        }
        public IEFGroupOfDetailRepository EFGroupOfDetailRepository
        {
            get
            {
                return _eFGroupOfDetail;
            }
        }
        public IEFProvideRepository EFProvideRepository
        {
            get
            {
                return _eFProvideRepository;
            }
        }
        public IEFProviderRepository EFProviderRepository
        {
            get
            {
                return _eFProviderRepository;
            }
        }
        public IEFShopRepository EFShopRepository
        {
            get
            {
                return _eFShopRepository;
            }
        }
        public UserManager<User> UserManager
        {
            get
            {
                return _userManager;
            }
        }
        public RoleManager<Role> RoleManager
        {
            get { return _roleManager; }
        }
        public SignInManager<User> SignInManager
        {
            get { return _signInManager; }
        }



        public void Complete()
        {
            throw new NotImplementedException();
        }

    }
}
