namespace HtmlGenerator.Components.Attributes;

public class GlobalAttributes : IGlobalAttributes
{
    public string AddId(string id)
    {
        return String.Format($" id=\"{id}\"");
    }

    public string AddClass(params string[] @class)
    {
        if (@class.Length <= 0) return "";
    
        var classStr = String.Join(" ", @class);
        return String.Format($" class=\"{classStr}\"");
    }
}