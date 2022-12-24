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
            int sum = 0;
            int a = 0;
            int b = 0; 
            int c = 0;
            Console.Write("a= "); //ввод первого числа с клавиатуры
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b= "); //ввод второго числа с клавиатуры
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("c= "); //ввод третьего числа с клавиатуры
            c = Convert.ToInt16(Console.ReadLine());
            {
                sum = a + b + c;
            }
            Console.WriteLine("{0}+{1}+{2} = {2}+{1}+{0}", a, b, c); //вывод на экран суммы ввведеных чисел в прямом и обратном порядке
        }
    }
}