using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorProxy proxy = new CalculatorProxy();

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Subtract(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Multiply(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Divide(4, 2));
        }
    }
}
