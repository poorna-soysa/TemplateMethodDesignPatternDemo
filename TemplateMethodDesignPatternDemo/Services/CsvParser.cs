using TemplateMethodDesignPatternDemo.Model;

namespace TemplateMethodDesignPatternDemo.Services;

public class CsvParser : BaseParser
{
    protected override string FileExtension => ".csv";

    protected override IEnumerable<Flight> Parse(IFormFile file)
    {
        throw new NotImplementedException();
    }
}