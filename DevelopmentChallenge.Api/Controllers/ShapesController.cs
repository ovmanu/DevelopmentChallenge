using DevelopmentChallenge.Api.DTOs;
using DevelopmentChallenge.Data.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevelopmentChallenge.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShapesController : ControllerBase
    {
        [HttpPost("report")]
        public ActionResult<string> GetReport([FromBody] ReportRequest request)
        {
            var shapes = new List<Shape>();

            foreach (var shape in request.Shapes)
            {
                switch (shape.Type.ToLower())
                {
                    case "square":
                        shapes.Add(new Square(shape.Size));
                        break;
                    case "circle":
                        shapes.Add(new Circle(shape.Size));
                        break;
                    case "triangle":
                        shapes.Add(new EquilateralTriangle(shape.Size));
                        break;
                    case "rectangle":
                        shapes.Add(new Rectangle(shape.Width, shape.Height));
                        break;
                    default:
                        return BadRequest($"Unknown shape: {shape.Type}");
                }
            }

            var report = ShapeReport.Print(shapes, request.Language);
            return Ok(report);
        }
    }
}
