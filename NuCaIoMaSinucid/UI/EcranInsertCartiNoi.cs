using NuCaIoMaSinucid.Business.UnitOfWorkLogic;
using NuCaIoMaSinucid.Data;
using NuCaIoMaSinucid.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NuCaIoMaSinucid.UI
{
    public partial class EcranInsertCartiNoi : Form
    {
        public EcranInsertCartiNoi()
        {
            InitializeComponent();
        }

        private void EcranInsertCartiNoi_Load(object sender, EventArgs e)
        {

        }

        private void butFinishBook_Click(object sender, EventArgs e)
        {
            // dau click pe 'adauga' si inserez ce scrie in casute in baza de date

            // preiau datele din casute si le golesc
            var ID = int.Parse(this.boxCodInventar.Text);
            this.boxCodInventar.Text = String.Empty;

            var titlu = this.boxTitlu.Text;
            this.boxTitlu.Text = String.Empty;

            var autor = this.boxAutor.Text;
            this.boxAutor.Text = String.Empty;

            var detalii = this.boxDetaliiCarte.Text;
            this.boxDetaliiCarte.Text = String.Empty;

            var esteImprumutata = false;

            var dataImprumut = DateTime.MaxValue;
            var dataReturnare = DateTime.MinValue;

            using(var unit = new UnitOfWork(new DataContext()))
            {
                var newBook = new Book(ID, titlu, autor, detalii);
                newBook.EsteImprumutata = esteImprumutata;
                newBook.DataImprumut = dataImprumut;
                newBook.DataReturnare = dataReturnare;
                newBook.Client = unit.Clients.GetById(1);
                newBook.ClientID = newBook.Client.ID;

                unit.Books.Add(newBook);

                unit.Complete();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // buton de iesire
            this.Dispose(true);
        }
    }
}
