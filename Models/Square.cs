
namespace Models
{
    public class Square : BaseShape
    {
        public decimal A { get; set; }
        public Square(string a)
        {
            this.A = decimal.Parse(a);

        }
        public override int TotalCornerDegreeInShape() => 360;

        public override string Area()
        {
            decimal v = decimal.Multiply(A, A);
            return $"{v}";
        }

    }
}
