using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task3
{
    internal class Program
    {
        static double CheckCorrectInput()
        {
            double number  = double.Parse(Console.ReadLine());
            if (number != 0)
            {
                return number;
            }
            else
            {
                while (number == 0)
                {
                    Console.WriteLine($"число не может быть равно 0, введите другое число");
                    number = double.Parse(Console.ReadLine());
                }
                return number;
            }
        }
        static double Calculate()
        {
            Console.WriteLine("Введиче число a");
            double a = CheckCorrectInput();
            Console.WriteLine("Введиче число b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введиче число f");
            double f = double.Parse(Console.ReadLine());

            

            double result = (a + b - f / a) + f * a * a - (a + b);
            
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.ReadKey();
        }
    }
}
