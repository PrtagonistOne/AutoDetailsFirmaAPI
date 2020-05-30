using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Paging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFDetailService
    {
        Task<string> AddDetails(DetailDTO detail);

        Task UpdateDetails(DetailDTO detail);

        Task DeleteDetails(int id);
        Task <DetailDTO> GetDetailsById(int Id);
        Task <IEnumerable<DetailDTO>> GetAllDetails();
        Task<IEnumerable<DetailDTO>> GetPagedDetails(DetailParameters ownerParameters);


    }
}
