using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.InterfaceRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IBokningRepository Bokning { get; }
        IBokRepository Bok { get;  }
        IExpiditRepository Expidit { get; }
        IFakturaRepository Faktura { get; }
        IMedlemRepository Medlem { get; }   

        int Complete();
    }
}
