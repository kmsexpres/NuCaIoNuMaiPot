using NuCaIoMaSinucid.Business.UnitOfWorkLogic;
using NuCaIoMaSinucid.Data;
using NuCaIoMaSinucid.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NuCaIoMaSinucid.UI
{
    public partial class EcranListaClienti : Form
    {
        private readonly UnitOfWork unit;

        private EcranListaClienti()
        {
            InitializeComponent();
        }

        public EcranListaClienti(UnitOfWork unit) : this()
        {
            this.unit = unit;
        }

        public EcranListaClienti(UnitOfWork unit, bool pornesteInserare) : this(unit)
        {
            // in caz ca am dat click pe "client nou" din meniul principal
            // pornesc ecranu de clienti si apoi dau click pe inserare client nou
            // putina mizerie da merge i guess
            butClientNou_Click(this, null);
        }

        private void EcranListaClienti_Load(object sender, EventArgs e)
        {
            // incarc lista de clienti cu tot ce am in baza de date

            this.cutieListaClienti.Items.Clear();

            var listaClienti = unit.Clients.GetAll().ToList()
                .OrderBy(client => client.Nume)
                .ThenBy(client => client.Prenume);
            unit.Complete();

            foreach (var client in listaClienti)
            {
                var clientInfo = $"{client.ID}. {client.Nume} {client.Prenume}, {client.Telefon}";

                this.cutieListaClienti.Items.Add(clientInfo);
            }
        }

        private void cutieListaClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            // preiau datele de la client din bd si afisez in cutia de informatii

            var item = this.cutieListaClienti.SelectedItem?.ToString();
            if (item is null)
                return;

            var clientID = int.Parse(item.Replace(".", "").Split(" ")[0]);

            var client = unit.Clients.GetById(clientID);
            client.CartiImprumutate = unit.Books.GetAll()
                .Where(book => book.ClientID == clientID).ToList();
            unit.Complete();

            string temp = string.Empty;
            if (!client.CartiImprumutate.Any())
                temp = "Nu are nicio carte imprumutata";
            else
            {
                temp = "Are imprumutate urmatoarele carti:" + Environment.NewLine;
                foreach (var book in client.CartiImprumutate)
                {
                    temp += $"- '{book.Titlu}' de {book.Autor}, " +
                        $"luata la data {book.DataImprumut} si trebuie adusa pana la {book.DataReturnare}"
                        + Environment.NewLine + Environment.NewLine;
                }
            }

            this.boxInfoClient.Text =
                $"ID = {client.ID}" + Environment.NewLine +
                $"Nume, prenume = {client.Nume} {client.Prenume}" + Environment.NewLine +
                $"Nr. telefon = {client.Telefon}" + Environment.NewLine +
                $"Adresa = {client.Adresa}" + Environment.NewLine + 
                temp;
        }

        private void butInapoi_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void butClientNou_Click(object sender, EventArgs e)
        {
            // se deschide ecranu separat
            var ecranClientNou = new ecranClientNou(unit);
            ecranClientNou.Show();
        }

        private void butRefreshListaClienti_Click(object sender, EventArgs e)
        {
            // sterg toata lista afisata si o umplu iar

            this.cutieListaClienti.Items.Clear();

            var listaClienti = unit.Clients.GetAll().ToList()
                .OrderBy(client => client.Nume)
                .ThenBy(client => client.Prenume);
            unit.Complete();

            foreach (var client in listaClienti)
            {
                var clientInfo = $"{client.ID}. {client.Nume} {client.Prenume}, {client.Telefon}";
                this.cutieListaClienti.Items.Add(clientInfo);
            }
        }

        private void cutieListaClienti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // la dublu click se sterge

            var item = this.cutieListaClienti.SelectedItem?.ToString();
            if (item is null)
                return;

            // aflu toate datele clientului
            var clientID = int.Parse(item.Replace(".", "").Split(" ")[0]);

            if (clientID == 1) return; // in caz ca o apasat gresit pe biblioteca, 
                                       // nu poate fi stearsa

            var client = unit.Clients.GetById(clientID);
            client.CartiImprumutate = unit.Books.GetAll()
                .Where(book => book.ClientID == clientID).ToList();
            

            // mai intai eliberez toate cartile (banuiesc ca asta se doreste)

            foreach(var book in client.CartiImprumutate)
            {
                book.EsteImprumutata = false;
                book.ClientID = 1;
                book.DataReturnare = DateTime.Today;
                book.DataImprumut = DateTime.MaxValue;

                unit.Books.Update(book);
            }

            unit.Clients.Remove(client);
            unit.Complete();

            butRefreshListaClienti_Click(null, null);
        }
    }
}
