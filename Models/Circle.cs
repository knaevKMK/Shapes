using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Circle : BaseShape
    {
        public decimal R { get; set; }

        public Circle(string r)
        {
            R = decimal.Parse(r);

        }

        public decimal D { get => decimal.Multiply(2, R); }
        public override string Area()
        {
            decimal v = decimal.Multiply(new decimal(Math.PI), decimal.Multiply(R,R));
            return $"{v}";
        }
    }
}
