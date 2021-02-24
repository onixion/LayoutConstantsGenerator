using System.Collections.Generic;
using System.Text;

namespace LayoutConstantsGenerator
{
    public static class LayoutGenerator
    {

        public static string Generate(IEnumerable<IThickness> thicknesses)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"using System;");
            builder.AppendLine($"using Xamarin.Forms;");
            builder.AppendLine($"");
            builder.AppendLine($"namespace TODO");
            builder.AppendLine($"{{");
            builder.AppendLine($"\t public static class LayoutConstants");
            builder.AppendLine($"\t {{");
            
            foreach(var thickness in thicknesses)
            {
                AppendThickness(builder, thickness);
            }

            builder.AppendLine($"\t }}");
            builder.AppendLine($"}}");

            return builder.ToString();
        }

        static void AppendThickness(StringBuilder builder, IThickness thickness)
        {
            builder.AppendLine($"\t\t ///<summary>");
            builder.AppendLine($"\t\t /// {thickness.Comment}");
            builder.AppendLine($"\t\t ///</summary>");
            builder.AppendLine($"\t\t public const Thickness {thickness.Name} = new Thickness(");
            builder.AppendLine($"\t\t\t left:  {thickness.Left},");
            builder.AppendLine($"\t\t\t top:   {thickness.Top},");
            builder.AppendLine($"\t\t\t right: {thickness.Right},");
            builder.AppendLine($"\t\t\t down:  {thickness.Down});");
            builder.AppendLine($"");
        }
    }
}
