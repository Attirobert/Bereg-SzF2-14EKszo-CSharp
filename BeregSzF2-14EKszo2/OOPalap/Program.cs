using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Az Ember példányosítása
            Ember janos = new Ember("János");
            Ember kati = new Ember("Kati");

            Console.WriteLine("A janos objektum neve: "+janos.getNev());
            janos.setNev("Jánoska");
            Console.WriteLine("A janos objektum neve: " + janos.getNev());
            janos.SzulHely = ("Debrecen");
            Console.WriteLine(janos.get());
            Console.ReadKey();
            
        }
    }

    public class Ember
    {
        // Tagváltozók
        private string nev;

        public string SzulHely { set; get; }

        // Konstruktor metódus
        public Ember(string nev)
        {
            this.nev = nev;
            this.SzulHely = "Miskolc";
        }

        public void setNev(string nev)
        {
            if (this.nev != nev) this.nev = nev;
        }

        public string getNev() {
            return this.nev;
        }

        public string get()
        {
            return ("A "+ this.nev+" születési helye "+ this.SzulHely);
        }
    }
}
