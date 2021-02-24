namespace LayoutConstantsGenerator
{
    public class Thickness : IThickness
    {
        public string Comment { get; }
        public string Name { get; }
        public double Left { get; }
        public double Top { get; }
        public double Right { get; }
        public double Down { get; }

        public Thickness(
            string comment,
            string name,
            double left,
            double top,
            double right,
            double down)
        {
            Comment = comment;
            Name = name;
            Left = left;
            Top = top;
            Right = right;
            Down = down;
        }

        public Thickness(
            string comment,
            string name,
            double value)
        {
            Comment = comment;
            Name = name;
            Left = value;
            Top = value;
            Right = value;
            Down = value;
        }
    }
}
