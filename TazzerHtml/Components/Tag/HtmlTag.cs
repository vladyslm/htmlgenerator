namespace TazzerHtml.Components.Tag;

/// <summary>
/// Represent Html tag.
/// Implements <see cref="IHtmlElement"/> interface.
/// </summary>
public class HtmlTag : IHtmlElement
{
    /// <summary>
    /// List of HTML attributes.
    /// </summary>
    protected readonly List<string> _attributes = new List<string>();

    /// <summary>
    /// Gets HTML tag value.
    /// </summary>
    protected string Tag { get; private set; }

    /// <summary>
    /// HTML content value.
    /// </summary>
    protected string Content { get; set; }

    /// <summary>
    /// Sets HTML tag value.
    /// </summary>
    /// <param name="tag"></param>
    protected HtmlTag(string tag)
    {
        Tag = tag;
        Content = "";
    }

    /// <summary>
    /// Add HTML content.
    /// </summary>
    /// <param name="content"></param>
    public void AddNodeContent(string content)
    {
        Content = content;
    }

    /// <summary>
    /// Add HTML attribute.
    /// </summary>
    /// <param name="value"></param>
    public void Add(string value)
    {
        _attributes.Add(value);
    }

    /// <summary>
    /// Assemble HTML tag and return as a string.
    /// </summary>
    /// <returns></returns>
    public string Build()
    {
        var attr = String.Join("", _attributes);
        return String.Format($"<{Tag}{attr}>{Content}</{Tag}>");
    }
}

/// <summary>
/// Represents <see cref="TazzerHtml.Components.Tag.HtmlTag"/> extenstions.
/// </summary>
public static class HtmlNodeExtension
{
    /// <summary>
    /// Extenstion to add HTML content.
    /// </summary>
    /// <param name="self"></param>
    /// <param name="content"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T ExtensionInnerHtml<T>(this T self, string content) where T : HtmlTag
    {
        self.AddNodeContent(content);
        return self;
    }

    /// <summary>
    /// Extenstion to add HTML attributes.
    /// </summary>
    /// <param name="self"></param>
    /// <param name="attribute"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T ExtensionAttribute<T>(this T self, string attribute) where T : HtmlTag
    {
        self.Add(attribute);
        return self;
    }
}