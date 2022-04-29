namespace HtmlGenerator.Components;

using Nodes;
using Attributes;

public class Div : HtmlComponent
{
    public Div() : base("div"){}

    public Div AppendNode(params HtmlNode[] nodes) => this.ExtensionAppendNode(nodes);
    public Div AddClass(params string[] @class) => this.ExtensionAttribute(Attribute.Class(@class));
    public Div AddId(string id) => this.ExtensionAttribute(Attribute.Id(id));
}