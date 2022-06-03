using TazzerHtml.HTMLBuilder;
using TazzerHtml.HTMLBuilder.PageElements;

namespace TazzerHtml;

public static class Builder
{
    public static HtmlBuilder NewHtmlPage()
    {
        return new HtmlBuilder(new Page(new Head(), new Body()));
    }
}