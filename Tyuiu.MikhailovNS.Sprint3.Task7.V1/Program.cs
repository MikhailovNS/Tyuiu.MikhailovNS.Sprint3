using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint3.Task7.V1.Lib;

namespace Tyuiu.MikhailovNS.Sprint3.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функций:            *");
            Console.WriteLine("*          sinx                                                            *");
            Console.WriteLine("* F(x) = --------- +cosx*7*x-2                                             *");
            Console.WriteLine("*         x + 1.2                                                          *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1   *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть         *");
            Console.WriteLine("* значение 0. Значения занести в массив. Значения округлить до двух знаков *");
            Console.WriteLine("* после запятой                                                            *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("+---------+------------+");
            Console.WriteLine("|    X    |    f(x)    |");
            Console.WriteLine("+---------+------------+");
            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("|{0,5:d}    |   {1,6:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+---------+------------+");
            Console.ReadKey();
        }
    }
}
