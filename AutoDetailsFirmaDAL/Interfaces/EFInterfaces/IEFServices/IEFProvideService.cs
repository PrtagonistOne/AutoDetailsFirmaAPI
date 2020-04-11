using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFProvideService
    {
        Task AddProvides(Provide provide);

        Task UpdateProvides(Provide provide);

        Task DeleteProvides(Provide provide);
        Task <Provide> GetByIdProvides(int Id);
        Task <IEnumerable<Provide>> GetProvides();
    }
}
