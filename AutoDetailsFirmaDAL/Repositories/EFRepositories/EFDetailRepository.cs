using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFDetailRepository : GenericRepository<Detail, int>, IEFDetailRepository
    {

        public EFDetailRepository(AutoDetailContext context) : base(context)
        {
        }

        public async Task <IEnumerable<Detail>> GetArticleByName(string articleOfDetail)                             
        {
            if(_context != null)
            {

                var details = await GetAll();
                details = details.Where(details => details.ArticleOfDetail == articleOfDetail);               

                return details;
            }

            return null;

        }
        
    }
}
