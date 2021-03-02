using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lesson005
{
    class AdderTime
    {
        public void WriteTime(string Path001)
        {            
            File.AppendAllText(Path001, $"{DateTime.Now.ToString("HH:mm:ss")} {DateTime.Now.ToString("dd MMMM yyyy")} {Environment.NewLine}");
        }
        public void ShowFile(string Path001)
        {
            Console.WriteLine();
            Console.WriteLine("Содержимое файла:");
            string[] AllString = File.ReadAllLines(Path001);

            foreach (var Item in AllString)
            {
                Console.WriteLine(Item);
            }
        }
    }
}
