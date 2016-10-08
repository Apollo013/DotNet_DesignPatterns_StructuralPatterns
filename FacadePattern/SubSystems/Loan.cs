using FacadePattern.Models;
using System;

namespace FacadePattern.SubSystems
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine($"Checking loan history for {c.Name}");
            Random rand = new Random();
            return rand.NextDouble() > 0.5;
        }
    }
}
