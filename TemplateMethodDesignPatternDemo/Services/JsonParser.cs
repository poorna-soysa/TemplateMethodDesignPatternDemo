using System.Text.Json;
using TemplateMethodDesignPatternDemo.Model;

namespace TemplateMethodDesignPatternDemo.Services;

public class JsonParser : BaseParser
{
    protected override string FileExtension => ".json";

    protected override IEnumerable<Flight> Parse(IFormFile file)
    {
        var jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        var flights = JsonSerializer.Deserialize<List<Flight>>(
                  file.OpenReadStream(),
                 jsonSerializerOptions);


        if (flights is { Count: 0 })
        {
            return Enumerable.Empty<Flight>();
        }

        return flights;
    }
}
