using System.IO;

namespace LayoutConstantsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 10;

            var thicknesses = new Thickness[]
            {
                #region Padding

                // Uniform
                new Thickness("Padding Uniform x0.", "P0", value * 0),
                new Thickness("Padding Uniform x1.", "P" , value * 1),
                new Thickness("Padding Uniform x1.", "P1", value * 1),
                new Thickness("Padding Uniform x2.", "P2", value * 2),
                new Thickness("Padding Uniform x3.", "P3", value * 3),
                new Thickness("Padding Uniform x4.", "P4", value * 4),
                new Thickness("Padding Uniform x5.", "P5", value * 5),

                // Left
                new Thickness("Padding Left x0.", "Pl0", value * 0, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x1.", "Pl" , value * 1, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x1.", "Pl1", value * 1, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x2.", "Pl2", value * 2, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x3.", "Pl3", value * 3, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x4.", "Pl4", value * 4, 0.0, 0.0, 0.0),
                new Thickness("Padding Left x5.", "Pl5", value * 5, 0.0, 0.0, 0.0),

                // Left (Right in RTL)
                new Thickness("Padding Left x0 (Right in RTL).", "Ps0", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 0} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 0} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Left x1 (Right in RTL).", "Ps",  left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 1} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 1} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Left x1 (Right in RTL).", "Ps1", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 1} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 1} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Left x2 (Right in RTL).", "Ps2", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 2} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 2} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Left x3 (Right in RTL).", "Ps3", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 3} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 3} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Left x4 (Right in RTL).", "Ps4", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 4} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 4} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Left x5 (Right in RTL).", "Ps5", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 5} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 5} : {0.0}", bottom: $"{0.0}"),

                // Top
                new Thickness("Padding Top x0.", "Pt0", 0.0, value * 0, 0.0, 0.0),
                new Thickness("Padding Top x1.", "Pt" , 0.0, value * 1, 0.0, 0.0),
                new Thickness("Padding Top x1.", "Pt1", 0.0, value * 1, 0.0, 0.0),
                new Thickness("Padding Top x2.", "Pt2", 0.0, value * 2, 0.0, 0.0),
                new Thickness("Padding Top x3.", "Pt3", 0.0, value * 3, 0.0, 0.0),
                new Thickness("Padding Top x4.", "Pt4", 0.0, value * 4, 0.0, 0.0),
                new Thickness("Padding Top x5.", "Pt5", 0.0, value * 5, 0.0, 0.0),

                // Right
                new Thickness("Padding Right x0.", "Pr0", 0.0, 0.0, value * 0, 0.0),
                new Thickness("Padding Right x1.", "Pr" , 0.0, 0.0, value * 1, 0.0),
                new Thickness("Padding Right x1.", "Pr1", 0.0, 0.0, value * 1, 0.0),
                new Thickness("Padding Right x2.", "Pr2", 0.0, 0.0, value * 2, 0.0),
                new Thickness("Padding Right x3.", "Pr3", 0.0, 0.0, value * 3, 0.0),
                new Thickness("Padding Right x4.", "Pr4", 0.0, 0.0, value * 4, 0.0),
                new Thickness("Padding Right x5.", "Pr5", 0.0, 0.0, value * 5, 0.0),

                // Right (Left in RTL)
                new Thickness("Padding Right x0 (Left in RTL).", "Pe0", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 0} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 0} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Right x1 (Left in RTL).", "Pe",  left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 1} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 1} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Right x1 (Left in RTL).", "Pe1", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 1} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 1} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Right x2 (Left in RTL).", "Pe2", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 2} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 2} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Right x3 (Left in RTL).", "Pe3", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 3} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 3} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Right x4 (Left in RTL).", "Pe4", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 4} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 4} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Padding Right x5 (Left in RTL).", "Pe5", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 5} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 5} : {0.0}", bottom: $"{0.0}"),

                // Bottom
                new Thickness("Padding Bottom x0.", "Pb0", 0.0, 0.0, 0.0, value * 0),
                new Thickness("Padding Bottom x1.", "Pb" , 0.0, 0.0, 0.0, value * 1),
                new Thickness("Padding Bottom x1.", "Pb1", 0.0, 0.0, 0.0, value * 1),
                new Thickness("Padding Bottom x2.", "Pb2", 0.0, 0.0, 0.0, value * 2),
                new Thickness("Padding Bottom x3.", "Pb3", 0.0, 0.0, 0.0, value * 3),
                new Thickness("Padding Bottom x4.", "Pb4", 0.0, 0.0, 0.0, value * 4),
                new Thickness("Padding Bottom x5.", "Pb5", 0.0, 0.0, 0.0, value * 5),

                // Top, Bottom (Y)
                new Thickness("Padding Top-Bottom x0.", "Py0", 0.0, value * 0, 0.0, value * 0),
                new Thickness("Padding Top-Bottom x1.", "Py" , 0.0, value * 1, 0.0, value * 1),
                new Thickness("Padding Top-Bottom x1.", "Py1", 0.0, value * 1, 0.0, value * 1),
                new Thickness("Padding Top-Bottom x2.", "Py2", 0.0, value * 2, 0.0, value * 2),
                new Thickness("Padding Top-Bottom x3.", "Py3", 0.0, value * 3, 0.0, value * 3),
                new Thickness("Padding Top-Bottom x4.", "Py4", 0.0, value * 4, 0.0, value * 4),
                new Thickness("Padding Top-Bottom x5.", "Py5", 0.0, value * 5, 0.0, value * 5),

                // Left, Right (X)
                new Thickness("Padding Left-Right x0.", "Px0", value * 0, 0.0, value * 0, 0.0),
                new Thickness("Padding Left-Right x1.", "Px" , value * 1, 0.0, value * 1, 0.0),
                new Thickness("Padding Left-Right x1.", "Px1", value * 1, 0.0, value * 1, 0.0),
                new Thickness("Padding Left-Right x2.", "Px2", value * 2, 0.0, value * 2, 0.0),
                new Thickness("Padding Left-Right x3.", "Px3", value * 3, 0.0, value * 3, 0.0),
                new Thickness("Padding Left-Right x4.", "Px4", value * 4, 0.0, value * 4, 0.0),
                new Thickness("Padding Left-Right x5.", "Px5", value * 5, 0.0, value * 5, 0.0),

                // Left, Top, Right
                new Thickness("Padding Left-Top-Right x0.", "Pltr0", value * 0, value * 0, value * 0, 0.0),
                new Thickness("Padding Left-Top-Right x1.", "Pltr" , value * 1, value * 1, value * 1, 0.0),
                new Thickness("Padding Left-Top-Right x1.", "Pltr1", value * 1, value * 1, value * 1, 0.0),
                new Thickness("Padding Left-Top-Right x2.", "Pltr2", value * 2, value * 2, value * 2, 0.0),
                new Thickness("Padding Left-Top-Right x3.", "Pltr3", value * 3, value * 3, value * 3, 0.0),
                new Thickness("Padding Left-Top-Right x4.", "Pltr4", value * 4, value * 4, value * 4, 0.0),
                new Thickness("Padding Left-Top-Right x5.", "Pltr5", value * 5, value * 5, value * 5, 0.0),

                // Left, Right, Bottom
                new Thickness("Padding Left-Right-Bottom x0.", "Plrb0", value * 0, 0.0, value * 0, value * 0),
                new Thickness("Padding Left-Right-Bottom x1.", "Plrb1", value * 1, 0.0, value * 1, value * 1),
                new Thickness("Padding Left-Right-Bottom x2.", "Plrb2", value * 2, 0.0, value * 2, value * 2),
                new Thickness("Padding Left-Right-Bottom x3.", "Plrb3", value * 3, 0.0, value * 3, value * 3),
                new Thickness("Padding Left-Right-Bottom x4.", "Plrb4", value * 4, 0.0, value * 4, value * 4),
                new Thickness("Padding Left-Right-Bottom x5.", "Plrb5", value * 5, 0.0, value * 5, value * 5),

                #endregion

                #region Margin

                // Uniform
                new Thickness("Margin Uniform x0.", "M0", value * 0),
                new Thickness("Margin Uniform x1.", "M" , value * 1),
                new Thickness("Margin Uniform x1.", "M1", value * 1),
                new Thickness("Margin Uniform x2.", "M2", value * 2),
                new Thickness("Margin Uniform x3.", "M3", value * 3),
                new Thickness("Margin Uniform x4.", "M4", value * 4),
                new Thickness("Margin Uniform x5.", "M5", value * 5),

                // Left
                new Thickness("Margin Left x0.", "Ml0", value * 0, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x1.", "Ml" , value * 1, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x1.", "Ml1", value * 1, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x2.", "Ml2", value * 2, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x3.", "Ml3", value * 3, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x4.", "Ml4", value * 4, 0.0, 0.0, 0.0),
                new Thickness("Margin Left x5.", "Ml5", value * 5, 0.0, 0.0, 0.0),

                // Left (Right in RTL)
                new Thickness("Margin Left x0 (Right in RTL).", "Ms0", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 0} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 0} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Left x1 (Right in RTL).", "Ms",  left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 1} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 1} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Left x1 (Right in RTL).", "Ms1", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 1} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 1} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Left x2 (Right in RTL).", "Ms2", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 2} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 2} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Left x3 (Right in RTL).", "Ms3", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 3} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 3} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Left x4 (Right in RTL).", "Ms4", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 4} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 4} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Left x5 (Right in RTL).", "Ms5", left: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 5} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 5} : {0.0}", bottom: $"{0.0}"),

                // Top
                new Thickness("Margin Top x0.", "Mt0", 0.0, value * 0, 0.0, 0.0),
                new Thickness("Margin Top x1.", "Mt" , 0.0, value * 1, 0.0, 0.0),
                new Thickness("Margin Top x1.", "Mt1", 0.0, value * 1, 0.0, 0.0),
                new Thickness("Margin Top x2.", "Mt2", 0.0, value * 2, 0.0, 0.0),
                new Thickness("Margin Top x3.", "Mt3", 0.0, value * 3, 0.0, 0.0),
                new Thickness("Margin Top x4.", "Mt4", 0.0, value * 4, 0.0, 0.0),
                new Thickness("Margin Top x5.", "Mt5", 0.0, value * 5, 0.0, 0.0),

                // Right
                new Thickness("Margin Right x0.", "Mr0", 0.0, 0.0, value * 0, 0.0),
                new Thickness("Margin Right x1.", "Mr" , 0.0, 0.0, value * 1, 0.0),
                new Thickness("Margin Right x1.", "Mr1", 0.0, 0.0, value * 1, 0.0),
                new Thickness("Margin Right x2.", "Mr2", 0.0, 0.0, value * 2, 0.0),
                new Thickness("Margin Right x3.", "Mr3", 0.0, 0.0, value * 3, 0.0),
                new Thickness("Margin Right x4.", "Mr4", 0.0, 0.0, value * 4, 0.0),
                new Thickness("Margin Right x5.", "Mr5", 0.0, 0.0, value * 5, 0.0),

                // Right (Left in RTL)
                new Thickness("Margin Right x0 (Left in RTL).", "Me0", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 0} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 0} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Right x1 (Left in RTL).", "Me",  left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 1} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 1} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Right x1 (Left in RTL).", "Me1", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 1} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 1} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Right x2 (Left in RTL).", "Me2", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 2} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 2} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Right x3 (Left in RTL).", "Me3", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 3} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 3} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Right x4 (Left in RTL).", "Me4", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 4} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 4} : {0.0}", bottom: $"{0.0}"),
                new Thickness("Margin Right x5 (Left in RTL).", "Me5", left: $"Device.FlowDirection == FlowDirection.RightToLeft ? {value * 5} : {0.0}", top: $"{0.0}", right: $"Device.FlowDirection == FlowDirection.LeftToRight ? {value * 5} : {0.0}", bottom: $"{0.0}"),

                // Bottom
                new Thickness("Margin Bottom x0.", "Mb0", 0.0, 0.0, 0.0, value * 0),
                new Thickness("Margin Bottom x1.", "Mb" , 0.0, 0.0, 0.0, value * 1),
                new Thickness("Margin Bottom x1.", "Mb1", 0.0, 0.0, 0.0, value * 1),
                new Thickness("Margin Bottom x2.", "Mb2", 0.0, 0.0, 0.0, value * 2),
                new Thickness("Margin Bottom x3.", "Mb3", 0.0, 0.0, 0.0, value * 3),
                new Thickness("Margin Bottom x4.", "Mb4", 0.0, 0.0, 0.0, value * 4),
                new Thickness("Margin Bottom x5.", "Mb5", 0.0, 0.0, 0.0, value * 5),

                // Top, Bottom (Y)
                new Thickness("Margin Top-Bottom x0.", "My0", 0.0, value * 0, 0.0, value * 0),
                new Thickness("Margin Top-Bottom x1.", "My" , 0.0, value * 1, 0.0, value * 1),
                new Thickness("Margin Top-Bottom x1.", "My1", 0.0, value * 1, 0.0, value * 1),
                new Thickness("Margin Top-Bottom x2.", "My2", 0.0, value * 2, 0.0, value * 2),
                new Thickness("Margin Top-Bottom x3.", "My3", 0.0, value * 3, 0.0, value * 3),
                new Thickness("Margin Top-Bottom x4.", "My4", 0.0, value * 4, 0.0, value * 4),
                new Thickness("Margin Top-Bottom x5.", "My5", 0.0, value * 5, 0.0, value * 5),

                // Left, Right (X)
                new Thickness("Margin Left-Right x0.", "Mx0", value * 0, 0.0, value * 0, 0.0),
                new Thickness("Margin Left-Right x1.", "Mx" , value * 1, 0.0, value * 1, 0.0),
                new Thickness("Margin Left-Right x1.", "Mx1", value * 1, 0.0, value * 1, 0.0),
                new Thickness("Margin Left-Right x2.", "Mx2", value * 2, 0.0, value * 2, 0.0),
                new Thickness("Margin Left-Right x3.", "Mx3", value * 3, 0.0, value * 3, 0.0),
                new Thickness("Margin Left-Right x4.", "Mx4", value * 4, 0.0, value * 4, 0.0),
                new Thickness("Margin Left-Right x5.", "Mx5", value * 5, 0.0, value * 5, 0.0),

                // Left, Top, Right
                new Thickness("Margin Left-Top-Right x0.", "Mltr0", value * 0, value * 0, value * 0, 0.0),
                new Thickness("Margin Left-Top-Right x1.", "Mltr" , value * 1, value * 1, value * 1, 0.0),
                new Thickness("Margin Left-Top-Right x1.", "Mltr1", value * 1, value * 1, value * 1, 0.0),
                new Thickness("Margin Left-Top-Right x2.", "Mltr2", value * 2, value * 2, value * 2, 0.0),
                new Thickness("Margin Left-Top-Right x3.", "Mltr3", value * 3, value * 3, value * 3, 0.0),
                new Thickness("Margin Left-Top-Right x4.", "Mltr4", value * 4, value * 4, value * 4, 0.0),
                new Thickness("Margin Left-Top-Right x5.", "Mltr5", value * 5, value * 5, value * 5, 0.0),

                // Left, Right, Bottom
                new Thickness("Margin Left-Right-Bottom x0.", "Mlrb0", value * 0, 0.0, value * 0, value * 0),
                new Thickness("Margin Left-Right-Bottom x1.", "Mlrb" , value * 1, 0.0, value * 1, value * 1),
                new Thickness("Margin Left-Right-Bottom x1.", "Mlrb1", value * 1, 0.0, value * 1, value * 1),
                new Thickness("Margin Left-Right-Bottom x2.", "Mlrb2", value * 2, 0.0, value * 2, value * 2),
                new Thickness("Margin Left-Right-Bottom x3.", "Mlrb3", value * 3, 0.0, value * 3, value * 3),
                new Thickness("Margin Left-Right-Bottom x4.", "Mlrb4", value * 4, 0.0, value * 4, value * 4),
                new Thickness("Margin Left-Right-Bottom x5.", "Mlrb5", value * 5, 0.0, value * 5, value * 5),

                #endregion
            };

            var doubles = new Double[]
            {
                new Double("Spacing x0", "S0", value * 0),
                new Double("Spacing x1", "S" , value * 1),
                new Double("Spacing x1", "S1", value * 1),
                new Double("Spacing x2", "S2", value * 2),
                new Double("Spacing x3", "S3", value * 3),
                new Double("Spacing x4", "S4", value * 4),
                new Double("Spacing x5", "S5", value * 5),
            };

            File.WriteAllText(
                Path.Combine("..", "..", "..", "LayoutConstants.Generated.cs"), 
                LayoutGenerator.Generate(thicknesses, doubles));

            File.WriteAllText(
                Path.Combine("..", "..", "..", "LayoutConstantsConverter.Generated.cs"),
                ConverterGenerator.Generate(thicknesses, doubles));
        }
    }
}
