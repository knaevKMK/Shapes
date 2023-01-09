using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Rectangle : BaseShape
    {
        public decimal A { get; set; }
        public decimal B { get; set; }

        public Rectangle(string a, string b)
        {
            this.A = decimal.Parse(a);
            this.B = decimal.Parse(b);

        }
        public override int TotalCornerDegreeInShape() => 360;

        public override string Area()
        {
            decimal v = decimal.Multiply(B, A);
            return $"{v}";
        }

    }
}
