using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaBLL.DTO
{
    public class GroupOfDetailDTO
    {
        public int Id { get; set; }
        public string ArticleOfGroupOfDetail { get; set; }
        public double PriceOfGroupOfDetail { get; set; }
        public string NotesOfGroupOfDetail { get; set; }
        public DateTime? DataOfGroupOfDetail { get; set; }
    
}
