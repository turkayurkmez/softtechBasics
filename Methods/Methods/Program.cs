using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            showMessage("işlem tamam");
            Console.WriteLine("Bir sayı girin:");
            int x = int.Parse(Console.ReadLine());
            //if (isEven(x))
            //{
            //    Console.WriteLine("Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Tektir");
            //}
            //syntactic sugar: Normalde uzun uzun yazmanız gereken bir şeyi (yukarıdaki if gibi), daha tatlış ve kısa yazmanızı sağlar:
            Console.WriteLine(isEven(x) ? "Çifttir" : "Tektir");
           
            int[] weathers = { 22, 19, 0, 36, 52,18 };
            showMessage($"en yüksek sıcaklık: {getMaxNumber(weathers)}");

            string companyName = "softtech";
            //companyName.i
            int indexPosition = IndexOf(companyName, 't');

            Console.WriteLine( indexPosition == -1 ? "aradığınız harf kelimede yok" : $"index değeri: {indexPosition}");
            string[] products = { "A", "B", "C" };
            string message =  isExists(products.ToList(), "D") ? "Aradığınız string ifade koleksiyonda var" : "Aradığınız string ifade koleksiyonda yok";
            Console.WriteLine(message);
            
            //getMaxNumber()
        }

       static void showMessage(string message)
        {
            Console.WriteLine(message);
        }

        static bool isEven(int number)
        {
            return number % 2 == 0;
        }

        static bool isEven(double value)
        {
            return false;
        }

        /// <summary>
        /// sayısal bir array içindeki en büyük sayıyı bulur.
        /// </summary>
        /// <param name="numbers">sayısal array</param>
        /// <returns></returns>
        static int getMaxNumber(int[] numbers)
        {
            return numbers.ToList().Max();
        }


        static int IndexOf(string word, char letter)
        {
            int indexValue = -1;
            for (int index = 0; index < word.Length; index++)
            {
                if (word[index] == letter)
                {
                    indexValue = index;
                    break;
                }
            }
            return indexValue;
        }

        static bool isExists(List<string> items, string item)
        {
            foreach (var itemInCollection in items)
            {
                if (item == itemInCollection)
                {
                   
                    return true;
                }
            }

            return false;
        }




    }
}
