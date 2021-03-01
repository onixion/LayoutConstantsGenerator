using System;
using System.Collections.Generic;
using System.Text;

namespace LayoutConstantsGenerator
{
    public static class LayoutGenerator
    {
        public static string Generate(IEnumerable<Thickness> thicknesses, IEnumerable<Double> doubles)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"");
            builder.AppendLine($"/// This file was generated at {DateTime.UtcNow.ToLongTimeString()} on the {DateTime.UtcNow.ToLongDateString()} (UTC).");
            builder.AppendLine($"");

            builder.AppendLine($"using Xamarin.Forms;");
            builder.AppendLine($"");
            builder.AppendLine($"namespace TODO");
            builder.AppendLine($"{{");
            builder.AppendLine($"\t /// <summary>");
            builder.AppendLine($"\t /// Layout constants.");
            builder.AppendLine($"\t /// </summary>");
            builder.AppendLine($"\t public static class LayoutConstants");
            builder.AppendLine($"\t {{");
            
            foreach(var thickness in thicknesses)
            {
                AppendThickness(builder, thickness);
            }

            foreach (var @double in doubles)
            {
                AppendDouble(builder, @double);
            }

            builder.AppendLine($"\t }}");
            builder.AppendLine($"}}");

            return builder.ToString();
        }

        static void AppendThickness(StringBuilder builder, Thickness thickness)
        {
            builder.AppendLine($"\t\t /// <summary>");
            builder.AppendLine($"\t\t /// {thickness.Comment}");
            builder.AppendLine($"\t\t /// </summary>");
            builder.AppendLine($"\t\t public static readonly Thickness {thickness.Name} = new Thickness(");
            builder.AppendLine($"\t\t\t left:   {thickness.Left},");
            builder.AppendLine($"\t\t\t top:    {thickness.Top},");
            builder.AppendLine($"\t\t\t right:  {thickness.Right},");
            builder.AppendLine($"\t\t\t bottom: {thickness.Bottom});");
            builder.AppendLine($"");
        }

        static void AppendDouble(StringBuilder builder, Double @double)
        {
            builder.AppendLine($"\t\t /// <summary>");
            builder.AppendLine($"\t\t /// {@double.Comment}");
            builder.AppendLine($"\t\t /// </summary>");
            builder.AppendLine($"\t\t public const double {@double.Name} = {@double.Value};");
            builder.AppendLine($"");
        }
    }
}
