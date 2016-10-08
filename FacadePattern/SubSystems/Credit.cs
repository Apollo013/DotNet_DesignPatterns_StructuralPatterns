using FacadePattern.Models;
using System;

namespace FacadePattern.SubSystems
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine($"Checking credit history for {c.Name}");
            Random rand = new Random();
            return rand.NextDouble() > 0.5;
        }
    }
}
