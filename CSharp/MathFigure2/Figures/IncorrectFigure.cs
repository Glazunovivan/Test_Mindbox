
namespace MathFigure2
{
    public class IncorrectFigure : Figure
    {
        protected override double GetArea() => -1;

        protected override void Initialize(params double[] values) { }
    }
}
