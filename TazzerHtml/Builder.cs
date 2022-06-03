using TazzerHtml.HTMLBuilder;
using TazzerHtml.HTMLBuilder.PageElements;

namespace TazzerHtml;

/// <summary>
/// Static class to create a page builder.
/// </summary>
public static class Builder
{
    /// <summary>
    /// Creates a page builder of type <see cref="TazzerHtml.HTMLBuilder.HtmlBuilder"/>
    /// </summary>
    /// <returns></returns>
    public static HtmlBuilder NewHtmlPage()
    {
        return new HtmlBuilder(new Page(new Head(), new Body()));
    }
}