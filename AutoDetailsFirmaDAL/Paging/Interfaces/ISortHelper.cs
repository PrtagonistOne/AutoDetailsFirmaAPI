using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoDetailsFirmaDAL.Paging.Interfaces
{
    public interface ISortHelper<T>
    {
        IQueryable<T> ApplySort(IQueryable<T> entities, QueryStringParameters orderByQueryString);
    }
}
