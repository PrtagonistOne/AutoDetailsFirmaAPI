using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFDetailRepository : GenericRepository<Detail, int>, IEFDetailRepository
    {
        private readonly AutoDetailContext _context;

        public EFDetailRepository(AutoDetailContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Detail>> GetCarByName(string car)
        {
            var details =  _context.Details.Where(p => p.ArticleOfDetail == car);

            return await details.ToListAsync();

        }
        
    }
}
