using TazzerHtml.Components.Tag;
using Attribute = TazzerHtml.Components.Attributes.Attribute;

namespace TazzerHtml.Components;

/// <summary>
/// Represents HTML div.
/// </summary>
public class Div : HtmlComponent
{
    /// <summary>
    /// Class inherits from <see cref="TazzerHtml.Components.HtmlComponent"/>
    /// </summary>
    public Div() : base("div")
    {
    }


    /// <summary>
    /// Appends HTML elements as child nodes.
    /// </summary>
    /// <param name="nodes"></param>
    /// <returns></returns>
    public Div AppendChild(params IHtmlElement[] nodes) => this.ExtensionAppendNode(nodes);

    /// <summary>
    /// Add one or multiple class attributes to this HTML element.
    /// </summary>
    /// <param name="class"></param>
    /// <returns></returns>
    public Div AddClass(params string[] @class) => this.ExtensionAttribute(Attributes.Attribute.Class(@class));

    /// <summary>
    /// Add id attribute to this HTML element.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Div AddId(string id) => this.ExtensionAttribute(Attributes.Attribute.Id(id));
}