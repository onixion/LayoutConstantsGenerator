namespace LayoutConstantsGenerator
{
    public class Double
    {
        public string Comment { get; }
        public string Name { get; }
        public string Value { get; }

        public Double(
            string comment,
            string name,
            string value)
        {
            Comment = comment;
            Name = name;
            Value = value;
        }

        public Double(
            string comment,
            string name,
            double value)
        {
            Comment = comment;
            Name = name;
            Value = value.ToString();
        }
    }
}
