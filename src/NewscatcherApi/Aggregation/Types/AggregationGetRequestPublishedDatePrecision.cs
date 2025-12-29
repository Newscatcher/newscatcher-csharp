using System.Text.Json.Serialization;
using NewscatcherApi.Core;

namespace NewscatcherApi;

[JsonConverter(typeof(StringEnumSerializer<AggregationGetRequestPublishedDatePrecision>))]
[Serializable]
public readonly record struct AggregationGetRequestPublishedDatePrecision : IStringEnum
{
    public static readonly AggregationGetRequestPublishedDatePrecision Full = new(Values.Full);

    public static readonly AggregationGetRequestPublishedDatePrecision TimezoneUnknown = new(
        Values.TimezoneUnknown
    );

    public static readonly AggregationGetRequestPublishedDatePrecision Date = new(Values.Date);

    public AggregationGetRequestPublishedDatePrecision(string value)
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
    public static AggregationGetRequestPublishedDatePrecision FromCustom(string value)
    {
        return new AggregationGetRequestPublishedDatePrecision(value);
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
        AggregationGetRequestPublishedDatePrecision value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AggregationGetRequestPublishedDatePrecision value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AggregationGetRequestPublishedDatePrecision value) =>
        value.Value;

    public static explicit operator AggregationGetRequestPublishedDatePrecision(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Full = "full";

        public const string TimezoneUnknown = "timezone unknown";

        public const string Date = "date";
    }
}
