using HtmlGenerator.Components.Tag;
using Attribute = HtmlGenerator.Components.Attributes.Attribute;

namespace HtmlGenerator.Components;

public class Div : HtmlComponent
{
    public Div() : base("div"){}


    public Div AppendChild(params IHtmlElement[] nodes) => this.ExtensionAppendNode(nodes);
    public Div AddClass(params string[] @class) => this.ExtensionAttribute(Attribute.Class(@class));
    public Div AddId(string id) => this.ExtensionAttribute(Attribute.Id(id));
}