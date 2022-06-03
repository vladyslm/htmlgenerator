namespace TazzerHtml;

using Components;

/// <summary>
/// Create HTML section tags.
/// </summary>
public static class Component
{
    /// <summary>
    /// Gets an instance of &lt;div&gt; tag.
    /// </summary>
    /// <returns><see cref="TazzerHtml.Components.Div"/></returns>
    public static Div Div()
    {
        return new Div();
    }

    /// <summary>
    /// Gets an instance of &lt;div&gt; tag.
    /// </summary>
    /// <returns><see cref="TazzerHtml.Components.Article"/></returns>
    public static Article Article()
    {
        return new Article();
    }
}