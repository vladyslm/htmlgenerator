using Attribute = HtmlGenerator.Components.Attributes.Attribute;

namespace HtmlGenerator.Components.Tag;

public class Link : HtmlTag
{
    public Link() : base("a"){}
    
    public Link InnerHtml(string content) => this.ExtensionInnerHtml(content);
    public Link AddClass(params string[] @class) => this.ExtensionAttribute(Attribute.Class(@class));
    public Link AddId(string id) => this.ExtensionAttribute(Attribute.Id(id));

    public Link AddHref(string href) => this.ExtensionAttribute(Attribute.Href(href));
}