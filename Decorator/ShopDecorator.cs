using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class ShopDecorator
    {
        private Shop _shop;

        public ShopDecorator(Shop shop)
        {
            _shop = shop;
        }

        public void SendSMSMessage()
        {
            Console.WriteLine("Wysłano SMS.");
        }

        public void AddLoyaltyProgramPoint()
        {
            Console.WriteLine("Dodano punktu do programu lojalnościowego.");
        }

        public void RedirectToHomePage()
        {
            Console.WriteLine("Przekierowano na stronę główną.");
        }

        public void PayCard()
        {
            if (_shop != null)
            {
                _shop.PayCard();
                SendSMSMessage();
                AddLoyaltyProgramPoint();
                RedirectToHomePage();
            }
        }

        public void PayCash()
        {
            if (_shop != null)
            {
                _shop.PayCash();
            }
        }

        public void PayBitcoin()
        {
            if (_shop != null)
            {
                _shop.PayBitcoin();
            }
        }
    }
}
