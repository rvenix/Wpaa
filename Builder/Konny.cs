using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace Builder
{
    internal class Konny : IWarrior
    {
        public string Nazwa { get; set; }

        public string Bron
        {
            get
            {

                return "Wlócznia";
            }
        }

        public Konny(string nazwa)
        {
            Nazwa = nazwa;
        }
    }
}
