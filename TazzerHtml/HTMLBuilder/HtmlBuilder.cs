using TazzerHtml.Components.Tag;
using TazzerHtml.HTMLBuilder.PageElements;

namespace TazzerHtml.HTMLBuilder;

/// <summary>
/// Represents HTML page builder.
/// Implements <see cref="TazzerHtml.HTMLBuilder.IHtmlBuilder"/> interface.
/// </summary>
public class HtmlBuilder : IHtmlBuilder
{
    private readonly Page _page;

    /// <summary>
    /// Create a page builder.
    /// </summary>
    /// <param name="page"></param>
    public HtmlBuilder(Page page)
    {
        _page = page;
    }

    /// <summary>
    /// Include page stylesheet.
    /// </summary>
    /// <param name="href">HTML stylesheet path</param>
    /// <returns></returns>
    public IHtmlBuilder IncludeStylesheet(string href)
    {
        _page.Head.Style = href;
        return this;
    }

    /// <summary>
    /// Define page language.
    /// </summary>
    /// <param name="lang">language value</param>
    /// <returns></returns>
    public IHtmlBuilder IncludeLanguage(string lang)
    {
        _page.Language = lang;
        return this;
    }

    /// <summary>
    /// Define page title.
    /// </summary>
    /// <param name="title">title value</param>
    /// <returns></returns>
    public IHtmlBuilder IncludePageTitle(string title)
    {
        _page.Head.Title = title;
        return this;
    }

    /// <summary>
    /// Append page body.
    /// </summary>
    /// <param name="component"></param>
    /// <returns></returns>
    public IHtmlBuilder AddBody(params IHtmlElement[] component)
    {
        _page.Body.AddHtmlElement(component);
        return this;
    }

    /// <summary>
    /// Build the HTML page.
    /// </summary>
    /// <param name="path">file output</param>
    /// <returns></returns>
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