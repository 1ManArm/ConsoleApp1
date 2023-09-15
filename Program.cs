using System;
using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();

            //p.FizzBuzz();

            //int first, second, ans;

            //Console.WriteLine("Hello, World!");

            //Console.ReadLine();

            //first = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Insert Num2:");

            //second = Convert.ToInt32(Console.ReadLine());
            //var a = 5;
            //ans = first + second;

            //Console.WriteLine(ans);
            Console.Write("Число: ");
            double num = Convert.ToInt32(Console.ReadLine());

            //Console.ReadLine();

            Console.Write("Процент: ");
            double percent = Convert.ToInt32(Console.ReadLine());

            //Console.ReadLine();
            Console.Write("Результат: ");

            double res = (num / 100) * percent;
            Console.WriteLine(res);
        }

        public void FizzBuzz()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 100 || number < 1)
            {
                Console.WriteLine("Error");
                return;
            }

            if (number % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            if(number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if(number % 3 != 0 && number % 5 != 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}