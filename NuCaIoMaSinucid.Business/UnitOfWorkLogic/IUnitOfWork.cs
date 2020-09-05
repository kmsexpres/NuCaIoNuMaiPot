using NuCaIoMaSinucid.Data.Entities.BookRepo;
using NuCaIoMaSinucid.Data.Entities.ClientRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCaIoMaSinucid.Business.UnitOfWorkLogic
{
    public interface IUnitOfWork : IDisposable
    {
        public IBookRepository Books { get; set; }
        public IClientRepository Clients { get; set; }

        int Complete();
    }
}
