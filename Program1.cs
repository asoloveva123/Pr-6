using System;

namespace Hello
{
    class Program
    {
        static void Main()
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine()); //ввод первого числа с клавиатуры 
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine()); //ввод второго числа с клавиатуры
            Console.WriteLine("{0}+{1}={2}", a, b, a + b); //вычисление суммы введеных чисел и вывод результата на экран
        }
    }
}