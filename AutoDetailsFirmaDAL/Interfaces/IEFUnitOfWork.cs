using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDetailsFirmaDAL.Interfaces
{
    public interface IEFUnitOfWork
    {
        IEFUnitOfWork EFDetailRepository { get; }
        void Complete();
    }
}
