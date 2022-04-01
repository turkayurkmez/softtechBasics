using System;
using System.IO;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Product a = new Product();
            //Product b = new Product();

            Console.WriteLine($"Üretilen toplam product instance'ı:{Product.TotalInstance()} ");
            Console.WriteLine($"5 ile  17'nin çarpimi: {Matematik.Carp(5,12)}");

            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //foreach (var item in Directory.EnumerateFileSystemEntries(directoryPath))
            //{
            //    Console.WriteLine(item);
            //}

            try
            {
                var images =  ImageFileHelper.FindImageInFolder(directoryPath,isLogToFolder:true);
                foreach (var item in images)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception)
            {

                throw;
            }
             
        }
    }
}
