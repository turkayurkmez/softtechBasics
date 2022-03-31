using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    //Abstract: instance alınamayan sadece miras alınan sınıf
   public abstract class Document
    {
        public abstract void Open();
        public void Copy(string from, string to)
        {
            Console.WriteLine("dosya kopyalandı");
        }

        public abstract void Save();
        //public abstract void Print();
      
    }

    public interface IPrintable
    {
        void Print();
    }

    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine($"{this.GetType().Name} açıldı" );
        }

    

        public override void Save()
        {
            Console.WriteLine($"{this.GetType().Name} kaydedildi");

        }
    }
    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine($"{this.GetType().Name} açıldı");

        }

        public void Print()
        {
            Console.WriteLine($"{this.GetType().Name} çıktısı alındı"); 
        }

        public override void Save()
        {
            Console.WriteLine($"{this.GetType().Name} kaydedildi");

        }
    }
    public class WordDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine($"{this.GetType().Name} açıldı");

        }

        public void Print()
        {
            Console.WriteLine($"{this.GetType().Name} çıktısı alındı");

        }

        public override void Save()
        {
            Console.WriteLine($"{this.GetType().Name} kaydedildi");

        }
    }
    public class PowerPointDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine($"{this.GetType().Name} açıldı");

        }     

        public override void Save()
        {
            Console.WriteLine($"{this.GetType().Name} kaydedildi");
        }
    }


    public class PrintComponent
    {
        public void PrintDocument(IPrintable printableDocument)
        {
            printableDocument.Print();
        }
    }

}
