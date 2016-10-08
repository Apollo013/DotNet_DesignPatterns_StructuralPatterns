namespace ProxyPattern
{
    public class CalculatorProxy : ICalculator
    {
        private Calculator _calc = new Calculator();

        public double Add(double x, double y)
        {
            return _calc.Add(x, y);
        }

        public double Subtract(double x, double y)
        {
            return _calc.Subtract(x, y);
        }

        public double Multiply(double x, double y)
        {
            return _calc.Multiply(x, y);
        }

        public double Divide(double x, double y)
        {
            return _calc.Divide(x, y);
        }
    }
}
