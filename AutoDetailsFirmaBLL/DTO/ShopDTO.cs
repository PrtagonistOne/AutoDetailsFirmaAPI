using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaBLL.DTO
{
    public class ShopDTO
    {
        public int Id { get; set; }
        public int ProvideId { get; set; }
        public string ArticleOfShop { get; set; }
        public double PriceOfShop { get; set; }
        public string NameOfShop { get; set; }
    }
}
