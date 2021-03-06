using HtmlGenerator.Components.Tag;

namespace HtmlGenerator.HTMLBuilder;

public interface IHtmlBuilder
{
    public IHtmlBuilder IncludeStylesheet(string href);
    public IHtmlBuilder IncludeLanguage(string lang);
    public IHtmlBuilder IncludePageTitle(string title);
    public IHtmlBuilder AddBody(params IHtmlElement[] component);

    public Task Build(string path);
}