namespace TazzerHtml.Components.Tag;

/// <summary>
/// Represents interface of HTML elements.
/// </summary>
public interface IHtmlElement
{
    /// <summary>
    /// Build this element and returns as a string value.
    /// </summary>
    /// <returns></returns>
    public string Build();
}