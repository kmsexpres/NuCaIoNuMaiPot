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
            using(var unit = new UnitOfWork(new DataContext()))
            {
                var listaClienti = unit.Clients.GetAll();

                foreach(var client in listaClienti)
                {
                    var clientInfo = $"{client.ID}. {client.Nume} {client.Prenume}, {client.Telefon}";

                    this.cutieListaClienti.Items.Add(clientInfo);
                }

                unit.Complete();
            }
        }

        private void cutieListaClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            // preiau datele de la client din bd si afisez in cutia de informatii

            var item = this.cutieListaClienti.SelectedItem.ToString();

            var clientID = int.Parse(item.Replace(".", "").Split(" ")[0]);

            using (var unit = new UnitOfWork(new DataContext()))
            {
                var client = unit.Clients.GetById(clientID);
                client.CartiImprumutate = unit.Books.GetAll()
                    .Where(book => book.ClientID == clientID).ToList();

                string temp = string.Empty;
                if (!client.CartiImprumutate.Any())
                    // nu are nicio carte imprumutata
                    temp = "Nu are nicio carte imprumutata";
                else
                {
                    temp = "Are imprumutate urmatoarele carti:" + Environment.NewLine;
                    foreach(var book in client.CartiImprumutate)
                    {
                        temp += $"~ ID {book.ID}. {book.Titlu} de {book.Autor}, " +
                            $"luata la data {book.DataImprumut} si trebuie returnata pana la {book.DataReturnare}"
                            + Environment.NewLine;
                    }
                }

                this.boxInfoClient.Text =
                    $"ID = {client.ID}" + Environment.NewLine +
                    $"Nume, prenume = {client.Nume} {client.Prenume}" + Environment.NewLine +
                    $"Nr. telefon = {client.Telefon}" + Environment.NewLine +
                    $"Adresa = {client.Adresa}" + Environment.NewLine + temp;

                unit.Complete();
            }
        }

        private void butInapoi_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }


        private void butClientNou_Click(object sender, EventArgs e)
        {
            // se deschide ecranu separat
            var ecranClientNou = new ecranClientNou();
            ecranClientNou.Show();
        }

        private void butRefreshListaClienti_Click(object sender, EventArgs e)
        {
            // sterg toata lista afisata si o umplu iar

            this.cutieListaClienti.Items.Clear();
            using (var unit = new UnitOfWork(new DataContext()))
            {
                var listaClienti = unit.Clients.GetAll();

                foreach (var client in listaClienti)
                {
                    var clientInfo = $"{client.ID}. {client.Nume} {client.Prenume}, {client.Telefon}";

                    this.cutieListaClienti.Items.Add(clientInfo);
                }

                unit.Complete();
            }
        } 
    }
}
