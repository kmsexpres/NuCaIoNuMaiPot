using NuCaIoMaSinucid.Data.Entities.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCaIoMaSinucid.Data.Entities.ClientRepo
{
    public interface IClientRepository : IRepository<Client>
    {
        public IEnumerable<Book> CartiImprumutateDe(int ID);
        public string DateContactPentru(int ID);
        public int CateCartiAreImprumutate(int ID);
        public bool AreCartiIntarziate(int ID);
    }
}
