namespace Models
{
    using Models.Enums;
    public abstract class BaseShape : IShape
    {
        protected EnumMode Mode { get; set; }

        private int _totalCornerDegreeInShape { get; set; }
        public int TotalCornerDegreeInShape { get => ((int)this.Mode) * _totalCornerDegreeInShape; }

        protected BaseShape(EnumMode mode, int totalDegreee)
        {
            Mode = mode;
            _totalCornerDegreeInShape = totalDegreee;
        }

        public abstract string Area();

        public override string? ToString()
        {
            return $"Area of {this.GetType().Name} is {this.Area()}";
        }
    }
}
