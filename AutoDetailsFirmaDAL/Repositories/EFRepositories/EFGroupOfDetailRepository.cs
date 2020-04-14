using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFGroupOfDetailRepository : GenericRepository<GroupOfDetail, int>, IEFGroupOfDetailRepository
    {
        public EFGroupOfDetailRepository(AutoDetailContext context) : base(context)
        {
        }
    }
}
