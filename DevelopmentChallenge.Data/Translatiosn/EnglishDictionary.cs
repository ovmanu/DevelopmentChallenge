using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Translations
{
    public static class EnglishDictionary
    {
        public static readonly Dictionary<string, string[]> Words =
            new Dictionary<string, string[]>
            {
                { "SQUARE", new[] { "Square", "Squares" } },
                { "CIRCLE", new[] { "Circle", "Circles" } },
                { "EQUILATERAL_TRIANGLE", new[] { "Triangle", "Triangles" } },
                { "RECTANGLE", new[] { "Rectangle", "Rectangles" } },
                { "EMPTY", new[] { "<h1>Empty list of shapes!</h1>" } },
                { "HEADER", new[] { "<h1>Shapes report</h1>" } },
                { "SHAPES", new[] { "shapes" } },
                { "PERIMETER", new[] { "Perimeter" } }
            };
    }
}
