namespace Models;
public interface IShape
{
    public string Area();
    public int TotalCorners { get; }
}
