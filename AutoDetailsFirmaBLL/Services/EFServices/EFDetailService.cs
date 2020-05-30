using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoDetailsFirmaBLL.Validation;
using FluentValidation.Results;
using System;

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
            //List<DetailDTO> r = new List<DetailDTO>();
            //foreach (var key in x)
            //    r.Add(_mapper.Map<Detail, DetailDTO>(key));
            List<DetailDTO> r = _mapper.Map<List<DetailDTO>>(x);
            return r;
        }
        public async Task<DetailDTO> GetDetailsById(int id)
        {
            var x = await _eFUnitOfWork.EFDetailRepository.Get(id);
            return _mapper.Map<Detail, DetailDTO>(x);
        }
        public async Task<string> AddDetails(DetailDTO detail)
        {

            var x = _mapper.Map<DetailDTO, Detail>(detail);

            DetailValidator validator = new DetailValidator();

            ValidationResult results = validator.Validate(x);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    string error = ("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                    return error;
                }
                return "Error";
            }
            else { 
            await _eFUnitOfWork.EFDetailRepository.Add(x);
                return "Деталь успішно добавлено!";
            }

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
        public async Task<IEnumerable<DetailDTO>> GetArticleByName(string articleOfDetail)
        {
            var x = await _eFUnitOfWork.EFDetailRepository.GetArticleByName(articleOfDetail);
            List<DetailDTO> res = _mapper.Map<List<DetailDTO>>(x);
            return res;
        }

    }
}
