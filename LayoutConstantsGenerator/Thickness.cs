namespace LayoutConstantsGenerator
{
    public class Thickness : IThickness
    {
        public string Comment { get; }
        public string Name { get; }
        public string Left { get; }
        public string Top { get; }
        public string Right { get; }
        public string Bottom { get; }

        public Thickness(
            string comment,
            string name,
            string left,
            string top,
            string right,
            string bottom)
        {
            Comment = comment;
            Name = name;
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public Thickness(
            string comment,
            string name,
            double left,
            double top,
            double right,
            double bottom)
        {
            Comment = comment;
            Name = name;
            Left = left.ToString();
            Top = top.ToString();
            Right = right.ToString();
            Bottom = bottom.ToString();
        }

        public Thickness(
            string comment,
            string name,
            double value)
        {
            Comment = comment;
            Name = name;
            Left = value.ToString();
            Top = value.ToString();
            Right = value.ToString();
            Bottom = value.ToString();
        }
    }
}
