using NuCaIoMaSinucid.Data;
using NuCaIoMaSinucid.Data.Entities.BookRepo;
using NuCaIoMaSinucid.Data.Entities.ClientRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCaIoMaSinucid.Business.UnitOfWorkLogic
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            this._context = context;
            this.Books = new BookRepository(this._context);
            this.Clients = new ClientRepository(this._context);
        }

        public IBookRepository Books { get; set; }
        public IClientRepository Clients { get; set; }

        public int Complete()
        {
            return this._context.SaveChanges();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
