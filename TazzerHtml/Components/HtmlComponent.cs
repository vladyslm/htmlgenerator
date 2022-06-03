using TazzerHtml.Components.Tag;

namespace TazzerHtml.Components;

/// <summary>
/// Represents HTML section tag.
/// </summary>
public class HtmlComponent : IHtmlElement
{
    private readonly List<string> _attributes = new();
    private readonly List<IHtmlElement> _htmlNodes = new();

    /// <summary>
    /// Gets component's tag.
    /// </summary>
    protected string Tag { get; }

    /// <summary>
    /// Sets component's tag.
    /// </summary>
    /// <param name="tag">HTML tag value</param>
    protected HtmlComponent(string tag)
    {
        Tag = tag;
    }

    /// <summary>
    /// Adds HTML tags of type <see cref="TazzerHtml.Components.Tag.IHtmlElement"/> 
    /// </summary>
    /// <param name="node"></param>
    public void AddNode(params IHtmlElement[] node)
    {
        _htmlNodes.AddRange(node);
    }

    /// <summary>
    /// Add attributes to this HTML element.
    /// </summary>
    /// <param name="value">HTML attribute value</param>
    public void Add(string value)
    {
        _attributes.Add(value);
    }

    /// <summary>
    /// Assembles an HTML component.
    /// </summary>
    /// <returns></returns>
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

/// <summary>
/// Component's extension class.
/// </summary>
public static class HtmlComponentExtension
{
    /// <summary>
    /// Appends HTML elements.
    /// </summary>
    /// <param name="self"></param>
    /// <param name="nodes">HTML elements</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T ExtensionAppendNode<T>(this T self, params IHtmlElement[] nodes) where T : HtmlComponent
    {
        self.AddNode(nodes);
        return self;
    }

    /// <summary>
    /// Adds HTML attributes.
    /// </summary>
    /// <param name="self"></param>
    /// <param name="attribute">HTML attributes</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T ExtensionAttribute<T>(this T self, string attribute) where T : HtmlComponent
    {
        self.Add(attribute);
        return self;
    }
}