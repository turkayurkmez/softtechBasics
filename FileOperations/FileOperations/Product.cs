using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
   public class Product
    {
        private static int instanceCount;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
            instanceCount++;
        }

        public static int TotalInstance()
        {
            return instanceCount;
        }
    }
}
