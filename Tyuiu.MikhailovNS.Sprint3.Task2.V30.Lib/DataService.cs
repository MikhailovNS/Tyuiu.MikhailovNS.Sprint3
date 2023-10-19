using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MikhailovNS.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            value = 0.25;
            startValue = 1;
            stopValue = 11;
            double res = 1;
            do
            {
                res = res*((Math.Pow(value, 2) * startValue) + 2);
                startValue++;
            } while (stopValue >= startValue);
            
            return Math.Round(res,3);
        }
    }
}
