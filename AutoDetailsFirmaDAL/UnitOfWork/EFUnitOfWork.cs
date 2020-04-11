using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.UnitOfWork
{
    public class EFUnitOfWork : IEFUnitOfWork
    {
        private readonly IEFDetailRepository _eFDetailRepository;
        private readonly IEFGroupOfDetailRepository _eFGroupOfDetail;
        private readonly IEFProvideRepository _eFProvideRepository;
        private readonly IEFProviderRepository _eFProviderRepository;
        private readonly IEFShopRepository _eFShopRepository;

        public EFUnitOfWork(IEFDetailRepository eFDetailRepository,
           IEFGroupOfDetailRepository eFGroupOfDetail,
           IEFProvideRepository eFProvideRepository,
           IEFProviderRepository eFProviderRepository,
           IEFShopRepository eFShopRepository)
        {
            _eFDetailRepository = eFDetailRepository;
            _eFGroupOfDetail = eFGroupOfDetail;
            _eFProvideRepository = eFProvideRepository;
            _eFProviderRepository = eFProviderRepository;
            _eFShopRepository = eFShopRepository;
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

        public void Complete()
        {
            throw new NotImplementedException();
        }

    }
}
