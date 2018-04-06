using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Folder_Size
{
    public class FolderSize
    {
        public static void Main()
        {
            var currentFiles = Directory.GetFiles("../../TestFolder");

            var totelSize = 0L;

            foreach (var file in currentFiles)
            {
                var fileInfo = new FileInfo(file);
                totelSize += fileInfo.Length;
            }

            var result = (totelSize / 1024.0 / 1024.0).ToString();

            File.WriteAllText("../../Output.txt", result);           
        }
    }
}
