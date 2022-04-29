namespace HtmlGenerator.Nodes;

public static class Node
{
    public static Paragraph Paragraph()
    {
        return new Paragraph();
    }

    public static Link Link()
    {
        return new Link();
    }
}