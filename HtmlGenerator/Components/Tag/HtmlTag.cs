namespace HtmlGenerator.Components.Tag;

public class HtmlTag : IHtmlElement
{
    protected readonly List<string> _attributes = new List<string>();
    protected string Tag { get; private set; }
    protected string Content { get; set; }

    protected HtmlTag(string tag)
    {
        Tag = tag;
        Content = "";
    }

    public void AddNodeContent(string content)
    {
        Content = content;
    }

    public void Add(string value)
    {
        _attributes.Add(value);
    }

    public string Build()
    {
        var attr = String.Join("", _attributes);
        return String.Format($"<{Tag}{attr}>{Content}</{Tag}>");
    }
}

public static class HtmlNodeExtension
{
    public static T ExtensionInnerHtml<T>(this T self, string content) where T : HtmlTag
    {
        self.AddNodeContent(content);
        return self;
    }

    public static T ExtensionAttribute<T>(this T self, string attribute) where T : HtmlTag
    {
        self.Add(attribute);
        return self;
    }
}