using TazzerHtml.Components.Tag;
using Attribute = TazzerHtml.Components.Attributes.Attribute;

namespace TazzerHtml.Components;

public class Div : HtmlComponent
{
    public Div() : base("div"){}


    public Div AppendChild(params IHtmlElement[] nodes) => this.ExtensionAppendNode(nodes);
    public Div AddClass(params string[] @class) => this.ExtensionAttribute(Attributes.Attribute.Class(@class));
    public Div AddId(string id) => this.ExtensionAttribute(Attributes.Attribute.Id(id));
}