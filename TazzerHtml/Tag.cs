namespace TazzerHtml;

using Components.Tag;

/// <summary>
/// Creates HTML tags.
/// </summary>
public static class Tag
{
    /// <summary>Gets an instance of &lt;p&gt; tag</summary>
    /// <returns> <see cref="TazzerHtml.Components.Tag.Paragraph"/></returns>
    public static Paragraph Paragraph()
    {
        return new Paragraph();
    }

    // <summary>Gets an instance of &lt;a&gt; tag</summary>
    /// <returns> <see cref="TazzerHtml.Components.Tag.Link"/></returns>
    public static Link Link()
    {
        return new Link();
    }

    /// <summary>
    /// Gets an instance of a <see cref="TazzerHtml.Components.Tag.Custom"/>
    /// Creates a custom tag based on passed parameters 
    /// </summary>
    /// <param name="tag">HTML tag</param>
    /// <param name="attributes">HTML attributes</param>
    /// <returns></returns>
    public static Custom Custom(string tag, params string[] attributes)
    {
        return new Custom(tag, attributes);
    }
}