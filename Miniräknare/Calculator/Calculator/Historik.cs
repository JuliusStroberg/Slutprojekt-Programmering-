using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{   /*Classen har som funktion att spara alla uträkningar man gör som strings*/
    class Historik
    {
        public string Ekvation { get; set; }

        public Historik(string ekv)
        {
            Ekvation = ekv;
        }
    }
}
