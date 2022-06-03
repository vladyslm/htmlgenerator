using TazzerHtml.Components.Tag;
using Attribute = TazzerHtml.Components.Attributes.Attribute;

namespace TazzerHtml.Components;

public class Article : HtmlComponent
{
    public Article() : base("article"){}

    public Article AppendChild(params IHtmlElement[] nodes) => this.ExtensionAppendNode(nodes);
    public Article AddClass(params string[] @class) => this.ExtensionAttribute(Attributes.Attribute.Class(@class));
    public Article AddId(string id) => this.ExtensionAttribute(Attributes.Attribute.Id(id));
}