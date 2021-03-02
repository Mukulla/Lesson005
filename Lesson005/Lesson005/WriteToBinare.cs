using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lesson005
{
    class WriteToBinare
    {
        private Binares Numbers;
        public void ReadNumbers()
        {
            Console.WriteLine("Введите набор символов через пробел");
            Numbers = new Binares(Console.ReadLine());
        }
        public void Write(string Path001)
        {
            BinaryFormatter Binarrer = new BinaryFormatter();
            FileStream File001 = new FileStream(Path001, FileMode.OpenOrCreate);
            Binarrer.Serialize(File001, Numbers);
            File001.Close();
        }
        public void Show(string Path001)
        {
            Console.WriteLine();
            Console.WriteLine("Содержимое файла:");
            
            BinaryFormatter Binarrer = new BinaryFormatter();
            FileStream File001 = new FileStream(Path001, FileMode.OpenOrCreate);
            Binares FileNumbers = (Binares)Binarrer.Deserialize(File001);
            File001.Close();

            Console.WriteLine(FileNumbers.BinareNumbers);
        }
    }
}
