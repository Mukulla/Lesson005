using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson005
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountPars = 3;
            string[] Denuntiatio = new string[]
            {
                "Запись произвольного текста в файл",
                "Запись даты в файл построчно",
                "Запись набора числе в бинарный файл"
            };
            //Console.WriteLine(System.Text.Encoding.Default.HeaderName);
            //Цикл-обработчик каждого задания
            for (int i = 0; i < CountPars; ++i)
            {
                //Вывод части и названия задания
                Console.WriteLine($"Часть {i + 1}: {Denuntiatio[i]}");

                switch (i)
                {
                    case 0:
                        WriteToFile Writter = new WriteToFile();
                        Writter.ReadText();
                        Writter.WriteTextInFile("File001.txt");
                        Writter.ShowFile("File001.txt");
                        break;
                    case 1:
                        AdderTime CuTime = new AdderTime();
                        CuTime.WriteTime("startup.txt");
                        CuTime.ShowFile("startup.txt");
                        break;
                }
                if (i == 2)
                {
                    WriteToBinare Binarrer = new WriteToBinare();
                    Binarrer.ReadNumbers();
                    Binarrer.Write("Numbers.bin");
                    Binarrer.Show("Numbers.bin");

                    Console.WriteLine();
                    Console.WriteLine("Все части пройдены");
                    Console.WriteLine("Для выхода нажмите любую клавишу");
                    Console.ReadKey();

                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Для перехода к следующей части нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
