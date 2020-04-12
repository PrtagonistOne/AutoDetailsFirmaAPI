using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFProvideService
    {
        Task AddProvides(ProvideDTO provide);

        Task UpdateProvides(ProvideDTO provide);

        Task DeleteProvides(int id);
        Task <ProvideDTO> GetByIdProvides(int Id);
        Task <IEnumerable<ProvideDTO>> GetProvides();
    }
}
