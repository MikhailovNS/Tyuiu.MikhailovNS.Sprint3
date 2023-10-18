using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint3.Task0.V4.Lib;

namespace Tyuiu.MikhailovNS.Sprint3.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение    *");
            Console.WriteLine("* ряда по формуле                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*     7                                                                    *");
            Console.WriteLine("* p = П sin(0,1) + k                                                       *");
            Console.WriteLine("*    к=1                                                                   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int startValue = 1;
            int stopValue =  7;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            Console.WriteLine("Старт шага равен " + startValue);
            Console.WriteLine("Конец шага равен " + stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Произведение ряда с округлением до 3 цифр после запятой равно " + res);

            Console.ReadKey();
        }
    }
}
