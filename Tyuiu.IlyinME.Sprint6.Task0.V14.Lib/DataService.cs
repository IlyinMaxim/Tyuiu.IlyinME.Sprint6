using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.IlyinME.Sprint6.Task0.V14.Lib
{
    public class DataService : ISprint6Task0V14
    {
        public double Calculate(int x)
        {
            double res = (Math.Pow((1 - (double)x), 2)) / (-3 * (double)x);
            return Math.Round(res, 3);
        }
    }
}
