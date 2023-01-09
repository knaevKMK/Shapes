
using Models.Enums;

namespace Models
{
    public class Square : BaseShape
    {
        private const int defaultDegree = 360;
        public decimal A { get; set; }
        public Square(string a, EnumMode mode) : base(mode, defaultDegree)
        {
            this.A = decimal.Parse(a);

        }

        public override string Area()
        {
            decimal v = decimal.Multiply(A, A);
            return $"{v}";
        }

    }
}
