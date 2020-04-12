using System;

namespace AutoDetailsFirmaBLL.DTO
{
    public class ProvideDTO
    {
        public int Id { get; set; }
        public int IdOFProvider { get; set; }
        public int IdOfDetail { get; set; }
        public int PriceOfProvide { get; set; }
        public DateTime DataOfProvide { get; set; }
        public string ArticleOfProvide { get; set; }
    }
}
