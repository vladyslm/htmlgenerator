using HtmlGenerator.Components.Tag;

namespace HtmlGenerator.HTMLBuilder;

public class HtmlBuilder : IHtmlBuilder
{
    private string _style = String.Empty;
    private string _lang = String.Empty;
    private string _title = String.Empty;
    private string _outFile = String.Empty;
    
    private List<IHtmlElement> _htmlElements = new();

    public IHtmlBuilder IncludeStylesheet(string href)
    {
        _style = String.Format($"\n\t<link rel=\"stylesheet\" href=\"{href}\">");
        return this;
    }

    public IHtmlBuilder IncludeLanguage(string lang)
    {
        _lang = String.Format($" lang=\"{lang}\"");
        return this;
    }

    public IHtmlBuilder IncludePageTitle(string title)
    {
        _title = String.Format($"\n\t<title>{title}</title>");
        return this;
    }

    public IHtmlBuilder AddComponent(params IHtmlElement[] component)
    {
        _htmlElements.AddRange(component);
        return this;
    }

    private string PrepareHead()
    {
        if (
            _title != String.Empty ||
            _style != String.Empty
            )
        {
           return String.Format($"<head>{_title}{_style}\n</head>");
        }

        return String.Empty;
    }

    private string Prepare()
    {
        var components = new List<string>();
        foreach (var htmlElement in _htmlElements)
        {
            components.Add(htmlElement.Build());
        }
        var joinedComponents = String.Join("\n", components);
        return String.Format($"<body>\n{joinedComponents}\n</body>");
    }

    public async Task Build(string path)
    {
        if (path==String.Empty)
        {
            throw new ArgumentException("Output path cannot be empty");
        }
        
        var body = Prepare();
        var head = PrepareHead();
        var page = String.Format($"<html{_lang}>\n{head}\n{body}\n</html>");
        await File.WriteAllTextAsync(path, page);
    }
}