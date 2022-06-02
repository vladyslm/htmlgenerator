using HtmlGenerator.Components.Tag;

namespace HtmlGenerator.Components;

public class HtmlComponent : IHtmlElement
{
    private readonly List<string> _attributes = new();
    private readonly List<IHtmlElement> _htmlNodes = new();
    protected string Tag { get; }
    
    protected HtmlComponent(string tag)
    {
        Tag = tag;
    }

    public void AddNode(params IHtmlElement[] node)
    {
        _htmlNodes.AddRange(node);
    }
    
    public void Add(string value)
    {
        _attributes.Add(value);
    }

    public string Build()
    {
        List<string> htmlList = new List<string>();
        foreach (var node in _htmlNodes)
        {
            htmlList.Add(node.Build());
        }

        var attr = String.Join("", _attributes);

        var componentsContent = String.Join("\n\t", htmlList);
        return String.Format($"<{Tag}{attr}>\n\t{componentsContent}\n</{Tag}>");
    }
}

public static class HtmlComponentExtension
{
    public static T ExtensionAppendNode<T>(this T self, params IHtmlElement[] nodes) where T : HtmlComponent
    {
        self.AddNode(nodes);
        return self;
    }

    public static T ExtensionAttribute<T>(this T self, string attribute) where T : HtmlComponent
    {
        self.Add(attribute);
        return self;
    }
}