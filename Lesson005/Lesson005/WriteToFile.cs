using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lesson005
{
    class WriteToFile
    {
        private string SomeText;
        public void ReadText()
        {
            Console.WriteLine("Введите любой текст");
            SomeText = Console.ReadLine();
        }
        public void WriteTextInFile(string Path001)
        {
            File.WriteAllText(Path001, SomeText);
        }
    }
}
