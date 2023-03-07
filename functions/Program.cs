// See https://aka.ms/new-console-template for more information
using System;
namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Os operadores e a logica dos calculos são muito parecidos com o de outras linguagens de programação
            byte a = 5;
            byte b = 3;
            int sum = Sum(a, b);
            int sub = Sub(a, b);
            string sumString = $"The sum is {sum}";
            Console.WriteLine(sumString);
            string subString = $"The sum is {sub}";
            Console.WriteLine(subString);

            string sumsumsubString = $"The sum of the sum and the sub is {Sum(sum, sub)}";
            Console.WriteLine(sumsumsubString);
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
