namespace HtmlGenerator.Attributes;

public interface IGlobalAttributes
{
    public string AddClass(params string[] @class);
    public string AddId(string id);
}