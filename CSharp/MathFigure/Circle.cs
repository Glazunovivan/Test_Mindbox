namespace MathFigure
{
    public class Circle : Figure
    {
        private double _radius = 0;

        public double Radius => _radius;

        internal Circle() { }

        internal protected override double GetArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }

        internal protected override void Initialize(params double[] values)
        {
            _radius = values[0];
        }
    }
}
