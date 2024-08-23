namespace MathFigure
{
    public class Triangle : Figure
    {
        private double _a = 0;
        private double _b = 0;
        private double _c = 0;

        public double A => _a;
        public double B => _b;
        public double C => _c;

        internal Triangle() { }

        protected internal override bool ValidateBeforeInitialize(params double[] values)
        {
            var result = base.ValidateBeforeInitialize(values);
            if (result == true && values.Length == 2)
            {
                return false;
            }

            return result;
        }

        internal protected override void Initialize(params double[] values)
        {
            if (values.Length == 1)
            {
                _a = _b = _c = values[0];
            }
            else
            {
                _a = values[0];
                _b = values[1];
                _c = values[2];
            }
        }
        
        internal protected override Figure ValidateAfterInitialize()
        {
            if ((_a != 0 || _b != 0 || _c != 0) && (_a >= (_b + _c) || _b >= (_a + _c) || _c >= (_a + _b)))
            {
                return new IncorrectFigure();
            }
            return this;
        }

        internal protected override double GetArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRight()
        {
            var array = new[] { _a, _b, _c }.OrderBy(x => x).ToArray();
            double gipotenuza = array[2];
            double catet1 = array[1];
            double catet2 = array[0];

            return Math.Pow(gipotenuza, 2) == Math.Pow(catet1, 2) + Math.Pow(catet2, 2);
        }
    }
}
