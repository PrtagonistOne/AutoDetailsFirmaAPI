using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFGroupOfDetailService
    {
        Task AddGroupOfDetails(GroupOfDetailDTO groupOfDetail);

        Task UpdateGroupOfDetails(GroupOfDetailDTO groupOfDetail);

        Task DeleteGroupOfDetails(int id);
        Task <GroupOfDetailDTO> GetGroupOfDetailsById(int Id);
        Task <IEnumerable<GroupOfDetailDTO>> GetAllGroupOfDetails();
    }
}
