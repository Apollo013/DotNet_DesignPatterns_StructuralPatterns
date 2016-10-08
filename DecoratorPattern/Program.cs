using DecoratorPattern.Components;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 5, "V8", 20);
            car.Display();

            MotorBike bike = new MotorBike("Honda", 3, "1000", 10);
            bike.Display();

            Rentalable rentableVehicle = new Rentalable(car);
            rentableVehicle.RentItem("Johnny");
            rentableVehicle.RentItem("Mary");

            rentableVehicle.Display();
        }
    }
}
