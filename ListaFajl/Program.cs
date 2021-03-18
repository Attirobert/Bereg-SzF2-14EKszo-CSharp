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
        public int bulizasi_hajlam; 
    }

    class Program
    {
        // Osztályváltozók
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

        private static void kiir(List<barat> ls)
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
