using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BaseShape : IShape
    {
        public abstract string Area();
        public abstract int TotalCornerDegreeInShape();

        public override string? ToString()
        {
            return $"Area of {this.GetType().Name} is {this.Area()}";
        }
    }
}
