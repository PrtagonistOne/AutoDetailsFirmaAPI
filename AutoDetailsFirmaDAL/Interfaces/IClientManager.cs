using AutoDetailsFirmaDAL.Entities;
using System;

namespace AutoDetailsFirmaDAL.Interfaces
{
   
        public interface IClientManager : IDisposable
        {
            void Create(ClientProfile item);
        }
    
}
