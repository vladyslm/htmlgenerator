namespace HtmlGenerator;

using Components;

public static class Component
{
    public static Div Div()
    {
        return new Div();
    }

    public static Article Article()
    {
        return new Article();
    }
}