namespace Models
{
    using Models.Enums;
    public abstract class BaseShape : IShape
    {
        protected EnumMode Mode { get; set; }

        private int _totalCorners { get; set; }
        public int TotalCorners { get => ((int)this.Mode) * _totalCorners; }

        protected BaseShape(EnumMode mode, int totalDegreee)
        {
            Mode = mode;
            _totalCorners = totalDegreee;
        }

        public abstract string Area();

        public override string? ToString()
        {
            return $"Area of {this.GetType().Name} is {this.Area()}";
        }
    }
}
