namespace HtmlGenerator.Components.Tag;

public class Custom : HtmlTag
{
    public Custom(string tag, params string[] attributes) : base(tag)
    {
        _attributes.AddRange(attributes);
    }
    
    public Custom(string tag, string content, params string[] attributes) : base(tag)
    {
        _attributes.AddRange(attributes);
        Content = content;
    }
    
    
    public Custom InnerHtml(string content) => this.ExtensionInnerHtml(content);
}