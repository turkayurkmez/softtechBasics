using System;
using System.Data.SqlClient;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CamasirMakinesi arcelik = new CamasirMakinesi();
            Console.WriteLine(arcelik.Renk);
            arcelik.Renk = "Bordo";

            CamasirMakinesi samsung = new CamasirMakinesi("Siyah");

            CamasirMakinesi electrolux = new CamasirMakinesi { CalismaHizi = 1200, Renk = "Mavi", EnerjiTuketimi = "A++" };
            Console.WriteLine($"{electrolux.Renk} {electrolux.CalismaHizi} ve {electrolux.EnerjiTuketimi}");

            ReportGenerator reportGenerator = new ReportGenerator("C:\\excel1.xlsx");
            reportGenerator.ExcelFilePath = "C:\\excel1.xlsx";
            reportGenerator.Generate();
        }
    }
}
