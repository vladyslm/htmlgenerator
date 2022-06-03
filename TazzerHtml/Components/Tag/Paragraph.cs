using Attribute = TazzerHtml.Components.Attributes.Attribute;

namespace TazzerHtml.Components.Tag;

public class Paragraph : HtmlTag
{
    public Paragraph() : base("p"){}
    
    public Paragraph InnerHtml(string content) => this.ExtensionInnerHtml(content);
    public Paragraph AddClass(params string[] @class) => this.ExtensionAttribute(Attributes.Attribute.Class(@class));
    public Paragraph AddId(string id) => this.ExtensionAttribute(Attributes.Attribute.Id(id));
}