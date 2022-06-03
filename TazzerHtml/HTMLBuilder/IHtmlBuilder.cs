using TazzerHtml.Components.Tag;

namespace TazzerHtml.HTMLBuilder;

/// <summary>
/// Represents HTML page builder interface.
/// </summary>
public interface IHtmlBuilder
{
    /// <summary>
    /// Include page stylesheet.
    /// </summary>
    /// <param name="href">HTML stylesheet path</param>
    /// <returns></returns>
    public IHtmlBuilder IncludeStylesheet(string href);

    /// <summary>
    /// Define page language.
    /// </summary>
    /// <param name="lang">language value</param>
    /// <returns></returns>
    public IHtmlBuilder IncludeLanguage(string lang);

    /// <summary>
    /// Define page title.
    /// </summary>
    /// <param name="title">title value</param>
    /// <returns></returns>
    public IHtmlBuilder IncludePageTitle(string title);

    /// <summary>
    /// Append page body.
    /// </summary>
    /// <param name="component"></param>
    /// <returns></returns>
    public IHtmlBuilder AddBody(params IHtmlElement[] component);


    /// <summary>
    /// Build the HTML page.
    /// </summary>
    /// <param name="path">file output</param>
    /// <returns></returns>
    public Task Build(string path);
}