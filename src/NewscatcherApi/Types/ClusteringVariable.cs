using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<ClusteringVariable>))]
[Serializable]
public readonly record struct ClusteringVariable : IStringEnum
{
    public static readonly ClusteringVariable Content = new(Values.Content);

    public static readonly ClusteringVariable Title = new(Values.Title);

    public static readonly ClusteringVariable Summary = new(Values.Summary);

    public ClusteringVariable(string value)
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
    public static ClusteringVariable FromCustom(string value)
    {
        return new ClusteringVariable(value);
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

    public static bool operator ==(ClusteringVariable value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClusteringVariable value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClusteringVariable value) => value.Value;

    public static explicit operator ClusteringVariable(string value) => new(value);

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
