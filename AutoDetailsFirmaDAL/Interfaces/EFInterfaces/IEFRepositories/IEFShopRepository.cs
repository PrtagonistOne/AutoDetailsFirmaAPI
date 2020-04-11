using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFShopRepository : IGenericRepository<Shop, int>
    {
        Task<IEnumerable<Detail>> GetAllShops();
        Task<Detail> GetAllShopsById(int Id);
        Task AddShops(Detail entity);
        Task UpdateShops(Detail entity);
        Task DeleteShops(Detail entity);
    }
}
