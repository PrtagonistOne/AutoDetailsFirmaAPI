using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaBLL.Validation;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using AutoMapper;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class EFShopService : IEFShopService
    {
        IEFUnitOfWork _eFUnitOfWork;
        private readonly IMapper _mapper;
        public EFShopService(IEFUnitOfWork eFUnitOfWork, IMapper mapper)
        {
            _eFUnitOfWork = eFUnitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ShopDTO>> GetAllShops()
        {
            var x = await _eFUnitOfWork.EFShopRepository.GetAll();
            List<ShopDTO> r = new List<ShopDTO>();
            foreach (var key in x)
                r.Add(_mapper.Map<Shop, ShopDTO>(key));
            return r;
        }
        public async Task<ShopDTO> GetShop(int id)
        {
            var x = await _eFUnitOfWork.EFShopRepository.Get(id);
            return _mapper.Map<Shop, ShopDTO>(x);
        }
        public async Task<string> AddShops(ShopDTO shop)
        {
            var x = _mapper.Map<ShopDTO, Shop>(shop);

            ShopValidator validator = new ShopValidator();

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
            else
            {
                await _eFUnitOfWork.EFShopRepository.Add(x);
                return "Магазин успішно добавлено!";
            }
            
        }
        public async Task UpdateShops(ShopDTO shop)
        {
            var x = _mapper.Map<ShopDTO, Shop>(shop);
            await _eFUnitOfWork.EFShopRepository.Update(x);
        }
        public async Task DeleteShops(int id)
        {
            await _eFUnitOfWork.EFShopRepository.Delete(id);
        }
    }
}
