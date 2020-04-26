using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
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

        Task<DetailDTO> GetArticleByName(string articleOfDetail);
    }
}
