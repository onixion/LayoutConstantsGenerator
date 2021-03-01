using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutConstantsGenerator
{
    public static class ConverterGenerator
    {

        public static string Generate(IEnumerable<Thickness> thicknesses, IEnumerable<Double> doubles)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"");
            builder.AppendLine($"/// This file was generated at {DateTime.UtcNow.ToLongTimeString()} on the {DateTime.UtcNow.ToLongDateString()} (UTC).");
            builder.AppendLine($"");
            
            builder.AppendLine($"using Xamarin.Forms;");
            builder.AppendLine($"using System.Collections.Generic;");
            builder.AppendLine($"using System;");
            builder.AppendLine($"using System.Globalization;");
            builder.AppendLine($"");
            builder.AppendLine($"namespace TODO");
            builder.AppendLine($"{{");
            builder.AppendLine($"\t /// <summary>");
            builder.AppendLine($"\t /// Layout constants converter.");
            builder.AppendLine($"\t /// </summary>");
            builder.AppendLine($"\t public class LayoutConstantsConverter : IValueConverter");
            builder.AppendLine($"\t {{");

            // String to Thickness.
            builder.AppendLine($"\t\t readonly static IDictionary<string, Thickness> keyToThickness = new Dictionary<string, Thickness>()");
            builder.AppendLine($"\t\t {{");
            foreach (var thickness in thicknesses)
            {
                AppendThickness(builder, thickness);
            }
            builder.AppendLine($"\t\t }};");
            builder.AppendLine($"");

            // String to Double.
            builder.AppendLine($"\t\t readonly static IDictionary<string, double> keyToDouble = new Dictionary<string, double>()");
            builder.AppendLine($"\t\t {{");
            foreach (var @double in doubles)
            {
                AppendDouble(builder, @double);
            }
            builder.AppendLine($"\t\t }};");
            builder.AppendLine($"");

            builder.AppendLine($"\t\t public object Convert(object value, Type targetType, object parameter, CultureInfo culture)");
            builder.AppendLine($"\t\t {{");
            builder.AppendLine($"\t\t\t // TODO add logic here");
            builder.AppendLine($"\t\t\t throw new NotImplementedException();");
            builder.AppendLine($"\t\t }}");
            builder.AppendLine($"");

            builder.AppendLine($"\t\t public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)");
            builder.AppendLine($"\t\t {{");
            builder.AppendLine($"\t\t\t // TODO add logic here");
            builder.AppendLine($"\t\t\t throw new NotImplementedException();");
            builder.AppendLine($"\t\t }}");

            builder.AppendLine($"\t }}");
            builder.AppendLine($"}}");

            return builder.ToString();
        }

        private static void AppendThickness(StringBuilder builder, Thickness thickness)
        {
            builder.AppendLine($"\t\t\t {{ \"{thickness.Name}\", LayoutConstants.{thickness.Name} }},");
        }

        private static void AppendDouble(StringBuilder builder, Double @double)
        {
            builder.AppendLine($"\t\t\t {{ \"{@double.Name}\", LayoutConstants.{@double.Name} }},");
        }
    }
}
