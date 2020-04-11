using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFShopService
    {
        long AddShops(Shop shop);

        void UpdateShops(Shop shop);

        void DeleteShops(Shop shop);
        Shop GetShop(long Id);
        IEnumerable<Shop> GetAllShops();
    }
}
