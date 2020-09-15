using Microsoft.EntityFrameworkCore;
using NuCaIoMaSinucid.Business.UnitOfWorkLogic;
using NuCaIoMaSinucid.Data;
using NuCaIoMaSinucid.Data.Entities;
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
        private readonly UnitOfWork unit;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(UnitOfWork unitOfWork) : this()
        {
            // folosesc un worker ca sa separ form-ul de baza de date cat mai mult
            // si folosesc doar 1, nu generez altii pe parcurs
            this.unit = unitOfWork;
        }


        private void umpleCutieListaCartiCu(IEnumerable<Book> lista)
        {
            // functia goleste cutia si scrie ce i-am trimis

            this.cutieListaCarti.Items.Clear();

            lista = lista.OrderBy(carte => carte.Autor)
                .ThenBy(carte => carte.Titlu);
            foreach (var carte in lista)
            {
                this.cutieListaCarti.Items
                    .Add($"{carte.ID}. '{carte.Titlu}' de {carte.Autor}");
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            // cand se incarca aplicatia iau toate datele din 
            // BD carti si le afisez in boxListaCarti

            var query = unit.Books.GetAll().ToList();
            unit.Complete();

            umpleCutieListaCartiCu(query);
        }

        private void cutieListaCarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            // citesc stringu afisat ca sa aflu ce carte iau din bd
            var item = this.cutieListaCarti.SelectedItem?.ToString();
            if (item is null)
                return;

            var bookID = int.Parse(item.Replace(".", "").Split(" ")[0]);

            // iau datele
            var carte = unit.Books.GetById(bookID);
            carte.Client = unit.Clients?.GetById(carte.ClientID);
          
            unit.Complete();

            // le afisez in cutia de jos
            string temp = String.Empty;
            if (carte.Client.Nume.ToLower() != "biblioteca")
                temp = $"A fost data la {carte.DataImprumut} si trebuie returnata pana la {carte.DataReturnare}" + Environment.NewLine;

            this.boxInfoCarte.Text =
                $"ID = {bookID}" + Environment.NewLine +
                $"Titlu = {carte.Titlu}" + Environment.NewLine +
                $"Autor = {carte.Autor}" + Environment.NewLine +
                $"Se afla la {carte.Client.Nume} {carte.Client.Prenume}" + Environment.NewLine +
                $"{temp}" +
                $"Detalii despre carte:" + Environment.NewLine + $"{carte.Detalii}";

            // reglez butonu de imprumut, daca e ocupata cartea il dezactivez
            // si il activez pe ala de returnat
            if (carte.EsteImprumutata)
            {
                this.butImprumutaCarte.Visible = false;
                this.butReturnCarte.Visible = true;
            }
            else
            {
                this.butImprumutaCarte.Visible = true;
                this.butReturnCarte.Visible = false;
            }
        }

        private void butInsertCarte_Click(object sender, EventArgs e)
        {
            // se deschide meniul de adaugat carte noua
            var ecranInsertCarte = new EcranInsertCartiNoi(unit);
            ecranInsertCarte.Show();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            var query = unit.Books.GetAll().ToList();
            unit.Complete();

            umpleCutieListaCartiCu(query);
        }

        private void butInsertClient_Click(object sender, EventArgs e)
        {
            var ecranClienti = new EcranListaClienti(unit, true);
            ecranClienti.Show();
        }

        private void butEcranClienti_Click(object sender, EventArgs e)
        {
            var ecranClienti = new EcranListaClienti(unit);
            ecranClienti.Show();
        }

        private void radButToate_CheckedChanged(object sender, EventArgs e)
        {
            // sterg lista si umplu cu toate cartile

            var listaCarti = unit.Books.GetAll().ToList();
            unit.Complete();

            umpleCutieListaCartiCu(listaCarti);
        }

        private void radButLibere_CheckedChanged(object sender, EventArgs e)
        {
            // golesc lista si pun cartile neimprumutate

            var listaCartiLibere = unit.Books.GetAll().Where(carte => carte.EsteImprumutata == false).ToList();
            unit.Complete();

            umpleCutieListaCartiCu(listaCartiLibere);
        }

        private void radButImprum_CheckedChanged(object sender, EventArgs e)
        {
            // cu alea imprumutate

            var listaCartiOcupate = unit.Books.GetAll().Where(carte => carte.EsteImprumutata == true).ToList();
            unit.Complete();

            umpleCutieListaCartiCu(listaCartiOcupate);
        }

        private void radButIntarziate_CheckedChanged(object sender, EventArgs e)
        {
            // cu alea intarziate

            var listaIntarziate = unit.Books.GetAll()
                .Where(carte => carte.EsteImprumutata == true)
                .Where(carte => carte.DataReturnare < DateTime.Now) // s-a depasit data de returnare
                .ToList();
            unit.Complete();

            umpleCutieListaCartiCu(listaIntarziate);
        }

        private void butImprumutaCarte_Click(object sender, EventArgs e)
        {
            var item = this.cutieListaCarti.SelectedItem?.ToString();
            if (item is null)
                return;

            var bookID = int.Parse(item.Replace(".", "").Split(" ")[0]);

            var ecranImprumutCarte = new AlegereClient(unit, bookID);
            ecranImprumutCarte.Show();
        }

        private void butReturnCarte_Click(object sender, EventArgs e)
        {
            // iau cartea selectata si o marchez ca fiind la biblioteca

            var item = this.cutieListaCarti.SelectedItem?.ToString();
            if (item is null)
                return;

            var bookID = int.Parse(item.Replace(".", "").Split(" ")[0]);

            var actualCarte = unit.Books.GetById(bookID);
            actualCarte.EsteImprumutata = false;
            actualCarte.ClientID = 1; // cam brutal dar csf
            actualCarte.Client = unit.Clients.GetById(actualCarte.ClientID);
            actualCarte.DataImprumut = DateTime.Now;
            actualCarte.DataReturnare = DateTime.MaxValue;

            unit.Books.Update(actualCarte);
            unit.Complete();

            // redesenez
            var bookList = unit.Books.GetAll().ToList();
            umpleCutieListaCartiCu(bookList);
            this.cutieListaCarti.SelectedIndex = 0;
        }
    }
}
