using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Circle : BaseShape
    {
        private const int defaultDegree = 0;
        public decimal R { get; set; }
        public decimal D { get => decimal.Multiply(2, R); }


        public Circle(string r) : base(EnumMode.Normal, defaultDegree)
        {
            R = decimal.Parse(r);
        }

        public override string Area()
        {
            decimal v = decimal.Multiply(new decimal(Math.PI), decimal.Multiply(R, R));
            return $"{v}";
        }
    }
}
