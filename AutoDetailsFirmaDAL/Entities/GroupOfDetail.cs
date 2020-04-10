using AutoDetailsFirmaDAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Entities
{
    public class GroupOfDetail : IEntity<int>
    {
        public int Id { get; set; }
        public string ArticleOfGroupOfDetail { get; set; }
        public double PriceOfGroupOfDetail { get; set; }
        public string NotesOfGroupOfDetail { get; set; }
        public DateTime DataOfGroupOfDetail { get; set; }
        public ICollection<Detail> Details { get; set; }
    }
}
