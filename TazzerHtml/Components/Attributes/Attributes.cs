namespace TazzerHtml.Components.Attributes;

/// <summary>
/// Represents HTML attributes.
/// </summary>
public static class Attributes
{
    /// <summary>
    /// Creates an HTML class attribute based on a passed value.
    /// </summary>
    /// <param name="class">HTML class value or values</param>
    /// <returns></returns>
    public static string Class(params string[] @class)
    {
        var classStr = String.Join(" ", @class);
        return String.Format($" class=\"{classStr}\"");
    }

    /// <summary>
    /// /// Creates an HTML id attribute based on a passed value.
    /// </summary>
    /// <param name="id">HTML id value</param>
    /// <returns></returns>
    public static string Id(string id) => String.Format($" id=\"{id}\"");

    /// <summary>
    /// /// Creates an HTML href attribute based on a passed value.
    /// </summary>
    /// <param name="href">HTML href value</param>
    /// <returns></returns>
    public static string Href(string href) => String.Format($" href=\"{href}\"");
}