using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFShopService
    {
        Task AddShops(ShopDTO shop);

        Task UpdateShops(ShopDTO shop);

        Task DeleteShops(int id);
        Task <ShopDTO> GetShop(int Id);
        Task <IEnumerable<ShopDTO>> GetAllShops();
    }
}
