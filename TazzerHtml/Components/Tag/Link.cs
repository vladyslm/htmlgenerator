using Attribute = TazzerHtml.Components.Attributes.Attribute;

namespace TazzerHtml.Components.Tag;

/// <summary>This class represents HTML link</summary>
public class Link : HtmlTag
{
    /// <summary>
    /// Class inherits from <see cref="HtmlTag"/>
    /// </summary>
    public Link() : base("a")
    {
    }

    /// <summary>
    /// Add the HTML content
    /// </summary>
    /// <param name="content">HTML content value</param>
    /// <returns></returns>
    public Link InnerHtml(string content) => this.ExtensionInnerHtml(content);

    /// <summary>
    /// Add one or multiple class attributes to this HTML element.
    /// </summary>
    /// <param name="class"></param>
    /// <returns></returns>
    public Link AddClass(params string[] @class) => this.ExtensionAttribute(Attributes.Attribute.Class(@class));

    /// <summary>
    /// Add id attribute to this HTML element.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Link AddId(string id) => this.ExtensionAttribute(Attributes.Attribute.Id(id));

    /// <summary>
    /// Add href attribute to this HTML element.
    /// </summary>
    /// <param name="href"></param>
    /// <returns></returns>
    public Link AddHref(string href) => this.ExtensionAttribute(Attributes.Attribute.Href(href));
}