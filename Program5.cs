using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double a = 0;
            double b = 0;
            Console.Write("a= ");
            a = Convert.ToDouble(Console.ReadLine()); //ввод первого числа с клавиатуры
            Console.Write("b= ");
            b = Convert.ToDouble(Console.ReadLine()); //ввод второго числа с клавиатуры
            {
                sum = a / b;
            }
            Console.WriteLine("{0}/{1}", a, b); 
            Console.WriteLine("{0}", Math.Round(sum, 3)); //вычисление деления введенных чисел и вывод результата на экран 
            Console.ReadLine();
        }
    }
}