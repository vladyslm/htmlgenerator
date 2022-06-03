namespace TazzerHtml.HTMLBuilder.PageElements;

/// <summary>
/// Represents HTML &lt;html&gt; tag.
/// </summary>
public class Page : IPageElement
{
    private string _lang = String.Empty;

    /// <summary>
    /// Page language.
    /// </summary>
    public string Language
    {
        get => _lang;
        set => _lang = String.Format($" lang=\"{value}\"");
    }

    /// <summary>
    /// Gets page body of type <see cref="TazzerHtml.HTMLBuilder.PageElements.Head"/>
    /// </summary>
    public Head Head { get; }

    /// <summary>
    /// Gets page body of type <see cref="TazzerHtml.HTMLBuilder.PageElements.Body"/>
    /// </summary>
    public Body Body { get; }

    /// <summary>
    /// Create page object.
    /// </summary>
    /// <param name="headElement"></param>
    /// <param name="bodyElement"></param>
    public Page(Head headElement, Body bodyElement)
    {
        Head = headElement;
        Body = bodyElement;
    }

    /// <summary>
    /// Assemble HTML page and return as a string.
    /// </summary>
    /// <returns></returns>
    public string Prepare()
    {
        var body = Body.Prepare();
        var head = Head.Prepare();
        return String.Format($"<html{_lang}>\n{head}\n{body}\n</html>");
    }
}