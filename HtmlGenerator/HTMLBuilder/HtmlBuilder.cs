using HtmlGenerator.Components.Tag;
using HtmlGenerator.HTMLBuilder.PageElements;

namespace HtmlGenerator.HTMLBuilder;

public class HtmlBuilder : IHtmlBuilder
{
    private readonly Page _page;

    public HtmlBuilder(Page page)
    {
        _page = page;
    }


    public IHtmlBuilder IncludeStylesheet(string href)
    {
        _page.Head.Style = href;
        return this;
    }

    public IHtmlBuilder IncludeLanguage(string lang)
    {
        _page.Language = lang;
        return this;
    }

    public IHtmlBuilder IncludePageTitle(string title)
    {
        _page.Head.Title = title;
        return this;
    }

    public IHtmlBuilder AddBody(params IHtmlElement[] component)
    {
        _page.Body.AddHtmlElement(component);
        return this;
    }

    public async Task Build(string path)
    {
        if (path == String.Empty)
        {
            throw new ArgumentException("Output path cannot be empty");
        }

        var page = _page.Prepare();
        await File.WriteAllTextAsync(path, page);
    }
}