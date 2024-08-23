using MathFigure2;
using System;
using Xunit;

namespace TestsMathFigure2
{
    public class UnitTestCircle
    {
        [Fact]
        public void CreateCircle_WithoutParamets_IsIncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure), new CircleFactory().Create());
        }

        [Fact]
        public void CreateCircle_NegativeParametrs_IsIncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure), new CircleFactory().Create(-1));
        }

        [Fact]
        public void Area_CircleRadius0_0()
        {
            var circle = new CircleFactory().Create(0);
            Assert.Equal(0, circle.Area);
        }

        [Fact]
        public void Area_CircleRadius2_12Dot57()
        {
            var circle = new CircleFactory().Create(2);
            Assert.Equal(12.57, Math.Round(circle.Area, 2));
        }
    }
}
