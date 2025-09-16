using System;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Services;

namespace DevelopmentChallenge.Data.Classes
{
    public class EquilateralTriangle : Shape
    {
        private readonly decimal _side;
        public EquilateralTriangle(decimal side) => _side = side;

        public override decimal CalculateArea() =>
            ((decimal)Math.Sqrt(3) / 4) * _side * _side;

        public override decimal CalculatePerimeter() =>
            _side * 3;

        public override string Translate(int quantity, LanguageEnum language)
        {
            var dict = DictionaryProvider.Get(language);
            var words = dict["EQUILATERAL_TRIANGLE"];
            return quantity == 1 ? words[0] : words[1];
        }
    }
}
