using TemplateMethodDesignPatternDemo.Model;

namespace TemplateMethodDesignPatternDemo.Services;

public interface IFileParser
{
    bool TryParse(IFormFile file, out IEnumerable<Flight> flights);
}

public abstract class BaseParser : IFileParser
{
    public bool TryParse(IFormFile file, out IEnumerable<Flight> flights)
    {
        if (!CanParse(Path.GetExtension(file.FileName)))
        {
            flights = [];
            return false;
        }

        flights = Parse(file);
        return true;
    }

    protected abstract string FileExtension { get; }
    private bool CanParse(string fileExtension)
        => FileExtension == fileExtension;
    protected abstract IEnumerable<Flight> Parse(IFormFile file);
}
