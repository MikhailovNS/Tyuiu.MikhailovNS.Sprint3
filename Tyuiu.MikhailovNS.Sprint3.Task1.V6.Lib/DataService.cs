using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MikhailovNS.Sprint3.Task1.V6.Lib
{
    public class DataService : ISprint3Task1V6
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            startValue = 1;
            stopValue = 10;
            value = 4;
            double res= 0;
            while(startValue<=stopValue)
            {
                res = res+((Math.Pow(value, startValue) + 1) * Math.Sin(startValue));
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
