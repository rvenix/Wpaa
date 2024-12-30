using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace Builder
{
    internal class Strzelec : IWarrior
    {
        public string Nazwa { get; set; }

        public string Bron
        {
            get
            {

                return "Łuk";
            }
        }

        public Strzelec(string nazwa)
        {
            Nazwa = nazwa;
        }
    }
}
