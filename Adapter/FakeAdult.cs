﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FakeAdult : Adult
    {
        public override bool IsAdult(Teenager teenager)
        {
            Console.WriteLine(teenager.Name + " to osoba pełnoletnia.");
            return true;
        }
    }
}
