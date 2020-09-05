using System;
using System.Collections.Generic;
using System.Text;

namespace NuCaIoMaSinucid.Data.Entities
{
    public class Client
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public IEnumerable<Book> CartiImprumutate { get; set; }

        public Client()
        {
            //this.CartiImprumutate = new List<Book>();
            //las gol ca am presupus ca si aici trebuie un constructor basic
        }

        public Client(string nume, string prenume, string telefon, string adresa)
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.Telefon = telefon;
            this.Adresa = adresa;
        }

        /*public void ImprumutaCarte(Book newBook)
        {
            
        }

        public void AfiseazaCartile()//toate cartile pe care le-a imprumutat clientul
        {
            
        }

        public override string ToString()
        {
            return
                $"{this.Nume}, {this.Prenume}, {this.Telefon}, {this.Adresa}, {this.cartiImprumutate}";
        }

        public static Client GetFakeBiblioteca()
        {
            return new Client("Biblioteca", "Ion Ionescu De La Brad", "0233744655", "Basta");
        }

        public string DateAdresa()
        {
            return
                $"{this.Nume}, {this.Prenume}, {this.Telefon}";
        }*/
    }
}
