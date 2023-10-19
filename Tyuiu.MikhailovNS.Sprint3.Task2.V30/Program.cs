using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint3.Task2.V30.Lib;

namespace Tyuiu.MikhailovNS.Sprint3.Task2.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #30                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет          *");
            Console.WriteLine("* произведение произведение ряда по формуле, при х=0,25                    *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*    11                                                                    *");
            Console.WriteLine("* S = П ((x^2)*n)+2                                                        *");
            Console.WriteLine("*    n=1                                                                   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;

            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);
            Console.WriteLine("Значение переменной x: " + value);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double res = Math.Round((ds.GetMultiplySeries(value,startValue,stopValue)),3);

            Console.WriteLine("Произведение ряда равно " + res);
            Console.ReadKey();
        }
    }
}
