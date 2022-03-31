using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   public class ReportGenerator
    {
        //Amaç: Bir Excel dosyasından veri çekerek rapor oluşturacak bir nesne inşa edeceksiniz.
        public string ExcelFilePath { get; set; }
        //public ReportGenerator()
        //{

        //}

        public ReportGenerator(string filePath)
        {
            ExcelFilePath = filePath;
        }

        public void Generate()
        {

        }
    }
}
