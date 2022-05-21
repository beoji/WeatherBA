using System.ComponentModel.DataAnnotations;
using WeatherBA.Shared.Common;

namespace WeatherBA.Shared.Entities
{
    public class Forecast : AuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}