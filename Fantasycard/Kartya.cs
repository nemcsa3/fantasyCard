using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasycard
{
    class Kartya
    {
        private int power;
        private string name;
        private string faction;
        private string race;
        private string klasz;

        public Kartya(string sor)
        {
            string[] st = sor.Split(';');

            this.power = Convert.ToInt32(st[0]);
            this.name = st[1];
            this.faction = st[2];
            this.race = st[3];
            this.klasz = st[4];
        }

        public int getPower()
        {
            return this.power;
        }

        public string getName()
        {
            return this.name;
        }

        public string getFaction()
        {
            return this.faction;
        }

        public string getRace()
        {
            return this.race;
        }

        public string getKlasz()
        {
            return this.klasz;
        }

        public override string ToString()
        {
            return String.Format("{0},{1},{2}",this.name,this.race,this.klasz);
        }
    }
}

