using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fantasycard
{
    class Kartyak
    {
        private List<Kartya> kartyak;

        public Kartyak(string fajlNev)
        {
            kartyak = new List<Kartya>();
            try
            {
                using (StreamReader fajl = new StreamReader(fajlNev))
                {

                    string firstLine = fajl.ReadLine();
                    string line;
                    while ((line = fajl.ReadLine()) != null)
                    {
                        Kartya k = new Kartya(line);
                        kartyak.Add(k);
                    }
                    fajl.Close();

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("A fájl nem található:");
                Console.WriteLine(e.Message);
            }
        }

        public void harmadikFeladat()
        {
            foreach (var v in kartyak)
            {
                if (v.getName().Equals("Leeroy"))
                {
                    Console.WriteLine("3.feladat: {0}, {1}, {2}",v.getName(),v.getRace(),v.getKlasz());
                }
            }
        }

        public void negyedikFeladat()
        {
            int minIndex=0;
            int maxIndex = 0;
            for (int i = 0; i < kartyak.Count; i++)
            {
                if (kartyak[i].getPower()<kartyak[minIndex].getPower())
                {
                    minIndex = i;
                }
                if (kartyak[i].getPower() > kartyak[maxIndex].getPower())
                {
                    maxIndex = i;
                }

            }

            Console.WriteLine("4.feladat:\n \tlegkisebb erejű: {0} {1}\n\ta legnagyobb erejű: {2} {3}",kartyak[minIndex].getName(),kartyak[minIndex].getPower(),kartyak[maxIndex].getName(),kartyak[maxIndex].getPower());
        }

        public void otodikFeladat()
        {
            foreach (var v in kartyak)
            {
                if (v.getRace().Equals("dwarf")&& v.getPower()==4000)
                {
                    Console.WriteLine("5.fealadat: {0} {1}",v.getName(),v.getRace());
                }
            }
        }
    }
}