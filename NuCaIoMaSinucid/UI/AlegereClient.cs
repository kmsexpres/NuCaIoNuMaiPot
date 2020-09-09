using NuCaIoMaSinucid.Business.UnitOfWorkLogic;
using NuCaIoMaSinucid.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NuCaIoMaSinucid.UI
{
    public partial class AlegereClient : Form
    {
        private readonly UnitOfWork unit;
        private readonly int carteAleasaID;

        private AlegereClient()
        {
            InitializeComponent();
        }

        public AlegereClient(UnitOfWork unit, int carteAleasaID) : this()
        {
            this.unit = unit;
            this.carteAleasaID = carteAleasaID;
        }

        private void butAlege_Click(object sender, EventArgs e)
        {
            // trag datele clientului din bd si merg mai departe cu imprumutul

            var item = this.cutieListaClienti.SelectedItem?.ToString();
            if (item is null)
                return;

            // concretizez toate datelele de care am nevoie
            var clientId = int.Parse(item.Replace(".", "").Split(" ")[0]);
            var clientAdev = unit.Clients.GetById(clientId);
            var carteAdev = unit.Books.GetById(carteAleasaID);
            var dataImprum = this.dateImprum.Value;
            var dataReturn = this.dateReturn.Value;
            // presupun ca cartea aleasa nu este imprumutata deja, nu verific asta aici

            carteAdev.EsteImprumutata = true;
            carteAdev.DataImprumut = dataImprum;
            carteAdev.DataReturnare = dataReturn;
            carteAdev.Client = clientAdev;
            carteAdev.ClientID = clientAdev.ID;

            unit.Books.Update(carteAdev);
            // doamne ajuta poate merge

        }

        private void AlegereClient_Load(object sender, EventArgs e)
        {
            // scriu lista de clienti

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

        private void butInapoi_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cutieListaClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
