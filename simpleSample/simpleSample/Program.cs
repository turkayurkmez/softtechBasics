using System;
using System.Collections.Generic;

namespace simpleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kullanıcının, sisteme ürün eklemesini, silmesini, aramasını sağlayan mini uygulama...
             * 
             * Nesneler:
             *    Ürün
             *    Ürün Servisi
             *    
             */
            string choose = string.Empty;
            do
            {
                Console.WriteLine("Ne yapmak istiyorsunuz?");
                Console.WriteLine("1. Yeni Ürün Ekle");
                Console.WriteLine("2. Tüm Ürünleri Göster");
                Console.WriteLine("3. Ürün Ara");
                Console.WriteLine("4. Ürün Sil");
                Console.WriteLine("0. Çıkış");
                choose = Console.ReadLine();
                sendToAction(choose);

            } while (choose != "0");

        }

        private static void sendToAction(string choose)
        {
            switch (choose)
            {
                case "1":
                    addNewProduct();
                    break;
                case "2":
                    showAllProducts(productService.GetProducts());
                    break;
                case "3":
                    searchProducts();
                    break;
                case "4":
                    removeProduct();
                    break;

                default:
                    break;
            }
        }

        private static void removeProduct()
        {
            do
            {
                showAllProducts(productService.GetProducts());
                Console.WriteLine("Silmek istediğiniz ürünün ID'sini girin:");
                int deletingId = int.Parse(Console.ReadLine());
                var deletingProduct = productService.FindProduct(deletingId);
                if (deletingProduct == null)
                {
                    Console.WriteLine("Böyle bir ID'li  ürün yok!");
                }
                else
                {
                    productService.Remove(deletingProduct);
                    Console.WriteLine("Ürün silindi");
                }
                Console.WriteLine("Bir ürün daha silmek ister misiniz (E/H)?");

            } while (Console.ReadLine()=="E");
        }

        static ProductService productService = new ProductService();

       
      
        private static void addNewProduct()
        {
            do
            {
                Product product = new Product();
                Console.WriteLine("Ürün adı giriniz");
                product.Name = Console.ReadLine();

                Console.WriteLine("Ürün fiyatını giriniz:");
                product.Price = double.Parse(Console.ReadLine());

                Console.WriteLine("Ürün Açıklamasını giriniz:");
                product.Description = Console.ReadLine();

                productService.Add(product);
                Console.WriteLine("Bir ürün daha eklemek ister misiniz (E/H)?");
            } while (Console.ReadLine()=="E");
        }


        private static void showAllProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"| {product.Id} | {product.Name} | {product.Price} | {product.Description}");
                Console.WriteLine("---------------------------------------------------------------------------");

            }
        }

        private static void searchProducts()
        {
            do
            {
                Console.WriteLine("Aradığınız ürünün adında geçecek ifadeyi girin:");
                var findingProducts = productService.SearchProductsByName(Console.ReadLine());
                if (findingProducts.Count == 0)
                {
                    Console.WriteLine(" ----- aradığınız ürün bulunamadı ----- ");
                }
                else
                {
                    Console.WriteLine("Bulunan ürünler:");
                    showAllProducts(findingProducts);
                }
                Console.WriteLine("Başka ürün aramak ister misiniz (E/H)");
            } while (Console.ReadLine()=="E");
        }

    }
}
