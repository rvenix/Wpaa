using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace Builder
{
    public class StrzelecBuilder : WarriorBuilder
    {
        public StrzelecBuilder(string nazwa) : base(nazwa)
        {

        }

        internal override void PobierzBron()
        {
            Console.Write(" Strzelec pobrał łuk");
        }

        internal override IWarrior TrenujZBronia()
        {
            Console.WriteLine(" Strzelec może strzelać");
            return new Strzelec(this._nazwa);
        }

        internal override void ZapiszDoArmi()
        {
            Console.WriteLine(" Strzelec zapisal się do armii.");
        }
    }
}
