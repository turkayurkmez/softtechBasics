using System;
using System.Collections.Generic;

namespace forEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string> { "Kitap", "DVD", "XBox One" };
            List<string> deletedProducts = new List<string>();
            foreach (var product in products)
            {
               
                Console.WriteLine(product);
                deletedProducts.Add(product);
               
            }

            foreach (var product in deletedProducts)
            {
                products.Remove(product);
            }

            Console.WriteLine($"Toplam product içindeki eleman:{products.Count}");
        }
    }
}
