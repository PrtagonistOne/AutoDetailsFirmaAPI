using AutoDetailsFirmaDAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Entities
{
    public class Provide : IEntity<int>
    {
        public int Id { get; set; }
        public int IdOFProvider { get; set; }
        public int IdOfDetail { get; set; }
        public int PriceOfProvide { get; set; }
        public DateTime DataOfProvide { get; set; }
        public string ArticleOfProvide { get; set; }
        public Detail Detail { get; set; }
        public Provider Provider { get; set; }
        public ICollection<Shop> Shops { get; set; }
    }
}
