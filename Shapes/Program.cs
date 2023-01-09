using Models;

List<IShape> shapes = new()
{
    new Triangle("3","4","6"),
    new Rectangle("3","6"),
    new Square("4"),
};

// add new shapes

shapes.ForEach(shape => Console.WriteLine(shape.ToString()));
