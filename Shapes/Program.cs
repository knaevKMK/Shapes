using Models;
using Models.Enums;

List<IShape> shapes = new()
{
    new Triangle("3","4","6",  EnumMode.Normal),
    new Rectangle("3","6", EnumMode.Happy),
    new Square("4",EnumMode.SuperHappy),
    new Circle("4"),
};

// add new shapes

shapes.ForEach(shape => Console.WriteLine(shape.ToString()));
var sumDegree = shapes.Sum(x => x.TotalCornerDegreeInShape);
Console.WriteLine($"Sum of all {shapes.Count} corners is {sumDegree} degrees");