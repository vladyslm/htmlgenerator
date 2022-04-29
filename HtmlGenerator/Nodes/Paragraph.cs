namespace HtmlGenerator.Nodes;
using Attributes;

public class Paragraph : HtmlNode
{
    public Paragraph() : base("p"){}
    
    public Paragraph InnerHtml(string content) => this.ExtensionInnerHtml(content);
    public Paragraph AddClass(params string[] @class) => this.ExtensionAttribute(Attribute.Class(@class));
    public Paragraph AddId(string id) => this.ExtensionAttribute(Attribute.Id(id));
}