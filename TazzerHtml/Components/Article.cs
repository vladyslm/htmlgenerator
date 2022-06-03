using TazzerHtml.Components.Tag;

namespace TazzerHtml.Components;

/// <summary>
/// Represents HTML article.
/// </summary>
public class Article : HtmlComponent
{
    /// <summary>
    /// Class inherits from <see cref="TazzerHtml.Components.HtmlComponent"/>
    /// </summary>
    public Article() : base("article")
    {
    }

    /// <summary>
    /// Appends HTML elements as child nodes.
    /// </summary>
    /// <param name="nodes"></param>
    /// <returns></returns>
    public Article AppendChild(params IHtmlElement[] nodes) => this.ExtensionAppendNode(nodes);

    /// <summary>
    /// Add one or multiple class attributes to this HTML element.
    /// </summary>
    /// <param name="class"></param>
    /// <returns></returns>
    public Article AddClass(params string[] @class) => this.ExtensionAttribute(Attributes.Attributes.Class(@class));

    /// <summary>
    /// Add id attribute to this HTML element.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Article AddId(string id) => this.ExtensionAttribute(Attributes.Attributes.Id(id));
}