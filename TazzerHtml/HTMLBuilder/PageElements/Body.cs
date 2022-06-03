using TazzerHtml.Components.Tag;

namespace TazzerHtml.HTMLBuilder.PageElements;
using TazzerHtml.Components.Tag;

/// <summary>
/// Represents HTML body tag.
/// </summary>
public class Body : IPageElement
{
    private List<IHtmlElement> _htmlElements = new();

    /// <summary>
    /// Gets child HTML nodes.
    /// </summary>
    public List<IHtmlElement> HtmlElements => _htmlElements;

    /// <summary>
    /// Append HTML elements as child nodes.
    /// </summary>
    /// <param name="component"></param>
    public void AddHtmlElement(params IHtmlElement[] component)
    {
        _htmlElements.AddRange(component);
    }

    
    /// <summary>
    /// Assemble HTML element and return as string.
    /// </summary>
    /// <returns></returns>
    public string Prepare()
    {
        var components = new List<string>();
        foreach (var htmlElement in _htmlElements)
        {
            components.Add(htmlElement.Build());
        }
        var joinedComponents = String.Join("\n", components);
        return String.Format($"<body>\n{joinedComponents}\n</body>");
    }
}