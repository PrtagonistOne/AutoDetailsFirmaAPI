using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFProviderRepository : GenericRepository<Provider, int>, IEFProviderRepository
    {
        public EFProviderRepository(AutoDetailContext context) : base(context)
        {
        }
        
    }
}
