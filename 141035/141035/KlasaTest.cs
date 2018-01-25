using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141035
{
    class KlasaTest : IAaa, IBbb
    {
        private int numer;

        public KlasaTest()
        {

        }

        public KlasaTest(int numer)
        {
            this.numer = numer;
        }

        public int Druga()
        {
            return numer; ;
        }

        public string TestMetoda(int p1)
        {
            return Convert.ToString(p1);
        }
    }
}