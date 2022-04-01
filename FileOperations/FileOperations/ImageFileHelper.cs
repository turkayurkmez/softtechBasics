using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    public static class ImageFileHelper
    {
        public static List<string> FindImageInFolder(string folderPath, bool isLogToFolder = false)
        {
            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException("Yok böyle bir klasör!");

            }


            var files = Directory.GetFiles(folderPath, "*.png", SearchOption.AllDirectories).ToList();
            if (isLogToFolder)
            {
                File.WriteAllLines($"{folderPath}/log.txt", files);
            }

            return files;
        }
    }
}
