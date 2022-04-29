namespace HtmlGenerator.Components;
using Nodes;
using Attributes;
public class Article : HtmlComponent
{
    public Article() : base("article") {}
    
    public Article AppendNode(params HtmlNode[] nodes) => this.ExtensionAppendNode(nodes);
    public Article AddClass(params string[] @class) => this.ExtensionAttribute(Attribute.Class(@class));
    public Article AddId(string id) => this.ExtensionAttribute(Attribute.Id(id));
}