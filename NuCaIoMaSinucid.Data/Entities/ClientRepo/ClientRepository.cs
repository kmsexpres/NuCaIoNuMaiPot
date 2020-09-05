using NuCaIoMaSinucid.Data.Entities.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NuCaIoMaSinucid.Data.Entities.ClientRepo
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly DataContext _context;

        public ClientRepository(DataContext context) : base(context)
        {
            this._context = context;
        }

        public IEnumerable<Book> CartiImprumutateDe(int ID)
        {
            return
                this._context.Clienti.Find(ID).CartiImprumutate;
        }

        public int CateCartiAreImprumutate(int ID)
        {
            return
                this._context.Clienti
                    .Find(ID)
                    .CartiImprumutate.Count();
        }

        public string DateContactPentru(int ID)
        {
            var gasit = this._context.Clienti.Find(ID);
            return
                $"{gasit.Telefon}, {gasit.Nume} {gasit.Prenume}, {gasit.Adresa}";
        }

        public bool AreCartiIntarziate(int ID)
        {
            return
                this._context.Clienti
                    .Find(ID)
                    .CartiImprumutate
                    .Where(carte => DateTime.Compare(carte.DataReturnare, DateTime.Now) > 0)
                    .Any();
        }
    }
}
