using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasycard
{
    class Program
    {
        static void Main(string[] args)
        {
            Kartyak k = new Kartyak("fantasycard.csv");
            k.harmadikFeladat();
            k.negyedikFeladat();
            //k.otodikFeladat();
            Console.ReadLine();
        }
    }
}
