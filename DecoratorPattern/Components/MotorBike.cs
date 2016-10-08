using System;

namespace DecoratorPattern.Components
{
    public class MotorBike : RentalItem
    {
        private string Make { get; set; }
        private int Wheels { get; set; }
        private string CC { get; set; }

        public MotorBike(string make, int wheels, string cc, int copies)
        {
            Make = make;
            Wheels = wheels;
            CC = cc;
            Copies = copies;
        }

        public override void Display()
        {
            string divider = new string('-', 50);
            Console.WriteLine();
            Console.WriteLine(divider);
            Console.WriteLine("MotorBike");
            Console.WriteLine(divider);
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"CC: {CC}");
            Console.WriteLine($"Wheels: {Wheels}");
        }
    }
}
