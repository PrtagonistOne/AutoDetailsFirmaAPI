﻿using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices
{
    public interface IEFProviderService
    {
        Task AddProviders(ProviderDTO provider);

        Task UpdateProviders(ProviderDTO provider);

        Task DeleteProviders(int id);
        Task <ProviderDTO> GetProviders(int Id);
        Task <IEnumerable<ProviderDTO>> GetProviders();
    }
}
