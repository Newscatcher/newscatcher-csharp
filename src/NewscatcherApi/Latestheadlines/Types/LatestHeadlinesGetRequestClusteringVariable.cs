using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<LatestHeadlinesGetRequestClusteringVariable>))]
[Serializable]
public readonly record struct LatestHeadlinesGetRequestClusteringVariable : IStringEnum
{
    public static readonly LatestHeadlinesGetRequestClusteringVariable Content = new(
        Values.Content
    );

    public static readonly LatestHeadlinesGetRequestClusteringVariable Title = new(Values.Title);

    public static readonly LatestHeadlinesGetRequestClusteringVariable Summary = new(
        Values.Summary
    );

    public LatestHeadlinesGetRequestClusteringVariable(string value)
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
    public static LatestHeadlinesGetRequestClusteringVariable FromCustom(string value)
    {
        return new LatestHeadlinesGetRequestClusteringVariable(value);
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

    public static bool operator ==(
        LatestHeadlinesGetRequestClusteringVariable value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LatestHeadlinesGetRequestClusteringVariable value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LatestHeadlinesGetRequestClusteringVariable value) =>
        value.Value;

    public static explicit operator LatestHeadlinesGetRequestClusteringVariable(string value) =>
        new(value);

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
