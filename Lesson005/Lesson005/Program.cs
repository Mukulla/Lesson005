﻿using System;
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
            int CountPars = 1;
            string[] Denuntiatio = new string[]
            {
                "Запись произвольного текста в файл",
                "Сумма всех чисел в строке",
                "Определение времени года",
                "Вычисление числа Фибоначчи"
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
                        break;
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                }
                if (i == 3)
                {
                    
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
