namespace LayoutConstantsGenerator
{
    public interface IThickness
    {
        string Comment { get; }

        string Name { get; }

        double Left { get; }

        double Top { get; }

        double Right { get; }

        double Down { get; }
    }
}
