
using Models.Enums;

namespace Models
{
    public class Square : BaseShape
    {
        private const int totalCorners = 4;
        public decimal A { get; set; }
        public Square(string a, EnumMode mode) : base(mode, totalCorners)
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
