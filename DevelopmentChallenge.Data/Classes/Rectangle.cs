using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Services;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangle : Shape
    {
        private readonly decimal _width;
        private readonly decimal _height;

        public Rectangle(decimal width, decimal height)
        {
            _width = width;
            _height = height;
        }

        public override decimal CalculateArea() => _width * _height;
        public override decimal CalculatePerimeter() => 2 * (_width + _height);

        public override string Translate(int quantity, LanguageEnum language)
        {
            var dict = DictionaryProvider.Get(language);
            var words = dict["RECTANGLE"];
            return quantity == 1 ? words[0] : words[1];
        }
    }
}
