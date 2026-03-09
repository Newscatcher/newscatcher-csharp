using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<AggregationGetRequestSortBy>))]
[Serializable]
public readonly record struct AggregationGetRequestSortBy : IStringEnum
{
    public static readonly AggregationGetRequestSortBy Relevancy = new(Values.Relevancy);

    public static readonly AggregationGetRequestSortBy Date = new(Values.Date);

    public static readonly AggregationGetRequestSortBy Rank = new(Values.Rank);

    public AggregationGetRequestSortBy(string value)
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
    public static AggregationGetRequestSortBy FromCustom(string value)
    {
        return new AggregationGetRequestSortBy(value);
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

    public static bool operator ==(AggregationGetRequestSortBy value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AggregationGetRequestSortBy value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AggregationGetRequestSortBy value) => value.Value;

    public static explicit operator AggregationGetRequestSortBy(string value) => new(value);

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
