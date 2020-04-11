using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFGroupOfDetailService
    {
        Task AddGroupOfDetails(GroupOfDetail groupOfDetail);

        Task UpdateGroupOfDetails(GroupOfDetail groupOfDetail);

        Task DeleteGroupOfDetails(GroupOfDetail groupOfDetail);
        Task <GroupOfDetail> GetGroupOfDetailsById(int Id);
        Task <IEnumerable<GroupOfDetail>> GetAllGroupOfDetails();
    }
}
