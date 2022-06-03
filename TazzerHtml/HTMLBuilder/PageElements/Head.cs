namespace TazzerHtml.HTMLBuilder.PageElements;

public class Head : IPageElement
{
    private string _style = String.Empty;
    private string _title = String.Empty;

    public string Title
    {
        get => _title;
        set => _title = String.Format($"\n\t<title>{value}</title>");
    }

    public string Style
    {
        get => _style;
        set => _style = String.Format($"\n\t<link rel=\"stylesheet\" href=\"{value}\">");
    }

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