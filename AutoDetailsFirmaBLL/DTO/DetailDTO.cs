using System;

namespace AutoDetailsFirmaBLL.DTO
{
    public class DetailDTO
    {
        public int Id { get; set; }
        public int GroupOfDetailId { get; set; }
        public string NameOfDetail { get; set; }
        public string ArticleOfDetail { get; set; }
        public DateTime? DataOfDetail { get; set; }
    }
}
