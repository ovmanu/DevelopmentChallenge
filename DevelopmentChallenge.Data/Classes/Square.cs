using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Services;

namespace DevelopmentChallenge.Data.Classes
{
    public class Square : Shape
    {
        private readonly decimal _side;
        public Square(decimal side) => _side = side;

        public override decimal CalculateArea() => _side * _side;
        public override decimal CalculatePerimeter() => _side * 4;

        public override string Translate(int quantity, LanguageEnum language)
        {
            var dict = DictionaryProvider.Get(language);
            var words = dict["SQUARE"];
            return quantity == 1 ? words[0] : words[1];
        }
    }
}
