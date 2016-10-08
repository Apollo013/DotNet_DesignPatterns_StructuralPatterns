using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators
{
    public class Decorator : RentalItem
    {

        protected RentalItem _rentalItem;

        public Decorator(RentalItem rentalItem)
        {
            _rentalItem = rentalItem;
        }

        public override void Display()
        {
            _rentalItem.Display();
        }
    }
}
