namespace TazzerHtml.Components.Tag;

/// <summary>This class represents custom HTML tag</summary>
public class Custom : HtmlTag
{
    /// <summary>
    /// Create an instance of a custom HTML class without an HTML content.
    /// </summary>
    /// <param name="tag">HTML tag</param>
    /// <param name="attributes">HTML attributes</param>
    public Custom(string tag, params string[] attributes) : base(tag)
    {
        _attributes.AddRange(attributes);
    }

    /// <summary>
    /// Create an instance of a custom HTML class with an HTML content.
    /// </summary>
    /// <param name="tag">HTML tag</param>
    /// <param name="content">HTML content</param>
    /// <param name="attributes">HTML attributes</param>
    public Custom(string tag, string content, params string[] attributes) : base(tag)
    {
        _attributes.AddRange(attributes);
        Content = content;
    }


    /// <summary>
    /// Add the HTML content
    /// </summary>
    /// <param name="content">HTML content value</param>
    /// <returns></returns>
    public Custom InnerHtml(string content) => this.ExtensionInnerHtml(content);
}