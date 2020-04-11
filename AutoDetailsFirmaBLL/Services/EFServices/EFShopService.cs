using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class EFShopService : IEFShopService
    {
        IEFUnitOfWork _eFUnitOfWork;
        public EFShopService(IEFUnitOfWork eFUnitOfWork)
        {
            _eFUnitOfWork = eFUnitOfWork;
        }
        public async Task<IEnumerable<Shop>> GetAllShops()
        {
            return await _eFUnitOfWork.EFShopRepository.GetAllShops();
        }
        public async Task<Shop> GetShop(int id)
        {
            return await _eFUnitOfWork.EFShopRepository.GetAllShopsById(id);
        }
        public async Task AddShops(Shop shop)
        {
            await _eFUnitOfWork.EFShopRepository.AddShops(shop);
        }
        public async Task UpdateShops(Shop shop)
        {
            await _eFUnitOfWork.EFShopRepository.UpdateShops(shop);
        }
        public async Task DeleteShops(Shop shop)
        {
            await _eFUnitOfWork.EFShopRepository.DeleteShops(shop);
        }
    }
}
