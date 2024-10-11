using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongParameterList
{
    public static class ProductHelper
    {
        public static void RegisterProduct(Product productInfo)
        {
            // Rejestracja produktu
            Console.WriteLine($"Product: {productInfo.productName}, Category: {productInfo.category}, Price: {productInfo.price:C}, Stock: {productInfo.stock}, Supplier: {productInfo.supplierName}, Contact: {productInfo.supplierContact}");
        }

        public static void RegisterProduct(string productName, string category, decimal price, int stock, string supplierName, string supplierContact)
        {
            // Rejestracja produktu
            Console.WriteLine($"Product: {productName}, Category: {category}, Price: {price:C}, Stock: {stock}, Supplier: {supplierName}, Contact: {supplierContact}");
        }
    }
}
