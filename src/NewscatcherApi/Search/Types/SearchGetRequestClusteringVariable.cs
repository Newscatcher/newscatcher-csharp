using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<SearchGetRequestClusteringVariable>))]
[Serializable]
public readonly record struct SearchGetRequestClusteringVariable : IStringEnum
{
    public static readonly SearchGetRequestClusteringVariable Content = new(Values.Content);

    public static readonly SearchGetRequestClusteringVariable Title = new(Values.Title);

    public static readonly SearchGetRequestClusteringVariable Summary = new(Values.Summary);

    public SearchGetRequestClusteringVariable(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static SearchGetRequestClusteringVariable FromCustom(string value)
    {
        return new SearchGetRequestClusteringVariable(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(SearchGetRequestClusteringVariable value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SearchGetRequestClusteringVariable value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SearchGetRequestClusteringVariable value) => value.Value;

    public static explicit operator SearchGetRequestClusteringVariable(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Content = "content";

        public const string Title = "title";

        public const string Summary = "summary";
    }
}
