namespace DecoratorPattern.Components
{
    public abstract class RentalItem
    {
        public int Copies { get; set; }
        public abstract void Display();
    }
}
