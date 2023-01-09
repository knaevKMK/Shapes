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
        private const int totalCorners = 0;
        public decimal R { get; set; }
        public decimal D { get => decimal.Multiply(2, R); }


        public Circle(string r, EnumMode mode) : base(mode, GetAllCorners(mode))
        {
            R = decimal.Parse(r);
        }

        public override string Area()
        {
            decimal v = decimal.Multiply(new decimal(Math.PI), decimal.Multiply(R, R));
            return $"{v}";
        }
        private static int GetAllCorners(EnumMode mode)
        {
            var c = (int)mode;
            switch (c)
            {
                case 2:
                case 3: return c * c + 1;

                default: return totalCorners;
            }
        }
    }
}
