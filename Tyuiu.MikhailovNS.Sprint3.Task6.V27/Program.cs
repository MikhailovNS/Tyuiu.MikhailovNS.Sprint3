using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint3.Task6.V27.Lib;

namespace Tyuiu.MikhailovNS.Sprint3.Task6.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #27                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих        *");
            Console.WriteLine("* числовому отрезку [14, 20] сумму всех делителей больше 9                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int startValue = 14;
            int stopValue = 20;
            int sum = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("Начало отрезка: " + startValue);
            Console.WriteLine("Конец отрезка: " + stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Сумма делителей, больших 9, равна " + sum);
            Console.ReadKey();
        }
    }
}
