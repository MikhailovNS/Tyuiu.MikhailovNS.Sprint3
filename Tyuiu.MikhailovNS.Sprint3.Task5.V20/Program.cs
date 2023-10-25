using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint3.Task5.V20.Lib;

namespace Tyuiu.MikhailovNS.Sprint3.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #20                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*       3   6     x                                                        *");
            Console.WriteLine("*  y =  E   E  (------)^k, при x = 5                                       *");
            Console.WriteLine("*      i=1 k=1  sin(x)                                                     *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 6;

            Console.WriteLine("Старт шага первой суммы ряда: "+ startValue1);
            Console.WriteLine("Конец шага первой суммы ряда: "+ stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда: "+ startValue2);
            Console.WriteLine("Конец шага второй суммы ряда: "+ stopValue2);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Сумма ряда равна " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadLine(); 
        }
    }
}
