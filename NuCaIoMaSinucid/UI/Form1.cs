using Microsoft.EntityFrameworkCore;
using NuCaIoMaSinucid.Business.UnitOfWorkLogic;
using NuCaIoMaSinucid.Data;
using NuCaIoMaSinucid.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuCaIoMaSinucid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // cand se incarca aplicatia iau toate datele din 
            // BD carti si le afisez in boxListaCarti

            // de asemenea aicea generez baza de date in caz ca nu exista deja
            // nu cred ca e indicat tho dar asta ie

            using (DataContext context = new DataContext())
            {
                // construiesc baza de date in caz ca nu exista
                context.Database.Migrate();

                //imediat cum am generat-o fac un fake-client al bibliotecii
                if(!context.Clienti.Select(c => c.ID).Any())
                {
                    // daca e goala lista de clienti, generez asta
                    context.Clienti
                        .Add(new Data.Entities.Client("Biblioteca", "Ion Ionescu de la Brad", 
                        "0233725665", "Str.Alexandru Cel Bun, nr.115, cod.617245"));
                    context.SaveChanges();
                }
            }

            using (UnitOfWork unit = new UnitOfWork(new Data.DataContext()))
            {
                var query = unit.Books.GetAll();

                foreach (var carte in query)
                {
                    this.cutieListaCarti.Items
                        .Add($"{carte.ID}. {carte.Titlu}, {carte.Autor}");
                }

                unit.Complete();
            }
        }

        private void cutieListaCarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = this.cutieListaCarti.SelectedItem.ToString();

            var bookID = int.Parse(item.Replace(".", "").Split(" ")[0]);
            
            using(var unit = new UnitOfWork(new DataContext()))
            {
                var carte = unit.Books.GetById(bookID);
                carte.Client = unit.Clients.GetById(carte.ClientID);

                string temp = String.Empty;
                if (carte.Client.Nume.ToLower() != "biblioteca")
                    temp = $"A fost predata la {carte.DataImprumut} si trebuie returnata pana la {carte.DataReturnare}" + Environment.NewLine;

                this.boxInfoCarte.Text =
                    $"ID = {bookID}" + Environment.NewLine +
                    $"Titlu = {carte.Titlu}" + Environment.NewLine +
                    $"Autor = {carte.Autor}" + Environment.NewLine +
                    $"Se afla la {carte.Client.Nume} {carte.Client.Prenume}" + Environment.NewLine +
                    $"{temp}" +
                    $"Detalii despre carte:" + Environment.NewLine + $"{carte.Detalii}";

                unit.Complete();
            }

        }

        private void butInsertCarte_Click(object sender, EventArgs e)
        {
            // se deschide meniul de adaugat carte noua
            var ecranInsertCarte = new EcranInsertCartiNoi();
            ecranInsertCarte.Show();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            this.cutieListaCarti.Items.Clear();

            using (UnitOfWork unit = new UnitOfWork(new DataContext()))
            {
                var query = unit.Books.GetAll();

                foreach (var carte in query)
                {
                    this.cutieListaCarti.Items
                        .Add($"{carte.ID}. {carte.Titlu}, {carte.Autor}");
                }

                unit.Complete();
            }
        }
    }
}
