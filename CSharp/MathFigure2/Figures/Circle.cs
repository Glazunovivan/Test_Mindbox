namespace MathFigure2
{
    public class Circle : Figure
    {
        private double _radius;

        public double Radius => _radius;

        internal Circle() { }

        protected override double GetArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }

        protected override void Initialize(params double[] values)
        {
            _radius = values[0];
        }
    }
}
