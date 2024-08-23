namespace MathFigure2
{
    public class CircleFactory : FigureFactory
    {
        public override Figure Create(params double[] values)
        {
            return new Circle().Create(values);
        }
    }
}
