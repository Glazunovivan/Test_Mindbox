
namespace MathFigure2
{
    public class TriangleFactory : FigureFactory
    {
        public override Figure Create(params double[] values)
        {
            return new Triangle().Create(values);
        }
    }
}
