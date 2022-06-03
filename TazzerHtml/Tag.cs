namespace TazzerHtml;

using Components.Tag;

public static class Tag
{
    public static Paragraph Paragraph()
    {
        return new Paragraph();
    }

    public static Link Link()
    {
        return new Link();
    }

    public static Custom Custom(string tag, params string[] attributes)
    {
        return new Custom(tag, attributes);
    }
}