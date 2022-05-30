using Attribute = HtmlGenerator.Components.Attributes.Attribute;

namespace HtmlGenerator.Components.Tag;

public class Paragraph : HtmlTag
{
    public Paragraph() : base("p"){}
    
    public Paragraph InnerHtml(string content) => this.ExtensionInnerHtml(content);
    public Paragraph AddClass(params string[] @class) => this.ExtensionAttribute(Attribute.Class(@class));
    public Paragraph AddId(string id) => this.ExtensionAttribute(Attribute.Id(id));
}