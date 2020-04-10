using AutoDetailsFirmaDAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Entities
{
    public class Provider : IEntity<int>
    {
        public int Id { get; set; }
        public string ProviderName { get; set; }
        public string ProviderAdress { get; set; }
        public string ProviderPhone { get; set; }
        public ICollection<Provide> Provides { get; set; }
    }
}
