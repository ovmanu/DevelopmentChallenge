using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Translations
{
    public static class ItalianDictionary
    {
        public static readonly Dictionary<string, string[]> Words =
            new Dictionary<string, string[]>
            {
                { "SQUARE", new[] { "Quadrato", "Quadrati" } },
                { "CIRCLE", new[] { "Cerchio", "Cerchi" } },
                { "EQUILATERAL_TRIANGLE", new[] { "Triangolo", "Triangoli" } },
                { "RECTANGLE", new[] { "Rettangolo", "Rettangoli" } },
                { "EMPTY", new[] { "<h1>Lista vuota di forme!</h1>" } },
                { "HEADER", new[] { "<h1>Rapporto delle forme</h1>" } },
                { "SHAPES", new[] { "forme" } },
                { "PERIMETER", new[] { "Perimetro" } }
            };
    }
}
