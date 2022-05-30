namespace HtmlGenerator.HTMLBuilder;

using Nodes;

public interface IHtmlBuilder
{
    public IHtmlBuilder IncludeStylesheet(string href);
    public IHtmlBuilder IncludeLanguage(string lang);
    public IHtmlBuilder IncludePageTitle(string title);
    public IHtmlBuilder AddComponent(params IHtmlElement[] component);

    public Task Build(string path);
}