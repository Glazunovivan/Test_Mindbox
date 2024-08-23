namespace MathFigure2
{
    public abstract class Figure : IArea
    {
        private double? _area = null;
        public double Area => (double)(_area ?? (_area = GetArea()));

        protected abstract double GetArea();

        public Figure Create(params double[] values)
        {
            if(ValidateBeforeInitialize(values))
            {
                Initialize(values);
                return ValidateAfterInitialize();
            }
            return new IncorrectFigure();
        }

        /// <summary>
        /// Базовая проверка на входные параметры (они должны быть и быть не отрицательными)
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        protected virtual bool ValidateBeforeInitialize(params double[] values)
        {
            if (!values.Any() || values.Any(x => x < 0))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Инициализация значений фигуры
        /// </summary>
        /// <param name="values"></param>
        protected abstract void Initialize(params double[] values);

        protected virtual Figure ValidateAfterInitialize() => this;
    }
}
