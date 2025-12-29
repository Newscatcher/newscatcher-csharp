using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<SortBy>))]
[Serializable]
public readonly record struct SortBy : IStringEnum
{
    public static readonly SortBy Relevancy = new(Values.Relevancy);

    public static readonly SortBy Date = new(Values.Date);

    public static readonly SortBy Rank = new(Values.Rank);

    public SortBy(string value)
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
    public static SortBy FromCustom(string value)
    {
        return new SortBy(value);
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

    public static bool operator ==(SortBy value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(SortBy value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(SortBy value) => value.Value;

    public static explicit operator SortBy(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Relevancy = "relevancy";

        public const string Date = "date";

        public const string Rank = "rank";
    }
}
