using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace Builder
{
    public abstract class WarriorBuilder
    {
        protected readonly string _nazwa;

        public WarriorBuilder(string nazwa)
        {
            _nazwa = nazwa;
        }

        public IWarrior Warrior { get; set; }
        internal abstract void ZapiszDoArmi();
        internal abstract void PobierzBron();
        internal abstract IWarrior TrenujZBronia();
    }
}
