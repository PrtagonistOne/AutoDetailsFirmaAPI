using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFShopRepository : IGenericRepository<Shop, int>
    {
        Task<IEnumerable<Shop>> GetAllShops();
        Task<Shop> GetAllShopsById(int Id);
        Task AddShops(Shop entity);
        Task UpdateShops(Shop entity);
        Task DeleteShops(Shop entity);
    }
}
