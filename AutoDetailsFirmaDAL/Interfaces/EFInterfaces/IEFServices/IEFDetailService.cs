using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFDetailService
    {
        long AddDetails(Detail detail);

        void UpdateDetails(Detail detail);

        void DeleteDetails(Detail detail);
        Detail GetDetailsById(long Id);
        IEnumerable<Detail> GetAllDetails();
    }
}
