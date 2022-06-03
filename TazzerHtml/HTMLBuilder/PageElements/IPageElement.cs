namespace TazzerHtml.HTMLBuilder.PageElements;

/// <summary>
/// Represent HTML page interface.
/// </summary>
public interface IPageElement
{
    /// <summary>
    /// Assemble <see cref="IPageElement"/>
    /// </summary>
    /// <returns></returns>
    public string Prepare();
}