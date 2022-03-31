using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleSample
{
    public class ProductService
    {
        private List<Product> products = new List<Product>();
        public void Add(Product product)
        {
            int id = products.Count == 0 ? 1 : products[products.Count - 1].Id + 1;
            product.Id = id;
            products.Add(product);
        }

        public Product FindProduct(int id)
        {
            return products.Find(p => p.Id == id);
        }
        public void Remove(Product product)
        {
            products.Remove(product);
        }

        public List<Product> SearchProductsByName(string name)
        {
            //LINQ:
            List<Product> findingProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.Name.Contains(name))
                {
                    findingProducts.Add(product);
                }
            }

            //Yukarıdaki işlem ile aynı amacı güden LINQ yaklaşımı:
            var findProductWithLINQ = products.Where(x => x.Name.Contains(name)).ToList();

            return findingProducts;


        }

        public bool IsProductExist(int id)
        {
            bool result = false;
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool IsProductExist(string name)
        {
            bool result = false;
            foreach (var product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public List<Product> GetProducts()
        {
            return products;
        }

    }
}
