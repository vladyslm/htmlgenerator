namespace TazzerHtml.HTMLBuilder.PageElements;

public class Page : IPageElement
{
    
    private string _lang = String.Empty;

    public string Language
    {
        get => _lang;
        set => _lang = String.Format($" lang=\"{value}\"");
    }

    public Head Head { get; }

    public Body Body { get; }

    public Page(Head headElement, Body bodyElement)
    {
        Head = headElement;
        Body = bodyElement;
    }

    public string Prepare()
    {
        var body = Body.Prepare();
        var head = Head.Prepare();
        return String.Format($"<html{_lang}>\n{head}\n{body}\n</html>");
    }
}