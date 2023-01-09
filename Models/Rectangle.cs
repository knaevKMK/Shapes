using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Rectangle : BaseShape
    {
        private const int defaultDegree = 360;
        public decimal A { get; set; }
        public decimal B { get; set; }

        public Rectangle(string a, string b, EnumMode mode) : base(mode, defaultDegree)
        {
            this.A = decimal.Parse(a);
            this.B = decimal.Parse(b);

        }

        public override string Area()
        {
            decimal v = decimal.Multiply(B, A);
            return $"{v}";
        }

    }
}
