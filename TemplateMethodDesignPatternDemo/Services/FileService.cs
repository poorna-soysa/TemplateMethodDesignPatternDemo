using System.IO;
using TemplateMethodDesignPatternDemo.Model;

namespace TemplateMethodDesignPatternDemo.Services;

public interface IFileService
{
    IEnumerable<Flight> Import(IFormFile file);
}

public class FileService(IEnumerable<IFileParser> fileParsers) : IFileService
{
    private readonly IEnumerable<IFileParser> _fileParsers = fileParsers;

    public IEnumerable<Flight> Import(IFormFile file)
    {
        foreach (var parser in _fileParsers)
        {
            if (parser.TryParse(file, out IEnumerable<Flight> flights))
            {
                return flights;
            }
        }
        return Enumerable.Empty<Flight>();
    }
}
