using AutoDetailsFirmaBLL.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFDetailService
    {
        Task AddDetails(DetailDTO detail);

        Task UpdateDetails(DetailDTO detail);

        Task DeleteDetails(int id);
        Task <DetailDTO> GetDetailsById(int Id);
        Task <IEnumerable<DetailDTO>> GetAllDetails();

        Task<IEnumerable<DetailDTO>> GetArticleByName(string articleOfDetail);
    }
}
