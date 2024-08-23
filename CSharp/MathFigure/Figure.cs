﻿namespace MathFigure
{
    /// <summary>
    /// Базовый класс Фигура
    /// </summary>
    public abstract class Figure : IFigure
    {
        protected double? _area;

        public double Area  => (double)(_area ?? (_area = GetArea()));
       
        internal protected abstract void Initialize(params double[] values);

        /// <summary>
        /// Проверка входных параметров для создания фигуры
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        internal protected bool ValidateBeforeCreate(params double[] values)
        {
            if (!values.Any() || values.Any(x => x < 0))
            {
                return false;
            }
            return true;
        }
        
        /// <summary>
        /// Проверка на корректность созданной фигуры
        /// </summary>
        internal protected virtual Figure ValidateCreatingFigure()
        {
            return this;
        }

        internal protected abstract double GetArea();
    }
}
