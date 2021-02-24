using System;
using System.IO;
using System.Linq;

namespace LayoutConstantsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 10;

            var paddings = new IThickness[]
            {
                // Uniform
                new Thickness("Padding Uniform x1.", "P" , value * 1),
                new Thickness("Padding Uniform x1.", "P1", value * 1),
                new Thickness("Padding Uniform x2.", "P2", value * 2),
                new Thickness("Padding Uniform x3.", "P3", value * 3),
                new Thickness("Padding Uniform x4.", "P4", value * 4),
                new Thickness("Padding Uniform x5.", "P5", value * 5),

                // Left
                new Thickness("Padding Left x1.", "Pl" , value * 1, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x1.", "Pl1", value * 1, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x2.", "Pl2", value * 2, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x3.", "Pl3", value * 3, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x4.", "Pl4", value * 4, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x5.", "Pl5", value * 5, 0.0, 0.0, 0.0),

                // Top
                new Thickness("Padding Top x1.", "Pt" , 0.0, value * 1, 0.0, 0.0),
                new Thickness("Padding Top x1.", "Pt1", 0.0, value * 1, 0.0, 0.0),
                new Thickness("Padding Top x2.", "Pt2", 0.0, value * 2, 0.0, 0.0),
                new Thickness("Padding Top x3.", "Pt3", 0.0, value * 3, 0.0, 0.0),
                new Thickness("Padding Top x4.", "Pt4", 0.0, value * 4, 0.0, 0.0),
                new Thickness("Padding Top x5.", "Pt5", 0.0, value * 5, 0.0, 0.0),

                // Right
                new Thickness("Padding Right x1.", "Pr" , 0.0, 0.0, value * 1, 0.0),
                new Thickness("Padding Right x1.", "Pr1", 0.0, 0.0, value * 1, 0.0),
                new Thickness("Padding Right x2.", "Pr2", 0.0, 0.0, value * 2, 0.0),
                new Thickness("Padding Right x3.", "Pr3", 0.0, 0.0, value * 3, 0.0),
                new Thickness("Padding Right x4.", "Pr4", 0.0, 0.0, value * 4, 0.0),
                new Thickness("Padding Right x5.", "Pr5", 0.0, 0.0, value * 5, 0.0),

                // Bottom
                new Thickness("Padding Bottom x1.", "Pb" , 0.0, 0.0, 0.0, value * 1),
                new Thickness("Padding Bottom x1.", "Pb1", 0.0, 0.0, 0.0, value * 1),
                new Thickness("Padding Bottom x2.", "Pb2", 0.0, 0.0, 0.0, value * 2),
                new Thickness("Padding Bottom x3.", "Pb3", 0.0, 0.0, 0.0, value * 3),
                new Thickness("Padding Bottom x4.", "Pb4", 0.0, 0.0, 0.0, value * 4),
                new Thickness("Padding Bottom x5.", "Pb5", 0.0, 0.0, 0.0, value * 5),

                // Top, Bottom (Y)
                new Thickness("Padding Top-Bottom x1.", "Py" , 0.0, value * 1, 0.0, value * 1),
                new Thickness("Padding Top-Bottom x1.", "Py1", 0.0, value * 1, 0.0, value * 1),
                new Thickness("Padding Top-Bottom x2.", "Py2", 0.0, value * 2, 0.0, value * 2),
                new Thickness("Padding Top-Bottom x3.", "Py3", 0.0, value * 3, 0.0, value * 3),
                new Thickness("Padding Top-Bottom x4.", "Py4", 0.0, value * 4, 0.0, value * 4),
                new Thickness("Padding Top-Bottom x5.", "Py5", 0.0, value * 5, 0.0, value * 5),

                // Left, Right (X)
                new Thickness("Padding Left-Right x1.", "Px" , 0.0, value * 1, 0.0, value * 1),
                new Thickness("Padding Left-Right x1.", "Px1", 0.0, value * 1, 0.0, value * 1),
                new Thickness("Padding Left-Right x2.", "Px2", 0.0, value * 2, 0.0, value * 2),
                new Thickness("Padding Left-Right x3.", "Px3", 0.0, value * 3, 0.0, value * 3),
                new Thickness("Padding Left-Right x4.", "Px4", 0.0, value * 4, 0.0, value * 4),
                new Thickness("Padding Left-Right x5.", "Px5", 0.0, value * 5, 0.0, value * 5),
            };

            var margins = new IThickness[]
            {
                // Uniform
                new Thickness("Margin Uniform x1.", "M" , value * 1),
                new Thickness("Margin Uniform x1.", "M1", value * 1),
                new Thickness("Margin Uniform x2.", "M2", value * 2),
                new Thickness("Margin Uniform x3.", "M3", value * 3),
                new Thickness("Margin Uniform x4.", "M4", value * 4),
                new Thickness("Margin Uniform x5.", "M5", value * 5),

                // Left
                new Thickness("Margin Left x1.", "Ml" , value * 1, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x1.", "Ml1", value * 1, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x2.", "Ml2", value * 2, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x3.", "Ml3", value * 3, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x4.", "Ml4", value * 4, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x5.", "Ml5", value * 5, 0.0, 0.0, 0.0),

                // Top
                new Thickness("Margin Top x1.", "Mt" , 0.0, value * 1, 0.0, 0.0),
                new Thickness("Margin Top x1.", "Mt1", 0.0, value * 1, 0.0, 0.0),
                new Thickness("Margin Top x2.", "Mt2", 0.0, value * 2, 0.0, 0.0),
                new Thickness("Margin Top x3.", "Mt3", 0.0, value * 3, 0.0, 0.0),
                new Thickness("Margin Top x4.", "Mt4", 0.0, value * 4, 0.0, 0.0),
                new Thickness("Margin Top x5.", "Mt5", 0.0, value * 5, 0.0, 0.0),

                // Right
                new Thickness("Margin Right x1.", "Mr" , 0.0, 0.0, value * 1, 0.0),
                new Thickness("Margin Right x1.", "Mr1", 0.0, 0.0, value * 1, 0.0),
                new Thickness("Margin Right x2.", "Mr2", 0.0, 0.0, value * 2, 0.0),
                new Thickness("Margin Right x3.", "Mr3", 0.0, 0.0, value * 3, 0.0),
                new Thickness("Margin Right x4.", "Mr4", 0.0, 0.0, value * 4, 0.0),
                new Thickness("Margin Right x5.", "Mr5", 0.0, 0.0, value * 5, 0.0),

                // Bottom
                new Thickness("Margin Bottom x1.", "Mb" , 0.0, 0.0, 0.0, value * 1),
                new Thickness("Margin Bottom x1.", "Mb1", 0.0, 0.0, 0.0, value * 1),
                new Thickness("Margin Bottom x2.", "Mb2", 0.0, 0.0, 0.0, value * 2),
                new Thickness("Margin Bottom x3.", "Mb3", 0.0, 0.0, 0.0, value * 3),
                new Thickness("Margin Bottom x4.", "Mb4", 0.0, 0.0, 0.0, value * 4),
                new Thickness("Margin Bottom x5.", "Mb5", 0.0, 0.0, 0.0, value * 5),

                // Top, Bottom (Y)
                new Thickness("Margin Top-Bottom x1.", "My" , 0.0, value * 1, 0.0, value * 1),
                new Thickness("Margin Top-Bottom x1.", "My1", 0.0, value * 1, 0.0, value * 1),
                new Thickness("Margin Top-Bottom x2.", "My2", 0.0, value * 2, 0.0, value * 2),
                new Thickness("Margin Top-Bottom x3.", "My3", 0.0, value * 3, 0.0, value * 3),
                new Thickness("Margin Top-Bottom x4.", "My4", 0.0, value * 4, 0.0, value * 4),
                new Thickness("Margin Top-Bottom x5.", "My5", 0.0, value * 5, 0.0, value * 5),

                // Left, Right (X)
                new Thickness("Margin Left-Right x1.", "Mx" , 0.0, value * 1, 0.0, value * 1),
                new Thickness("Margin Left-Right x1.", "Mx1", 0.0, value * 1, 0.0, value * 1),
                new Thickness("Margin Left-Right x2.", "Mx2", 0.0, value * 2, 0.0, value * 2),
                new Thickness("Margin Left-Right x3.", "Mx3", 0.0, value * 3, 0.0, value * 3),
                new Thickness("Margin Left-Right x4.", "Mx4", 0.0, value * 4, 0.0, value * 4),
                new Thickness("Margin Left-Right x5.", "Mx5", 0.0, value * 5, 0.0, value * 5),
            };

            File.WriteAllText("LayoutConstants.cs", LayoutGenerator.Generate(paddings.Concat(margins)));
        }
    }
}
