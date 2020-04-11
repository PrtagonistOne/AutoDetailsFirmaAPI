using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFDetailService
    {
        Task AddDetails(Detail detail);

        Task UpdateDetails(Detail detail);

        Task DeleteDetails(Detail detail);
        Task <Detail> GetDetailsById(long Id);
        Task <IEnumerable<Detail>> GetAllDetails();
    }
}
