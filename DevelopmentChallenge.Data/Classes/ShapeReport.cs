using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Services;

namespace DevelopmentChallenge.Data.Classes
{
    public static class ShapeReport
    {
        public static string Print(List<Shape> shapes, LanguageEnum language)
        {
            var dict = DictionaryProvider.Get(language);
            var sb = new StringBuilder();

            if (shapes == null || !shapes.Any())
            {
                sb.Append(dict["EMPTY"][0]);
                return sb.ToString();
            }

            sb.Append(dict["HEADER"][0]);

            var groups = shapes
                .GroupBy(s => s.GetType())
                .Select(g => new
                {
                    Count = g.Count(),
                    Area = g.Sum(s => s.CalculateArea()),
                    Perimeter = g.Sum(s => s.CalculatePerimeter()),
                    Example = g.First()
                });

            foreach (var g in groups)
            {
                var perimeterLabel = dict["PERIMETER"][0];
                sb.Append($"{g.Count} {g.Example.Translate(g.Count, language)} | Area {g.Area:#.##} | {perimeterLabel} {g.Perimeter:#.##} <br/>");
            }

            var totalPerimeter = shapes.Sum(s => s.CalculatePerimeter());
            var totalArea = shapes.Sum(s => s.CalculateArea());
            var shapeWord = dict["SHAPES"][0];
            var perimeterTotalLabel = dict["PERIMETER"][0];

            sb.Append("TOTAL:<br/>");
            sb.Append($"{shapes.Count} {shapeWord} {perimeterTotalLabel} {totalPerimeter:#.##} Area {totalArea:#.##}");

            return sb.ToString();
        }
    }
}
