using HtmlGenerator.Components.Tag;
using Attribute = HtmlGenerator.Components.Attributes.Attribute;

namespace HtmlGenerator.Components;

public class Article : HtmlComponent
{
    public Article() : base("article"){}

    public Article AppendChild(params IHtmlElement[] nodes) => this.ExtensionAppendNode(nodes);
    public Article AddClass(params string[] @class) => this.ExtensionAttribute(Attribute.Class(@class));
    public Article AddId(string id) => this.ExtensionAttribute(Attribute.Id(id));
}