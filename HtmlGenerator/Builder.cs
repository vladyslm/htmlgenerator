using HtmlGenerator.HTMLBuilder;

namespace HtmlGenerator;

public static class Builder
{
    public static HtmlBuilder NewHtmlPage()
    {
        return new HtmlBuilder();
    }
}