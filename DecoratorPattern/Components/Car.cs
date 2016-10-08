using System;

namespace DecoratorPattern.Components
{
    public class Car : RentalItem
    {
        private string Make { get; set; }
        private int Doors { get; set; }
        private string EngineType { get; set; }

        public Car(string make, int doors, string engineType, int copies)
        {
            Make = make;
            Doors = doors;
            EngineType = engineType;
            Copies = copies;
        }

        public override void Display()
        {
            string divider = new string('-', 50);
            Console.WriteLine();
            Console.WriteLine(divider);
            Console.WriteLine("Car");
            Console.WriteLine(divider);
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Engine: {EngineType}");
            Console.WriteLine($"Doors: {Doors}");
        }
    }
}
