using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class ShapeReportTests
    {
        [Test]
        public void EmptyListInSpanish()
        {
            var result = ShapeReport.Print(new List<Shape>(), LanguageEnum.Spanish);
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", result);
        }

        [Test]
        public void EmptyListInEnglish()
        {
            var result = ShapeReport.Print(new List<Shape>(), LanguageEnum.English);
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", result);
        }

        [Test]
        public void EmptyListInItalian()
        {
            var result = ShapeReport.Print(new List<Shape>(), LanguageEnum.Italian);
            Assert.AreEqual("<h1>Lista vuota di forme!</h1>", result);
        }

        [Test]
        public void OneSquareInSpanish()
        {
            var shapes = new List<Shape> { new Square(5) };
            var result = ShapeReport.Print(shapes, LanguageEnum.Spanish);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25",
                result);
        }

        [Test]
        public void OneSquareInEnglish()
        {
            var shapes = new List<Shape> { new Square(5) };
            var result = ShapeReport.Print(shapes, LanguageEnum.English);

            Assert.AreEqual(
                "<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shapes Perimeter 20 Area 25",
                result);
        }

        [Test]
        public void ManySquaresInEnglish()
        {
            var shapes = new List<Shape>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };

            var result = ShapeReport.Print(shapes, LanguageEnum.English);

            Assert.AreEqual(
                "<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35",
                result);
        }

        [Test]
        public void ManyShapesInEnglish()
        {
            var shapes = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };

            var result = ShapeReport.Print(shapes, LanguageEnum.English);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                result);
        }

        [Test]
        public void ManyShapesInSpanish()
        {
            var shapes = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };

            var result = ShapeReport.Print(shapes, LanguageEnum.Spanish);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                result);
        }

        [Test]
        public void RectangleInEnglish()
        {
            var shapes = new List<Shape> { new Rectangle(3, 4) };
            var result = ShapeReport.Print(shapes, LanguageEnum.English);

            Assert.AreEqual(
                "<h1>Shapes report</h1>1 Rectangle | Area 12 | Perimeter 14 <br/>TOTAL:<br/>1 shapes Perimeter 14 Area 12",
                result);
        }

        [Test]
        public void RectangleInSpanish()
        {
            var shapes = new List<Shape> { new Rectangle(3, 4) };
            var result = ShapeReport.Print(shapes, LanguageEnum.Spanish);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Rectángulo | Area 12 | Perimetro 14 <br/>TOTAL:<br/>1 formas Perimetro 14 Area 12",
                result);
        }

        [Test]
        public void OneCircleInSpanish()
        {
            var shapes = new List<Shape> { new Circle(3) };
            var result = ShapeReport.Print(shapes, LanguageEnum.Spanish);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Círculo | Area 7,07 | Perimetro 9,42 <br/>TOTAL:<br/>1 formas Perimetro 9,42 Area 7,07",
                result);
        }

        [Test]
        public void OneCircleInEnglish()
        {
            var shapes = new List<Shape> { new Circle(3) };
            var result = ShapeReport.Print(shapes, LanguageEnum.English);

            Assert.AreEqual(
                "<h1>Shapes report</h1>1 Circle | Area 7,07 | Perimeter 9,42 <br/>TOTAL:<br/>1 shapes Perimeter 9,42 Area 7,07",
                result);
        }

        [Test]
        public void OneCircleInItalian()
        {
            var shapes = new List<Shape> { new Circle(3) };
            var result = ShapeReport.Print(shapes, LanguageEnum.Italian);

            Assert.AreEqual(
                "<h1>Rapporto delle forme</h1>1 Cerchio | Area 7,07 | Perimetro 9,42 <br/>TOTAL:<br/>1 forme Perimetro 9,42 Area 7,07",
                result);
        }

    }
}
