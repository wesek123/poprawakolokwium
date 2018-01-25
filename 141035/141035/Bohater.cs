using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141035
{
    class Bohater:IComparable<Bohater>
    {
        public int hp;

        public Bohater() { }
        public Bohater(int hp)
        {
            this.hp = hp;
        }
        public virtual bool ZadajCios(int hp)
        {
            return true;
        }
        public override string ToString()
        {
            return String.Format("BohaterHP: {0}", hp);
        }
        public int CompareTo(Bohater other)
        {
            return other.hp.CompareTo(this.hp);
        }
        
    }
}
