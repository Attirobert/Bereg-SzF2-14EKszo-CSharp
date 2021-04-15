using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliform
{
    class Program
    {
        static void Main(string[] args)
        {
            // Felépítjük a házat (A ház példányosítása)
            Haz otthon = new Haz();

            // Példányosítjuk a szereplőket
            // Hölgyek
            Women eva = new Women("Éva", "zöld");
            Women kati = new Women("Kati", "barna");
            Women sari = new Women("Sári", "kék");
            Women zsuzsi = new Women("Zsuzsi", "zöld");            
            
            // Férfiak
            Ferfi adam = new Ferfi("Ádám", 26);
            Ferfi dani = new Ferfi("Dani", 26);
            Ferfi gergo = new Ferfi("Gergő", 26);
            Ferfi atti = new Ferfi("Attila", 26);

            // Beköltöznek a szereplők a házba
            if (eva is Ember) otthon.hazajon(eva as Ember);
            otthon.hazajon((Ember)kati);
            otthon.hazajon((Ember)sari);
            otthon.hazajon((Ember)zsuzsi);
            otthon.hazajon((Ember)adam);
            otthon.hazajon((Ember)dani);
            otthon.hazajon((Ember)gergo);
            otthon.hazajon((Ember)atti);

            // Jönnek idegenek és csengetnek
            bool tovabb = true;
            do
            {
                otthon.csenget();
                tovabb = (Console.ReadLine() == String.Empty) ? false : true;
            } while (tovabb);
        }
    }

    class Ember
    {
        public string Nev { set; get; }
        private string bemut = "Üdvözlöm, a nevem: ";
        public Ember(string nev)
        {
            Nev = nev;
        }

        public string beszel()
        {
            return (bemut + Nev);
        }
    }

    class Ferfi : Ember
    {
        public int Kor { set; get; }
        public Ferfi(string nev, int kor) : base(nev)
        {
            Kor = kor;
        }
    }

    class Women : Ember
    {
        public string SzemSzin { set; get; }
        public Women(string nev, string szemszin) : base(nev)
        {
            SzemSzin = szemszin;
        }
    }

    class Haz
    {
        private List<Ember> lakok = new List<Ember>();

        public void hazajon(Ember obj)
        {
            lakok.Add(obj);
        }

        public void csenget()
        {
            int i;
            Random rd = new Random();
            // Ha vannak a házban, akkor véletlen szerűen kijön valaki és beszél
            if (lakok.Count > 0)
            {
                i = rd.Next(0, lakok.Count - 1);
                Console.WriteLine(lakok[i].beszel());
                Console.ReadLine();
            }
        }

    }
}
