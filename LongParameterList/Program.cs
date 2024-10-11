// See https://aka.ms/new-console-template for more information
using LongParameterList;

Console.WriteLine("Hello, World!");

Product product = new Product();


product.price = 100M;
product.productName = "Samsung S24 Ultra";
product.supplierName = "MediaExpert";
product.supplierContact = "media@gmail.com";
product.category = "Telefony";
product.stock = 100;

ProductHelper.RegisterProduct(product);

Console.ReadKey();


