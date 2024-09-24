using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task2
{
    internal class Program
    {
        //Задача a
        static void TaskA()
        {
            Console.WriteLine("Задача a");
            Console.WriteLine("Введите метры");
            string number = Console.ReadLine();


            
            double converter = double.Parse(number) / 1000;
            Console.WriteLine($"{number} м = {converter} км");
        }
        //Задача b
        static void TaskB()
        {
            Console.WriteLine("Задача b");
            Console.WriteLine("Введите километры");
            string number = Console.ReadLine();
            double converter = double.Parse(number) * 10000;


            Console.WriteLine($"{number} км = {converter} см");
        }
        //Задача c
        static void TaskC()
        {
            Console.WriteLine("Задача c");
            Console.WriteLine("Введите м/с");
            string number = Console.ReadLine();
            double converter = double.Parse(number) * 3.6;
            Console.WriteLine($"{number} м/с = {converter} км/ч");

        }
        //Задача d
        static void TaskD()
        {
            Console.WriteLine("Задача d");
            Console.WriteLine("Введите градусы C");
            string number = Console.ReadLine();


            double converter = (double.Parse(number) * 9 / 5) + 32;
            Console.WriteLine($"{number}C = {converter}F");
        }
        static void Main(string[] args)
        {
            TaskD();
            Console.ReadKey();
        }
    }
}
