using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<AggregationBy>))]
[Serializable]
public readonly record struct AggregationBy : IStringEnum
{
    public static readonly AggregationBy Day = new(Values.Day);

    public static readonly AggregationBy Hour = new(Values.Hour);

    public static readonly AggregationBy Month = new(Values.Month);

    public AggregationBy(string value)
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
    public static AggregationBy FromCustom(string value)
    {
        return new AggregationBy(value);
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

    public static bool operator ==(AggregationBy value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AggregationBy value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AggregationBy value) => value.Value;

    public static explicit operator AggregationBy(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Day = "day";

        public const string Hour = "hour";

        public const string Month = "month";
    }
}
