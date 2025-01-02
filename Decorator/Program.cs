using Decorator;

Shop shop = new Shop();
shop.PayCard();

Console.WriteLine();
Console.WriteLine("Decorator:");

ShopDecorator shopDecorator = new ShopDecorator(shop);
shopDecorator.PayBitcoin();
shopDecorator.PayCard();
