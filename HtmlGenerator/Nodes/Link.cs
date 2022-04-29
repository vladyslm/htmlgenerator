namespace HtmlGenerator.Nodes;
using Attributes;

public class Link : HtmlNode
{
    public Link() : base("a"){}
    
    public Link InnerHtml(string content) => this.ExtensionInnerHtml(content);
    public Link AddClass(params string[] @class) => this.ExtensionAttribute(Attribute.Class(@class));
    public Link AddId(string id) => this.ExtensionAttribute(Attribute.Id(id));

    public Link AddHref(string href) => this.ExtensionAttribute(Attribute.Href(href));
}