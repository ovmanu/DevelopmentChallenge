using System;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Services;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circle : Shape
    {
        private readonly decimal _diameter;
        public Circle(decimal diameter) => _diameter = diameter;

        public override decimal CalculateArea() =>
            (decimal)Math.PI * (_diameter / 2) * (_diameter / 2);

        public override decimal CalculatePerimeter() =>
            (decimal)Math.PI * _diameter;

        public override string Translate(int quantity, LanguageEnum language)
        {
            var dict = DictionaryProvider.Get(language);
            var words = dict["CIRCLE"];
            return quantity == 1 ? words[0] : words[1];
        }
    }
}
