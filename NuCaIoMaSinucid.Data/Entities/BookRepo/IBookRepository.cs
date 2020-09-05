using NuCaIoMaSinucid.Data.Entities.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCaIoMaSinucid.Data.Entities.BookRepo
{
    public interface IBookRepository : IRepository<Book>
    {
        public IEnumerable<Book> CartiIntarziate();
        public IEnumerable<Book> CartiImprumutate();
        public bool EsteImprumutataCartea(int ID);
    }
}
