using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFajl
{
    class barat { 
        public string nev; 
        public DateTime szuletesi_datum; 
        public char neme; 
        public int bulizasi_hajlam; // Az értéke [1, 10]

        /* 
        Az OOP alapelemei

        1./ Class - osztály
        Osztályváltozók / tagváltozók / property: elemi (pl. int, string, bool, stb.)  vagy 
                összetett változók (pl. tömb, osztály, stb.)
        Metódusok
        Az Osztályváltozókat és metódusokat együttesen az osztály tagjainak nevezzük.

        2./ Származtatás: az osztályok egymásból származtathatók, és a leszármazott örökli a szülő osztály egyes tagjait. Ennek módja a programban szabályozható a láthatósági szintekkel.

        3./ Példányosítás
        Az osztályokat általában nem közvetlenül használjuk, hanem a new paranccsal objektum példányokat hozunk létre.

        4./ Láthatósági szint az osztály tagjaira vonatkozik:
        public - az osztály tagja az osztályon kívülről is elérhető
        private - az osztály tagja az osztályon kívülről nem elérhető, csak az osztály metódusai férnek hozzá. Nem származtathatók
        protected - olyan mint a private csak a leszármazottakban is elérhető

        5./ Egységbezárás (encapsulation)
        Lényege, hogy az osztály belső változóihoz más osztályok metódusai csak ellenőrzötten férhessenek hozzá.
        Eszközei: Láthatóság.  
        Megoldás: A tagváltozókat private láthatóságra állítom be és public láthatóságú metódussal férek hozzá.

        6./ Többalakúság (poliformizmus)
        Az objektumok szükség esetén úgy tudnak viselkedni, mint ha az ősosztályukból lettek volna példányosítva.


        */
    }

    class Program
    {
        // Osztályváltozók / tagváltozók / property
        public string fajl = "baratok.txt";
        public List<barat> lista = new List<barat>();

        static void Main(string[] args)
        {
            // Olvasás billentyűzetről és kiírás fájlba
            olvasKlav();

            // Beolvasás fájlból listába
            //lista = olvasFajl();

            // Lista kiírása táblázatos formában
            kiir(olvasFajl());
        }

        private void kiir(List<barat> ls)
        {
            foreach (barat p in ls)
            {
                Console.WriteLine("{0,-20} {1,10} {2,1} {3}",
                    p.nev,
                    p.szuletesi_datum.ToString("yyyy.MM.dd"),
                    p.neme,
                    p.bulizasi_hajlam);
            }
        }

        private static List<barat> olvasFajl()
        {
            List<barat> lst = new List<barat>(); 
            StreamReader r = new StreamReader("baratok.txt", Encoding.Default); 
            
            while (r.EndOfStream == false) { 
                string s = r.ReadLine(); 
                if (s.Trim().Length == 0) continue; 
                string[] ss = s.Split('|'); 
                barat b = new barat(); 
                b.nev = ss[0]; 
                b.szuletesi_datum = DateTime.Parse(ss[1]); 
                b.neme = char.Parse(ss[2]); 
                b.bulizasi_hajlam = int.Parse(ss[3]); 
                lst.Add(b); 
            }

            r.Close();

            return lst;
        }

        private static void olvasKlav()
        {
            // 
            bool tovabb = true;

            do
            {

            } while (tovabb);
        }
    }
}
