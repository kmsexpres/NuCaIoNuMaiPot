﻿using Microsoft.Data.SqlClient;
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
        private readonly UnitOfWork unit;

        private EcranInsertCartiNoi()
        {
            InitializeComponent();
        }

        public EcranInsertCartiNoi(UnitOfWork unit) : this()
        {
            this.unit = unit;
        }

        private void butFinishBook_Click(object sender, EventArgs e)
        {
            // dau click pe 'adauga' si inserez ce scrie in casute in baza de date

            // preiau datele din casute si le golesc
            if(this.boxCodInventar.Text == string.Empty)
            {
                this.boxDetaliiCarte.Text = "Trebuie introdus un cod de inventar";
                return;
            }
            var ID = int.Parse(this.boxCodInventar?.Text);
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

            try
            {
                var newBook = new Book(ID, titlu, autor, detalii)
                {
                    EsteImprumutata = esteImprumutata,
                    DataImprumut = dataImprumut,
                    DataReturnare = dataReturnare,
                    Client = unit.Clients.GetById(1)
                };
                newBook.ClientID = newBook.Client.ID;

                unit.Books.Add(newBook);
                unit.Complete();
            }
            catch(ArgumentException argEx)
            {
                this.boxDetaliiCarte.Text = argEx.Message;
            }
            catch(SqlException sqlEx)
            {
                this.boxDetaliiCarte.Text = sqlEx.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // buton de iesire
            this.Dispose(true);
        }
    }
}
