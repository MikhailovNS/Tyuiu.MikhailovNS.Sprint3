using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint3.Task3.V16.Lib;

namespace Tyuiu.MikhailovNS.Sprint3.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #16                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв “c” в строке ice nice  *");
            Console.WriteLine("* ice creamcc.                                                             *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string value = "ice nice ice creamcc";
            char chr = 'c';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Искомый символ: " + chr);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Количество символов = " + ds.GetCharCount(value, chr));
            Console.ReadKey();
        }
    }
}
