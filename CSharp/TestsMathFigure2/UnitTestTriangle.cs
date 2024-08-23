using MathFigure2;
using System;
using Xunit;

namespace TestsMathFigure2
{
    public class UnitTestTriangle
    {
        [Fact]
        public void TriangleCreateNegativeAnyParametr_IncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure), new TriangleFactory().Create(0, 1, -5));
        }

        [Fact]
        public void NegativeAllParametr_IncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure), new TriangleFactory().Create(-1.5, -11, -5));
        }

        [Fact]
        public void Triangle235_IncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure), new TriangleFactory().Create(2, 3, 5));
        }


        [Fact]
        public void Triangle156_IsIncorrectFigure()
        {
            Assert.IsType(typeof(IncorrectFigure), new TriangleFactory().Create(1, 5, 6));
        }

        [Fact]
        public void Area_Triangle345_Equal_6()
        {
            var triangle = new TriangleFactory().Create(3, 4, 5);
            Assert.Equal(6, triangle.Area);
        }


        [Fact]
        public void Area_Triangle555_Equal_10Dot83()
        {
            var triangle = new TriangleFactory().Create(5, 5, 5);
            Assert.Equal(10.83, Math.Round(triangle.Area,2));
        }

        [Fact]
        public void IsRight_Triangle345_True()
        {
            var triangle = new TriangleFactory().Create(3, 4, 5) as Triangle;
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void IsRight_Triangle543_True()
        {
            var triangle = new TriangleFactory().Create(5, 4, 3) as Triangle;
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void IsRight_Triangle453_True()
        {
            var triangle = new TriangleFactory().Create(4, 5, 3) as Triangle;
            Assert.True(triangle.IsRight());
        }


        [Fact]
        public void IsRight_Triangle334_False()
        {
            var triangle = new TriangleFactory().Create(3, 3, 4) as Triangle;
            Assert.False(triangle.IsRight());
        }

        [Fact]
        public void TriangleWithoutParametrs_IsIncorrectFigure()
        {
            var triangle = new TriangleFactory().Create();
            Assert.IsType(typeof(IncorrectFigure), triangle);
        }

        [Fact]
        public void TriangleWithNullParametrs_IsIncorrectFigure()
        {
            var triangle = new TriangleFactory().Create(null);
            Assert.IsType(typeof(IncorrectFigure), triangle);
        }

        [Fact]
        public void TriangleWith2Parametrs_IsIncorrectFigure()
        {
            var triangle = new TriangleFactory().Create(1,2);
            Assert.IsType(typeof(IncorrectFigure), triangle);
        }

        [Fact]
        public void TriangleWithOnlyParametr_ABC()
        {
            var triangle = new TriangleFactory().Create(1) as Triangle;
            Assert.Equal(1,triangle.A);
            Assert.Equal(1,triangle.B);
            Assert.Equal(1,triangle.C);
        }
    }
}
