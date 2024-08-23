namespace MathFigure
{
    public class IncorrectFigure : Figure
    {
        protected internal override double GetArea() => -1;

        protected internal override void Initialize(params double[] values) { }
    }
}
