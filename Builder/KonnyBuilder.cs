using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace Builder
{
    public class KonnyBuilder : WarriorBuilder
    {
        public KonnyBuilder(string nazwa) : base(nazwa)
        {

        }

        internal override void PobierzBron()
        {
            Console.Write(" Konny pobrał włócznię");
        }

        internal override IWarrior TrenujZBronia()
        {
            Console.WriteLine(" Konny może walczyć");
            return new Konny(this._nazwa);
        }

        internal override void ZapiszDoArmi()
        {
            Console.WriteLine(" Konny zapisal się do armii.");
        }
    }
}
