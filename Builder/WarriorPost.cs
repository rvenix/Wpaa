using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace Builder
{
    public class WarriorPost
    {
        public IWarrior warrior;
        public WarriorPost(WarriorBuilder warriorBuilder)
        {
            warriorBuilder.ZapiszDoArmi();
            warriorBuilder.PobierzBron();
            warrior = warriorBuilder.TrenujZBronia();

        }
    }
}
