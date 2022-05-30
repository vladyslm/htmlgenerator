using HtmlGenerator.Components.Tag;
using Attribute = HtmlGenerator.Components.Attributes.Attribute;

namespace HtmlGenerator.Components;

public class Div : HtmlComponent
{
    public Div() : base("div"){}

    public Div AppendNode(params HtmlTag[] nodes) => this.ExtensionAppendNode(nodes);

    public Div AppendChild(params HtmlTag[] nodes) => this.ExtensionAppendNode(nodes);
    public Div AddClass(params string[] @class) => this.ExtensionAttribute(Attribute.Class(@class));
    public Div AddId(string id) => this.ExtensionAttribute(Attribute.Id(id));
}