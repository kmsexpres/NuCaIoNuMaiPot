using System;
using System.Collections.Generic;
using System.Text;

namespace NuCaIoMaSinucid.Data.Entities
{
    public class Book
    {
        public Book()
        {

        }

        public int ID { get; set; }    //nr inventariere gen
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public string Detalii { get; set; }
        public bool EsteImprumutata { get; set; }

        public Client Client { get; set; }     //ori e in biblioteca, 
                                                 //ori e imprumutata la un om si contine datele acestuia
                                                 //biblioteca poate fi considerata ca un "client" special, 
                                                 //io zic ca merge
        public int ClientID { get; set; }   // se leaga de SeAflaLa
        public DateTime DataReturnare { get; set; }
        //cred ca DateTime e variabila pt asta nuj 
        // -> daca EsteImprumutata e true atunci trebuie introdusa o data pt returnare

        public DateTime DataImprumut { get; set; }

        public Book(int ID, string titlu, string autor, string detalii)
        {
            if (ID < 0) throw new ArgumentException("Trebuie sa introduceti un ID pozitiv");
            if (titlu == null || titlu == "") throw new ArgumentException("Trebuie sa introduceti titlul cartii");
            if (autor == null || autor == "") throw new ArgumentException("Trebuie sa introduceti numele autorului");

            this.ID = ID;
            this.Titlu = titlu;
            this.Autor = autor;
            this.Detalii = detalii;
        }

        /*public override string ToString()
        {
            return
                $"{this.ID}, {this.Titlu}, {this.Autor}, {this.Detalii}, {this.SeAflaLa}";
        }*/
    }
}
