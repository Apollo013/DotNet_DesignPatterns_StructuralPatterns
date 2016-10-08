using FacadePattern.Models;
using System;

namespace FacadePattern.SubSystems
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine($"Checking bank balance for {c.Name}");
            Random rand = new Random();
            return rand.NextDouble() > 0.5;
        }
    }
}
