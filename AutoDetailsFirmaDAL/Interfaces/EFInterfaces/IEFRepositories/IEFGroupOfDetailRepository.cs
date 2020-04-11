using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFGroupOfDetailRepository  : IGenericRepository<GroupOfDetail, int>
    {
        IEnumerable<GroupOfDetail> GetAllGroupOfDetails();
        GroupOfDetail GetAllGroupOfDetailsById(int Id);
        long AddGroupOfDetails(GroupOfDetail entity);
        void UpdateGroupOfDetails(GroupOfDetail entity);
        void DeleteGroupOfDetails(GroupOfDetail entity);
    }
}
