using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Interfaces.EntityInterfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
