using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFShopRepository : IGenericRepository<Shop, int>
    {
        IEnumerable<Detail> GetAllShops();
        Detail GetAllShopsById(int Id);
        long AddShops(Detail entity);
        void UpdateShops(Detail entity);
        void DeleteShops(Detail entity);
    }
}
