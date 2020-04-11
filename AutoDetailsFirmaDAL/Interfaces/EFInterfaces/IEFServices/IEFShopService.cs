using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFShopService
    {
        Task AddShops(Shop shop);

        Task UpdateShops(Shop shop);

        Task DeleteShops(Shop shop);
        Task <Shop> GetShop(int Id);
        Task <IEnumerable<Shop>> GetAllShops();
    }
}
