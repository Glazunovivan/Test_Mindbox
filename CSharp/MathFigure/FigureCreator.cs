namespace MathFigure
{
    public static class FigureCreator
    {
        public static Figure Create<T>(params double[] values) where T : Figure
        {
            T result = (T)Activator.CreateInstance(typeof(T), true);

            if (result.ValidateBeforeInitialize(values) == false)
            {
                return new IncorrectFigure();
            }

            result.Initialize(values);
            var incorrectAfterCrate = result.ValidateAfterInitialize();
            if (incorrectAfterCrate is IncorrectFigure)
            {
                return incorrectAfterCrate;
            }

            return result;
        }
    }
}
