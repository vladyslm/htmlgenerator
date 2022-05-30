namespace HtmlGenerator.Components.Attributes;

public static class Attribute
{
    public static string Class(params string[] @class)
    {
        var classStr = String.Join(" ", @class);
        return String.Format($" class=\"{classStr}\"");
    }

    public static string Id(string id) => String.Format($" id=\"{id}\"");
    public static string Href(string href) => String.Format($" href=\"{href}\"");
}