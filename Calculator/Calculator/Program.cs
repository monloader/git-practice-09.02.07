using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());


            Console.Write("Выберите операцию (+): ");
            Console.Write("Выберите операцию (+, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (op == "+") Console.WriteLine("Результат: " + (a + b));
            else if (op == "*") Console.WriteLine("Результат: " + (a * b));
            else if (op == "/")
            {
                if (b == 0) Console.WriteLine("Error: Division by zero");
                else Console.WriteLine("Результат: " + (a / b));
            }
            else Console.WriteLine("Неверная операция!");
        }
    }
}
