using Microsoft.EntityFrameworkCore;
using NuCaIoMaSinucid.Business.UnitOfWorkLogic;
using NuCaIoMaSinucid.Data;
using NuCaIoMaSinucid.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuCaIoMaSinucid
{
    static class MainProgram
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {


                // am un singur context pe toata durata rularii aplicatiei
                // nu construiesc mai multe incontinuu
                DataContext context = new DataContext();

                // construiesc baza de date in caz ca nu exista
                context.Database.Migrate();

                //imediat cum am generat-o fac un fake-client al bibliotecii
                if (!context.Clienti.Select(c => c.ID).Any())
                {
                    // daca e goala lista de clienti, generez asta
                    context.Clienti
                        .Add(new Data.Entities.Client("Biblioteca", "Ion Ionescu de la Brad",
                        "0233725665", "Str.Alexandru Cel Bun, nr.115, cod.617245"));
                    context.SaveChanges();
                }

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(new UnitOfWork(context)));
            }
            catch(Exception e)
            {
                Application.Run(new ErrorScreen(e.Message));
            }
        }

    }
}
