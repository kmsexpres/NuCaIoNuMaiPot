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
    public partial class ecranClientNou : Form
    {
        public ecranClientNou()
        {
            InitializeComponent();
        }

        private void butAdaugaClient_Click(object sender, EventArgs e)
        {
            // iau datele din casute si le trimit in baza de date

            var nume = this.boxNume.Text;
            var prenume = this.boxPrenume.Text;
            var tel = this.boxTelefon.Text;
            var adresa = this.boxAdresa.Text;

            using(var unit = new UnitOfWork(new DataContext()))
            {
                var newClient = new Client(nume, prenume, tel, adresa);

                unit.Clients.Add(newClient);

                unit.Complete();
            }
        }
    }
}
