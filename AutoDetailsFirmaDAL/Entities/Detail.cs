using AutoDetailsFirmaDAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Entities
{
    public class Detail : IEntity<int>
    {
        public int Id { get; set; }
        public int GroupOfDetailId { get; set; }
        public string NameOfDetail { get; set; }
        public string ArticleOfDetail { get; set; }
        public DateTime DataOfDetail { get; set; }
        public GroupOfDetail GroupOfDetail { get; set; }
        public ICollection<Provide> Provides { get; set; }

    }
}
