using DecoratorPattern.Components;
using System;
using System.Collections.Generic;

namespace DecoratorPattern.Decorators
{
    public class Rentalable : Decorator
    {
        protected List<string> renters = new List<string>();

        public Rentalable(RentalItem rentalItem) : base(rentalItem)
        { }
        public void RentItem(string name)
        {
            renters.Add(name);
            _rentalItem.Copies--;
        }

        public void ReturnItem(string name)
        {
            renters.Remove(name);
            _rentalItem.Copies++;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Current Renters");
            foreach (string borrower in renters)
            {
                Console.WriteLine("\tCustomer: " + borrower);
            }
        }
    }
}
