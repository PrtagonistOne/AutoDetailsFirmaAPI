using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFProvideService
    {
        long AddProvides(Provide provide);

        void UpdateProvides(Provide provide);

        void DeleteProvides(Provide provide);
        Provide GetProvides(long Id);
        IEnumerable<Provide> GetProvides();
    }
}
