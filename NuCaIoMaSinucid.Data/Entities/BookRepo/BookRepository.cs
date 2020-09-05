using NuCaIoMaSinucid.Data.Entities.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NuCaIoMaSinucid.Data.Entities.BookRepo
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context) : base(context)
        {
            this._context = context;
        }

        public IEnumerable<Book> CartiIntarziate()
        {
            return
                this._context.Carti
                    .Where(c => DateTime.Compare(c.DataReturnare, DateTime.Now) > 0)
                    .ToList();
        }

        public IEnumerable<Book> CartiImprumutate()
        {
            return
                this._context.Carti
                    .Where(c => c.EsteImprumutata == true)
                    .ToList();
        }

        public bool EsteImprumutataCartea(int ID)
        {
            return
                this._context.Carti
                    .Find(ID).EsteImprumutata;
        }

        
    }
}
