using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TitkovAA.Sprint3.Review.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            double[] valarray = new double[(stopValue - startValue) + 1];


            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                try
                {
                    y = Math.Round((2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2);

                    valarray[c] = y;
                }
                catch (DivideByZeroException)
                {
                    valarray[c] = 0;
                }
                c++;
            }
            return valarray;
        }


    }
}
