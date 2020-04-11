using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFGroupOfDetailService
    {
        long AddGroupOfDetails(GroupOfDetail groupOfDetail);

        void UpdateGroupOfDetails(GroupOfDetail groupOfDetail);

        void DeleteGroupOfDetails(GroupOfDetail groupOfDetail);
        GroupOfDetail GetGroupOfDetailsById(long Id);
        IEnumerable<GroupOfDetail> GetAllGroupOfDetails();
    }
}
