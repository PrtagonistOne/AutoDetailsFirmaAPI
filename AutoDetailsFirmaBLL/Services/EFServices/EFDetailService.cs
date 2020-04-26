using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class EFDetailService : IEFDetailService
    {
        IEFUnitOfWork _eFUnitOfWork;
        private readonly IMapper _mapper;
        public EFDetailService(IEFUnitOfWork eFUnitOfWork, IMapper mapper)
        {
            _eFUnitOfWork = eFUnitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DetailDTO>> GetAllDetails()
        {
            var x = await _eFUnitOfWork.EFDetailRepository.GetAll();
            List<DetailDTO> r = new List<DetailDTO>();
            foreach (var key in x)
                r.Add(_mapper.Map<Detail, DetailDTO>(key));
            return r;
        }
        public async Task<DetailDTO> GetDetailsById(int id)
        {
            var x = await _eFUnitOfWork.EFDetailRepository.Get(id);
            return _mapper.Map<Detail, DetailDTO>(x);
        }
        public async Task AddDetails(DetailDTO detail)
        {
            var x = _mapper.Map<DetailDTO, Detail>(detail);
            await _eFUnitOfWork.EFDetailRepository.Add(x);

        }
        public async Task UpdateDetails(DetailDTO detail)
        {
            var x = _mapper.Map<DetailDTO, Detail>(detail);
            await _eFUnitOfWork.EFDetailRepository.Update(x);
        }
        public async Task DeleteDetails(int id)
        {
            await _eFUnitOfWork.EFDetailRepository.Delete(id);
        }
        public async Task<DetailDTO> GetArticleByName(string articleOfDetail)
        {
            var x = await _eFUnitOfWork.EFDetailRepository.GetArticleByName(articleOfDetail);
            DetailDTO res = _mapper.Map<Detail, DetailDTO>(x);
            return res;
        }

    }
}
