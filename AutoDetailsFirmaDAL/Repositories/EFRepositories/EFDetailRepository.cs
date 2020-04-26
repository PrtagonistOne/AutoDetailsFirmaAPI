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

        public EFDetailRepository(AutoDetailContext context) : base(context)
        {
        }

        public async Task <Detail> GetArticleByName(string articleOfDetail)
        {
            var details = await _context.Set<Detail>().ToListAsync<Detail>();

            return details.Where(details => details.ArticleOfDetail == articleOfDetail).FirstOrDefault();
            
        }
        
    }
}
