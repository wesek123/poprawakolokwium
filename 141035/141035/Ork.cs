using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141035
{
    class Ork:Bohater
    {
        public int walka;

        public Ork() { }
        public Ork(int hp, int walka)
            :base(hp)
        {
            base.hp = hp;
            this.walka = walka;
        }

        public override bool ZadajCios(int hp)
        {
            return base.ZadajCios(hp);
        }
        public override string ToString()
        {
            return String.Format("Ork: {0}, walka: {1}", hp, walka);
        }
    }
}
