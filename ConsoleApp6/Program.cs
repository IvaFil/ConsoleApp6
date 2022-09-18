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

            Console.WriteLine("Введи первое число: ");
            int second = Convert.ToInt32(Console.ReadLine());

            if(first >= second)
            {
                Console.WriteLine("max = "+first);
            }
            else
            {
                Console.WriteLine("max = "+second);
            }

        }
    }
}
