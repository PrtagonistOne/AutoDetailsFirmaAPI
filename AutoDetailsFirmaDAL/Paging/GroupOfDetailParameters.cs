using AutoDetailsFirmaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoDetailsFirmaDAL.Paging
{
    public class GroupOfDetailParameters : QueryStringParameters
    {
        public double MinPrice { get; set; } = 0;
        public double MaxPrice { get; set; } = double.MaxValue;
        public bool ValidPriceRange => MaxPrice >= MinPrice && MinPrice >= 0;

        public string State { get; set; }
        public GroupOfDetailParameters()
        {
            OrderBy = "notesOfGroupOfDetail";
        }
       
    }
}
