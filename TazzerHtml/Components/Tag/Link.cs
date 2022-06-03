using Attribute = TazzerHtml.Components.Attributes.Attribute;

namespace TazzerHtml.Components.Tag;

public class Link : HtmlTag
{
    public Link() : base("a"){}
    
    public Link InnerHtml(string content) => this.ExtensionInnerHtml(content);
    public Link AddClass(params string[] @class) => this.ExtensionAttribute(Attributes.Attribute.Class(@class));
    public Link AddId(string id) => this.ExtensionAttribute(Attributes.Attribute.Id(id));

    public Link AddHref(string href) => this.ExtensionAttribute(Attributes.Attribute.Href(href));
}