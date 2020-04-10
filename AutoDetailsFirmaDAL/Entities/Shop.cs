using AutoDetailsFirmaDAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Entities
{
    public class Shop : IEntity<int>
    {
        public int Id { get; set; }
        public int ProvideId { get; set; }

        public string ArticleOfShop { get; set; }
        public double PriceOfShop { get; set; }
        public string NameOfShop { get; set; }
        public Provide Provide { get; set; }
    }
}
