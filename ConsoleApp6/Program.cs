using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введи второе число: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введи третье число: ");
            int third = Convert.ToInt32(Console.ReadLine());

            if (first >= second)
            {
                if(first >= third)
                {
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(third);
                }
            }
            else
            {
                if(second >= third)
                {
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine(third);
                }
            }


        }
    }
}
