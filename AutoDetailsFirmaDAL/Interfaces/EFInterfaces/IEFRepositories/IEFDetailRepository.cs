using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFDetailRepository : IGenericRepository<Detail, int>
    {
        IEnumerable<Detail> GetAllDetails();
        Detail GetAllDetailById(int Id);
        long AddDetail(Detail entity);
        void UpdateDetail(Detail entity);
        void DeleteDetail(Detail entity);
    }
}
