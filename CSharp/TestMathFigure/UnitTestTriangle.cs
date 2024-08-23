using MathFigure;
using System;
using Xunit;

namespace TestMathFigure
{
    public class UnitTestTriangle
    {
        [Fact]
        public void TriangleCreateNegativeAnyParametr_IncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure),FigureCreator.Create<Triangle>(0, 1, -5));
        }

        [Fact]
        public void NegativeAllParametr_IncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure), FigureCreator.Create<Triangle>(-4, -1, -5));
        }

        [Fact]
        public void Triangle235_IncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure),FigureCreator.Create<Triangle>(2, 3, 5));
        }

        [Fact]
        public void Triangle000_IncorrectFigure()
        {
            var triangle = FigureCreator.Create<Triangle>(0, 0, 0);
            Assert.Equal(0, triangle.Area);
        }

        [Fact]
        public void Area_Triangle345_Equal_6()
        {
            var triangle = FigureCreator.Create<Triangle>(3, 4, 5);
            Assert.Equal(6, triangle.Area);
        }

        [Fact]
        public void IsRight_Triangle345_True()
        {
            var triangle = FigureCreator.Create<Triangle>(3, 4, 5) as Triangle;
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void IsRight_Triangle543_True()
        {
            var triangle = FigureCreator.Create<Triangle>(5, 4, 3) as Triangle;
            Assert.True(triangle.IsRight());
        }

        public void IsRight_Triangle453_True()
        {
            var triangle = FigureCreator.Create<Triangle>(5, 4, 3) as Triangle;
            Assert.True(triangle.IsRight());
        }


        [Fact]
        public void IsRight_Triangle334_False()
        {
            var triangle = FigureCreator.Create<Triangle>(3, 3, 4) as Triangle;
            Assert.False(triangle.IsRight());
        }

        [Fact]
        public void TriangleWithoutParametrs_IsIncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure), FigureCreator.Create<Triangle>());
        }

        [Fact]
        public void Triangle301_IsIncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure), FigureCreator.Create<Triangle>(3, 0, 1));
        }

        [Fact]
        public void Triangle0_Area_0()
        {
            var figure = FigureCreator.Create<Triangle>(0);
            Assert.Equal(0, figure.Area);
        }

        [Fact]
        public void TriangleWithNullParametrs_IsIncorrectFigure()
        {
            var triangle = FigureCreator.Create<Triangle>(null);
            Assert.IsType(typeof(IncorrectFigure), triangle);
        }

        [Fact]
        public void TriangleWith2Parametrs_IsIncorrectFigure()
        {
            var triangle = FigureCreator.Create<Triangle>(1,2);
            Assert.IsType(typeof(IncorrectFigure), triangle);
        }

        [Fact]
        public void TriangleWithOnlyParametr_ABC()
        {
            var triangle = FigureCreator.Create<Triangle>(1) as Triangle;
            Assert.Equal(1, triangle.A);
            Assert.Equal(1, triangle.B);
            Assert.Equal(1, triangle.C);
        }
    }
}
