using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Shape
    {
        public abstract decimal CalculateArea();
        public abstract decimal CalculatePerimeter();
        public abstract string Translate(int cantidad, LanguageEnum idioma);
    }
}
