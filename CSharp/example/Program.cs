using MathFigure;

var figure1 = FigureCreator.Create<Circle>(5);
var figure2 = FigureCreator.Create<Triangle>(3,4,5);

Console.WriteLine(figure1.Area);
Console.WriteLine(figure2.Area);
if (figure2 is Triangle triangle)
{
    Console.WriteLine(triangle.IsRight());
}

var figure3 = FigureCreator.Create<Triangle>(3,5,7) as Triangle;
Console.WriteLine(figure3?.Area);
Console.WriteLine(figure3?.IsRight());

IFigure anyFigure = FigureCreator.Create<Circle>();
anyFigure = FigureCreator.Create<Triangle>(3,5,6);
Console.WriteLine(anyFigure.Area);
if (anyFigure is Triangle triangleIFigure)
{
    Console.WriteLine(triangleIFigure.IsRight());
}

var figure4 = new MathFigure2.CircleFactory().Create(-1);
MathFigure2.IArea anyFigure2 = new MathFigure2.CircleFactory().Create(2);

Console.WriteLine(figure4.Area);
Console.WriteLine(anyFigure2.Area);
