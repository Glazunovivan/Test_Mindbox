using MathFigure;
using System;
using Xunit;

namespace TestMathFigure
{
    public class UnitTestCircle
    {
        [Fact]
        public void CircleNegativeParametr_Exception()
        {
            var figure = FigureCreator.Create<Circle>(-5);
            Assert.IsType(typeof(IncorrectFigure), figure);
        }

        [Fact]
        public void Area_CircleRadius0_0()
        {
            var circle = FigureCreator.Create<Circle>(0);
            Assert.Equal(0, circle.Area);
        }

        [Fact]
        public void Area_CircleRadius2_12Dot57()
        {
            var circle = FigureCreator.Create<Circle>(2);
            Assert.Equal(12.57, Math.Round(circle.Area, 2));
        }

        [Fact]
        public void Area_CircleWithoutParametrs_IsIncorrectFigure()
        {
            var circle = FigureCreator.Create<Circle>();
            Assert.Equal(-1, circle.Area);
            Assert.IsType(typeof(IncorrectFigure),circle);
        }
    }
}
