// See https://aka.ms/new-console-template for more information
using System;
namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Os operadores e a logica dos calculos são muito parecidos com o de outras linguagens de programação
            byte a = 100;
            byte b = 25;
            Console.WriteLine(a);
            Console.WriteLine(b);
            string sumString = $"The sum is {a + b}";
            string subString = $"the subtraction is {a - b}";
            string mulString = $"the multiplication is {a * b}";
            string divString = $"the division is {a / b}";
            Console.WriteLine(sumString);
            Console.WriteLine(subString);
            Console.WriteLine(mulString);
            Console.WriteLine(divString);
        }
    }
}
