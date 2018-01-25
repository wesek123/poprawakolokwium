using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141035
{
    class Elf : Bohater
    {
        private string magia;

        public Elf() { }
        public Elf(int hp, string magia)
            : base(hp)
        {
            base.hp = hp;
            this.magia = magia;
        }
        public override bool ZadajCios(int hp)
        {
            return base.ZadajCios(hp);
        }
        public override string ToString()
        {
            return String.Format("Elf: {0}, magia: {1}", hp, magia);
        }
    }
}
