using TazzerHtml.Components.Tag;

namespace TazzerHtml.HTMLBuilder.PageElements;
using TazzerHtml.Components.Tag;

public class Body : IPageElement
{
    private List<IHtmlElement> _htmlElements = new();

    public List<IHtmlElement> HtmlElements => _htmlElements;

    public void AddHtmlElement(params IHtmlElement[] component)
    {
        _htmlElements.AddRange(component);
    }

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