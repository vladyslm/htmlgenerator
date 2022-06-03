using Attribute = TazzerHtml.Components.Attributes.Attribute;

namespace TazzerHtml.Components.Tag;

/// <summary>This class represents HTML paragraph</summary>
public class Paragraph : HtmlTag
{
    /// <summary>
    /// Class inherits from <see cref="HtmlTag"/>
    /// </summary>
    public Paragraph() : base("p"){}
    
    /// <summary>
    /// Add the HTML content
    /// </summary>
    /// <param name="content">HTML content value</param>
    /// <returns></returns>
    public Paragraph InnerHtml(string content) => this.ExtensionInnerHtml(content);
    
    /// <summary>
    /// Add one or multiple class attributes to this HTML element.
    /// </summary>
    /// <param name="class"></param>
    /// <returns></returns>
    public Paragraph AddClass(params string[] @class) => this.ExtensionAttribute(Attributes.Attribute.Class(@class));
    
    /// <summary>
    /// Add id attribute to this HTML element.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Paragraph AddId(string id) => this.ExtensionAttribute(Attributes.Attribute.Id(id));
}