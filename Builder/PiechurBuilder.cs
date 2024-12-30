using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace Builder
{
    public class PiechurBuilder : WarriorBuilder
    {
        public PiechurBuilder(string nazwa) : base (nazwa)
        {
                
        }

        internal override void PobierzBron()
        {
            Console.Write(" Piechur pobrał miecz");
        }

        internal override IWarrior TrenujZBronia()
        {
            Console.WriteLine(" Piechur może walczyć");
            return new Piechur(this._nazwa);
        }

        internal override void ZapiszDoArmi()
        {
            Console.WriteLine(" Piechur zapisal się do armii.");
        }
    }
}
