using HtmlGenerator.HTMLBuilder;
using HtmlGenerator.HTMLBuilder.PageElements;

namespace HtmlGenerator;

public static class Builder
{
    public static HtmlBuilder NewHtmlPage()
    {
        return new HtmlBuilder(new Page(new Head(), new Body()));
    }
}