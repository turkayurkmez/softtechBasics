using System;

namespace AbstractAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            WordDocument word = new WordDocument();
            PdfDocument pdf = new PdfDocument();
            PowerPointDocument powerPoint = new PowerPointDocument();
            ExcelDocument excelDocument = new ExcelDocument();

            PrintComponent printComponent = new PrintComponent();
            printComponent.PrintDocument(word);
            printComponent.PrintDocument(excelDocument);

            //C# derleyicisi kabul etmeyecek:
           // printComponent.PrintDocument(pdf);

        }
    }
}
