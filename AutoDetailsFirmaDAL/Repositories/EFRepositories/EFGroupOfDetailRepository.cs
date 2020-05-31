using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using AutoDetailsFirmaDAL.Paging;
using System;
using System.Text;
using System.Reflection;
using AutoDetailsFirmaDAL.Paging.Interfaces;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFGroupOfDetailRepository : GenericRepository<GroupOfDetail, int>, IEFGroupOfDetailRepository
    {
        private ISortHelper<GroupOfDetail> _sortHelper;
        public EFGroupOfDetailRepository(AutoDetailContext context, ISortHelper<GroupOfDetail> sortHelper) : base(context)
        {
            _sortHelper = sortHelper;
        }

        private void SearchByName(ref IQueryable<GroupOfDetail> groupOfDetails, string state)
        {
            if (!groupOfDetails.Any() || string.IsNullOrWhiteSpace(state))
                return;

            groupOfDetails = groupOfDetails.Where(o => o.NotesOfGroupOfDetail.ToLower().Contains(state.Trim().ToLower()));
        }
        
        public async Task<PagedList<GroupOfDetail>> GetPagedGroupOfDetails(GroupOfDetailParameters parameters)
        {
            var groupOfDetails = FindByCondition(o => o.PriceOfGroupOfDetail >= parameters.MinPrice && o.PriceOfGroupOfDetail <= parameters.MaxPrice); // filtering

            SearchByName(ref groupOfDetails, parameters.State); // searching

            groupOfDetails = _sortHelper.ApplySort(groupOfDetails, parameters); // sorting

            return await PagedList<GroupOfDetail>.ToPagedList(groupOfDetails, parameters.PageNumber,parameters.PageSize); // paging
        }

       

    }
}
