namespace TazzerHtml.Components.Attributes;

/// <summary>
/// Represents global attributes interface
/// </summary>
public interface IGlobalAttributes
{
    /// <summary>
    /// Add one or multiple class attributes to this HTML element.
    /// </summary>
    /// <param name="class"></param>
    /// <returns></returns>
    public string AddClass(params string[] @class);

    /// <summary>
    /// Add id attribute to this HTML element.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public string AddId(string id);
}