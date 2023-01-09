namespace Models
{
    public sealed class Triangle : BaseShape
    {
        public decimal A { get; set; }
        public decimal B { get; set; }
        public decimal H { get; set; }

        public Triangle(string a, string b, string h)
        {
            this.A = decimal.Parse(a);
            this.B = decimal.Parse(b);
            this.H = decimal.Parse(h);
        }

        public override string Area()
        {
            decimal v = decimal.Multiply(B, H);
            return $"{decimal.Divide(v, 2)}";
        }

    }
}
