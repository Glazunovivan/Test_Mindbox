namespace MathFigure3
{
    public abstract class Figure
    {
        protected Figure(params double[] values)
        {
            if (ValidateBeforeInitialize(values))
            {
                Initialize(values);
                ValidateAfterInitialize(values);
            }
        }

        abstract protected bool ValidateBeforeInitialize(params double[] values);
        abstract protected void Initialize(params double[] values);
        abstract protected Figure ValidateAfterInitialize(params double[] values);
    }
}
