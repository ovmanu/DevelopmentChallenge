using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Translations
{
    public static class SpanishDictionary
    {
        public static readonly Dictionary<string, string[]> Words =
            new Dictionary<string, string[]>
        {
            { "SQUARE", new[] { "Cuadrado", "Cuadrados" } },
            { "CIRCLE", new[] { "Círculo", "Círculos" } },
            { "EQUILATERAL_TRIANGLE", new[] { "Triángulo", "Triángulos" } },
            { "RECTANGLE", new[] { "Rectángulo", "Rectángulos" } },
            { "EMPTY", new[] { "<h1>Lista vacía de formas!</h1>" } },
            { "HEADER", new[] { "<h1>Reporte de Formas</h1>" } },
            { "SHAPES", new[] { "formas" } },
            { "PERIMETER", new[] { "Perimetro" } }
        };
    }
}
