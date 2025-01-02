using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Shop
    {
        public void PayCard()
        {
            Console.WriteLine("Płatność kartą.");
        }

        public void PayCash()
        {
            Console.WriteLine("Płatność gotówką.");
        }

        public void PayBitcoin()
        {
            Console.WriteLine("Płatność kryptowalutą.");
        }
    }
}
