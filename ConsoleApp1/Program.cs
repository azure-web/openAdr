using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace add
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.Write("Sum of Two Numbers in C# Using Console");
            Console.Write("\n\n");
            Console.Write("Enter the first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.Write("\n\n");
            Console.WriteLine("The sum of {0} and {1} is {2}.", a, b, sum);
            Console.Write("\n\n");
            Console.Write("End of Program");
            Console.ReadLine();
        }
    }
}