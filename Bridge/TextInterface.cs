using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TextInterface : ISystemInterface
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Wyświetlam menu z tekstowego interfejsu.");
        }
    }
}
