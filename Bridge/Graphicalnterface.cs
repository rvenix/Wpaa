using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Graphicalnterface : ISystemInterface
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Wyświetlam menu z graficznego interfesju");
        }
    }
}
