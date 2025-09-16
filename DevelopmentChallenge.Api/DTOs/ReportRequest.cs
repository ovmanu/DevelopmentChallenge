using DevelopmentChallenge.Data.Enums;
using System.Collections.Generic;

namespace DevelopmentChallenge.Api.DTOs
{
    public class ReportRequest
    {
        public List<ShapeDto> Shapes { get; set; }
        public LanguageEnum Language { get; set; }
    }
}
