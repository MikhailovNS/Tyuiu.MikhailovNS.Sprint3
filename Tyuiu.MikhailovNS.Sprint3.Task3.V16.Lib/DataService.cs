using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MikhailovNS.Sprint3.Task3.V16.Lib
{
    public class DataService : ISprint3Task3V16
    {
        public int GetCharCount(string value, char item)
        {
            int c = 0;
            foreach(char chr in value)
            {
                if (chr == item)
                {
                    c++;
                }
            }
            return c;
        }
    }
}
