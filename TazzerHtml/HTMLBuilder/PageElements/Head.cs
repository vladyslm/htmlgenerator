namespace TazzerHtml.HTMLBuilder.PageElements;

/// <summary>
/// Represents HTML head tag.
/// </summary>
public class Head : IPageElement
{
    private string _style = String.Empty;
    private string _title = String.Empty;

    /// <summary>
    /// Page title.
    /// </summary>
    public string Title
    {
        get => _title;
        set => _title = String.Format($"\n\t<title>{value}</title>");
    }

    /// <summary>
    /// Page stylesheet.
    /// </summary>
    public string Style
    {
        get => _style;
        set => _style = String.Format($"\n\t<link rel=\"stylesheet\" href=\"{value}\">");
    }

    /// <summary>
    /// Assemble HTML element and return as string.
    /// </summary>
    /// <returns></returns>
    public string Prepare()
    {
        if (
            _title != String.Empty ||
            _style != String.Empty
        )
        {
            return String.Format($"<head>{_title}{_style}\n</head>");
        }

        return String.Empty;
    }
}