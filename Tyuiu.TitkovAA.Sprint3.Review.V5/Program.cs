using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint3.Review.V5.Lib;

namespace Tyuiu.TitkovAA.Sprint3.Review.V5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("*                                                                         *");
            //Console.WriteLine("***************************************************************************");
            //75симв->

            Console.Title = "Спринт #2 | Выполнил: Титков А. А. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: решение задания                                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* F(x)=(2sin(x))/(3x+1.2)+cos(x)-7x*2) (произвести табулирование) f(x) на *");
            Console.WriteLine("* заданном диапазоне [-5;5] с шагом 1. Произвести проверку деления на ноль*");
            Console.WriteLine("* При делении на ноль вернуть значение 0. округлить до 2 знаков           *");
            Console.WriteLine("***************************************************************************");

            DataService dt = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+-----------+");

            int StartVal = -5, stopVal = 5;
            int length = stopVal - StartVal + 1;
            double[] valarr = new double[length];
            valarr = dt.GetMassFunction(StartVal, stopVal);
            Console.WriteLine("|   X      |   f(x)    |");
            Console.WriteLine("+----------+-----------+");
            for(int i = 0; i < length ; i++)
            {
                Console.WriteLine("|  {0,5:d}   |   {1, 6:f2}  |", StartVal,valarr[i]);
                StartVal++;
            }
            Console.WriteLine("+----------+-----------+");



        }
    }
}
