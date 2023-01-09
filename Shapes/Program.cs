using Models;
using Models.Enums;

List<IShape> shapes = new()
{
    new Triangle("3","4","6",  EnumMode.Normal),
    new Rectangle("3","6", EnumMode.Happy),
    new Square("4",EnumMode.SuperHappy),
    new Circle("4",EnumMode.Happy),
    new Circle("5",EnumMode.SuperHappy),
};

// add new shapes

shapes.ForEach(shape => Console.WriteLine(shape.ToString()));
var sumDegree = shapes.Sum(x => x.TotalCorners);
Console.WriteLine($"All {shapes.Count} shapes there are {sumDegree} corners");