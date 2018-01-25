using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141035
{
    class Sport
    {
        private string nazwa;

        public Sport() { }
        public Sport(string nazwa)
        {
            this.nazwa = nazwa;
        }
        public string sportmetoda(string nazwa)
        {
            return nazwa;
        }
        public override string ToString()
        {
            return String.Format("Sport: {0}",nazwa);
        }

        

    }
}
